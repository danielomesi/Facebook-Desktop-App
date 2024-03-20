using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        //consts
        private const string k_AppSettingsFilePath = @".\App Settings.xml";
        private const string k_ElapsedTimeFilePath = @".\Elapsed Time.xml";
        private const string k_MessageNotFoundText = "This status has no textual message to show";
        private const int k_StartIndex = 0;
        private const int k_CollectionLimit = 25;
        //
        private LoginResult m_LoginResult;
        private ActiveUserManager m_ActiveUserManager;
        private AppSettings m_AppSettings;
        private SessionTimer m_SessionTimer;
        private TimeData m_TimeData;
        private DateTime m_LastLoginDateTime;
        private int m_CurrentShowedStatusIndex;
        private int m_CurrentShowedImagePostIndex;
        private int m_CurrentShowedAlbumIndex;
        private int m_CurrentShowedPhotoIndexInAlbum;
        private int m_CurrentShowedSuggestedAiTextIndex;
        //
        private int m_CurrentShowedFilteredStatusIndex;

        public FormMain()
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = k_CollectionLimit;
        }

        private void formMain_Shown(object sender, EventArgs e)
        {
            m_AppSettings = FileDataHandler.LoadFromFile(k_AppSettingsFilePath, typeof(AppSettings)) as AppSettings;

            if (m_AppSettings != null)
            {
                this.Size = m_AppSettings.LastWindowSize;
                this.Location = m_AppSettings.LastWindowLocation;
                checkBoxRememberMe.Checked = m_AppSettings.RememberUser;
                new Thread(this.autoLogin).Start();
            }
            else
            {
                m_AppSettings = new AppSettings();
                setLoginButtons(false);
            }

            loadUsageTime();
            initiateTimer();
        }

        public void bindDataToListBox<T>(ListBox i_ListBox, List<T> i_AllElements, BindingSource i_BindingSource) where T : class
        {
            if (!i_ListBox.InvokeRequired)
            {
                i_BindingSource.DataSource = i_AllElements;
            }
            else
            {
                i_ListBox.Invoke(new Action(() => i_BindingSource.DataSource = i_AllElements));
            }
        }

        // -------------
        // Login
        // -------------
        private void buttonLoginClick(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns");

            if (m_LoginResult == null)
            {
                new Thread(this.login).Start();
            }
        }

        private void setLoginButtons(bool i_IsConnected)
        {
            buttonLogin.Enabled = !i_IsConnected;
            buttonLogout.Enabled = i_IsConnected;
            checkBoxRememberMe.Enabled = !i_IsConnected;
        }

        private void autoLogin()
        {
            m_LoginResult = FacebookService.Connect(m_AppSettings.LastAccessToken);
            if (string.IsNullOrEmpty(m_LoginResult.ErrorMessage))
            {
                setLoggedInUser();
            }
        }

        private void login()
        {
            try
            {
                m_LoginResult = FacebookService.Login(
                textBoxAppID.Text,
                "email",
                "public_profile",
                "user_friends",
                "user_gender",
                "user_likes",
                "user_hometown",
                "user_photos",
                "user_posts",
                "user_videos",
                "user_birthday",
                "user_location",
                "user_link",
                "user_age_range",
                "user_events"
                );
                setLoggedInUser();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login failed! Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                m_LoginResult = null;
            }
        }

        private void setLoggedInUser()
        {
            if (buttonLogin.InvokeRequired)
            {
                buttonLogin.Invoke(new Action(setLoggedInUser));
            }
            else
            {
                m_ActiveUserManager = new ActiveUserManager(m_LoginResult.LoggedInUser);
                buttonLogin.Text = $"Logged in as {m_LoginResult.LoggedInUser.Name}";
                buttonLogin.BackColor = Color.LightBlue;
                buttonLogin.Enabled = false;
                checkBoxRememberMe.Enabled = false;
                buttonLogout.Enabled = true;
                textBoxAppID.Enabled = false;
                initiateFormData();
            }
        }

        private void initiateFormData()
        {
            bool isLoggedIn = true;
            List<string> friendsNames = m_ActiveUserManager.FetchNamesOfObjectList<User>(m_LoginResult.LoggedInUser.Friends.ToList());
            List<string> albumsNames = m_ActiveUserManager.FetchNamesOfObjectList<Album>(m_LoginResult.LoggedInUser.Albums.ToList());

            toggleDisplayedElements(isLoggedIn);
            bindDataToListBox<Page>(listBoxFavPagesList, m_LoginResult.LoggedInUser.LikedPages.ToList<Page>(), pageBindingSource);
            bindDataToListBox<User>(friendsListBox, m_LoginResult.LoggedInUser.Friends.ToList<User>(), userBindingSource);
            populateStatus(k_StartIndex);
            populateListBox(AlbumsListBox, albumsNames);
            populateImagePost(k_StartIndex);
            populateAboutTab();
        }

        private void toggleDisplayedElements(bool i_Show)
        {
            foreach (TabPage tabPage in tabControl.TabPages)
            {
                if (tabPage != tabLogin)
                {
                    foreach (Control control in tabPage.Controls)
                    {
                        control.Visible = i_Show;
                    }
                }
            }
        }

        // -------------
        // Logout
        // -------------
        private void buttonLogoutClick(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            m_LoginResult = null;
            m_ActiveUserManager = null;
            resetFormData();
        }

        private void resetFormData()
        {
            bool shouldShow = false;

            buttonLogin.Text = "Login";
            buttonLogin.BackColor = buttonLogout.BackColor;
            buttonLogin.Enabled = true;
            buttonLogout.Enabled = false;
            checkBoxRememberMe.Enabled = true;
            textBoxAppID.Enabled = true;
            toggleDisplayedElements(shouldShow);
            pictureBoxImagePost.Image = null;
            AlbumPictureBox.Image = null;
            richTextBoxStatus.Text = string.Empty;
        }

        private void formMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            terminateTimer();

            if (checkBoxRememberMe.Checked && m_LoginResult != null &&
                string.IsNullOrEmpty(m_LoginResult.ErrorMessage))
            {
                m_AppSettings.LastAccessToken = m_LoginResult.AccessToken;
                m_AppSettings.RememberUser = true;
                m_AppSettings.LastWindowSize = this.Size;
                m_AppSettings.LastWindowLocation = this.Location;
                FileDataHandler.SaveToFile(k_AppSettingsFilePath, m_AppSettings, typeof(AppSettings));
            }
            else
            {
                if (!FileDataHandler.ClearFile(k_AppSettingsFilePath))
                {
                    MessageBox.Show("Deleting your personal settings failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void populateListBox(ListBox i_ListBox, List<string> i_NamesList)
        {
            i_ListBox.Items.Clear();
            i_ListBox.Items.AddRange(i_NamesList.ToArray());
        }

        private void handlePreviousAndNextButtons(int i_CurrentShowedIndex, int i_SizeOfObjects, Button i_PreviousButton, Button i_NextButton)
        {
            //i_PreviousButton.Enabled = i_CurrentShowedIndex > 0;
            //i_NextButton.Enabled = i_CurrentShowedIndex < i_SizeOfObjects;
            i_PreviousButton.Enabled = (i_CurrentShowedIndex != (i_SizeOfObjects - 1));
            i_NextButton.Enabled = (i_CurrentShowedIndex != 0);
        }

        // -------------
        // About
        // -------------
        private void populateAboutTab()
        {
            User currentUser = m_LoginResult.LoggedInUser;
            labelDataFullName.Text = !string.IsNullOrEmpty(currentUser.Name) ? currentUser.Name : string.Empty;
            labelDataBirthday.Text = !string.IsNullOrEmpty(currentUser.Birthday) ? currentUser.Birthday : string.Empty;
            labelDataGender.Text = !string.IsNullOrEmpty(currentUser.Gender.ToString()) ? currentUser.Gender.ToString() : string.Empty;
            labelDataEmail.Text = !string.IsNullOrEmpty(currentUser.Email) ? currentUser.Email : string.Empty;
        }

        // -------------
        // Pages
        // -------------


        // -------------
        // Posts
        // -------------
        private void populateStatus(int i_PostIndex)
        {
            Post post = m_ActiveUserManager.FetchPostByIndex(Post.eType.status, i_PostIndex);

            if (post != null)
            {
                richTextBoxStatus.Text = !string.IsNullOrEmpty(post.Message) ? post.Message : k_MessageNotFoundText;
                m_CurrentShowedStatusIndex = i_PostIndex;
                handlePreviousAndNextButtons(m_CurrentShowedStatusIndex, m_ActiveUserManager.m_StatusPostsListSize, buttonPreviousStatus, buttonNextStatus);
            }
        }

        private void previousPostButton_Click(object sender, EventArgs e)
        {
            populateStatus(m_CurrentShowedStatusIndex + 1);
        }

        private void nextPostButton_Click(object sender, EventArgs e)
        {
            populateStatus(m_CurrentShowedStatusIndex - 1);
        }

        private void populateFilteredStatus(int i_PostIndex)
        {
            Post post = m_ActiveUserManager.m_PostsFilteredByTextOfUser[i_PostIndex];

            if (post != null)
            {
                richTextBoxFilteredStatus.Text = post.Message;
                labelActualTypeOfFilteredPost.Text = post.Type.ToString();
                m_CurrentShowedFilteredStatusIndex = i_PostIndex;
                handlePreviousAndNextButtons(m_CurrentShowedFilteredStatusIndex, m_ActiveUserManager.m_PostsFilteredByTextOfUser.Count, buttonPreviousFilteredStatuses, buttonNextFilteredStatuses);
            }
        }

        // -------------
        // Image Posts
        // -------------
        private void populateImagePost(int i_PostIndex)
        {
            Post post = m_ActiveUserManager.FetchPostByIndex(Post.eType.photo, i_PostIndex);
            
            if (post != null)
            {
                pictureBoxImagePost.Load(post.PictureURL);
                m_CurrentShowedImagePostIndex = i_PostIndex;
                handlePreviousAndNextButtons(m_CurrentShowedImagePostIndex, m_ActiveUserManager.m_PhotoPostsListSize, buttonPreviousImagePost, buttonNextImagePost);
            }
        }

        private void previousImagePostButton_Click(object sender, EventArgs e)
        {
            populateImagePost(m_CurrentShowedImagePostIndex + 1);
        }

        private void nextImagePostButton_Click(object sender, EventArgs e)
        {
            populateImagePost(m_CurrentShowedImagePostIndex - 1);
        }

        private void imagePostPictureBox_Click(object sender, EventArgs e)
        {
            Post post = m_ActiveUserManager.FetchPostByIndex(Post.eType.photo, m_CurrentShowedImagePostIndex);
            string message = post.Message;

            if (!string.IsNullOrEmpty(message))
            {
                MessageBox.Show(message);
            }
        }

        // -------------
        // Albums
        // -------------
        private void albumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Album currentAlbum;

            m_CurrentShowedPhotoIndexInAlbum = 0;
            m_CurrentShowedAlbumIndex = (sender as ListBox).SelectedIndex;
            currentAlbum = m_LoginResult.LoggedInUser.Albums[m_CurrentShowedAlbumIndex];
            AlbumImagesLabel.Text = !string.IsNullOrEmpty(currentAlbum.Name) ? currentAlbum.Name : string.Empty;
            albumCreatedAtLabel.Text = !string.IsNullOrEmpty(currentAlbum.CreatedTime.ToString()) ? string.Format("Created At: {0}", currentAlbum.CreatedTime) : string.Empty;
            populateAlbumPhoto(m_CurrentShowedPhotoIndexInAlbum);
        }

        private void populateAlbumPhoto(int i_PhotoIndexToChange)
        {
            Album currentAlbum = m_LoginResult.LoggedInUser.Albums[m_CurrentShowedAlbumIndex];
            Photo currentPhoto = currentAlbum.Photos[i_PhotoIndexToChange];

            AlbumPictureBox.Load(currentPhoto.PictureNormalURL);
            m_CurrentShowedPhotoIndexInAlbum = i_PhotoIndexToChange;
            handlePreviousAndNextButtons(m_CurrentShowedPhotoIndexInAlbum, currentAlbum.Photos.Count, AlbumImagePerviousButton, AlbumImageNextButton);
        }

        private void albumImagePerviousButton_Click(object sender, EventArgs e)
        {
            populateAlbumPhoto(m_CurrentShowedPhotoIndexInAlbum + 1);
        }

        private void albumImageNextButton_Click(object sender, EventArgs e)
        {
            populateAlbumPhoto(m_CurrentShowedPhotoIndexInAlbum - 1);
        }

        // -------------
        // AI
        // -------------
        private async void startAiButton_Click(object sender, EventArgs e)
        {
            m_ActiveUserManager.m_AiSuggestionsForStatuses = await AITextGenerator.AITextGenerator.Instance.ParaphraseTextAsync(richTextBoxWritePhrase.Text);
            populateAiSuggestionTextBox(k_StartIndex);
        }

        private void populateAiSuggestionTextBox(int i_SuggestionIndex)
        {
            List<string> suggestionsList = m_ActiveUserManager.m_AiSuggestionsForStatuses;

            if (suggestionsList.Any())
            {
                textBoxSuggestedByAI.Text = suggestionsList[i_SuggestionIndex];
                m_CurrentShowedSuggestedAiTextIndex = i_SuggestionIndex;
                handlePreviousAndNextButtons(m_CurrentShowedSuggestedAiTextIndex, suggestionsList.Count, buttonPreviousSuggestedText, buttonNextSuggestedText);
                ButtonPost.Enabled = true;
            }
            else
            {
                textBoxSuggestedByAI.Text = "This is not a valid text to rephrase. Please avoid new lines and special characters.";
                buttonNextSuggestedText.Enabled = false;
                buttonPreviousSuggestedText.Enabled = false;
                ButtonPost.Enabled = false;
            }
        }

        private void previousSuggestedTextButton_Click(object sender, EventArgs e)
        {
            populateAiSuggestionTextBox(m_CurrentShowedSuggestedAiTextIndex + 1);
        }

        private void nextSuggestedTextButton_Click(object sender, EventArgs e)
        {
            populateAiSuggestionTextBox(m_CurrentShowedSuggestedAiTextIndex - 1);
        }

        private void postActionButton_Click(object sender, EventArgs e)
        {
            try
            {
                Status postedStatus = m_LoginResult.LoggedInUser.PostStatus(textBoxSuggestedByAI.Text);
                MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Currently posting status on facebook isn't supported");
            }
        }

        // -------------
        // Timer
        // -------------
        private void initiateTimer()
        {
            m_SessionTimer = new SessionTimer();
            m_SessionTimer.Start(updateTimeLabel);
        }

        private void terminateTimer()
        {
            TimeData timeData = new TimeData();
            double elapsedSeconds = m_SessionTimer.GetSeconds();

            timeData.m_ElapsedSeconds = elapsedSeconds + m_TimeData.m_ElapsedSeconds;
            timeData.m_LastLoginDateTime = m_LastLoginDateTime;
            m_SessionTimer.Stop();
            FileDataHandler.SaveToFile(k_ElapsedTimeFilePath, timeData, typeof(TimeData));
        }

        private void updateTimeLabel(object sender, EventArgs e)
        {
            TimeSpan elapsedTime = m_SessionTimer.Stopwatch.Elapsed;
            TimeSpan oldElapsedTime = TimeSpan.FromSeconds(m_TimeData.m_ElapsedSeconds);
            TimeSpan overallElapsedTime = elapsedTime + oldElapsedTime;
            string overallTimeAsString = m_SessionTimer.ConvertTimeSpanToString(overallElapsedTime);
            string elapsedTimeAsString = m_SessionTimer.ConvertTimeSpanToString(elapsedTime);

            labelElapsedTime.Text = $"Elapsed Time: {elapsedTimeAsString}";
            labelOverallElapsedTime.Text = $"Overall Elapsed Time: {overallTimeAsString}";
        }

        private void loadUsageTime()
        {
            m_TimeData = FileDataHandler.LoadFromFile(k_ElapsedTimeFilePath, typeof(TimeData)) as TimeData;
            m_LastLoginDateTime = DateTime.Now;

            if (m_TimeData == null)
            {
                m_TimeData = new TimeData();
                m_TimeData.m_ElapsedSeconds = 0;
                labelLastLogin.Text = string.Empty;
            }
            else
            {
                labelLastLogin.Text = $"Last login: {m_TimeData.m_LastLoginDateTime}";
            }
        }

        private void uRLLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start((sender as  LinkLabel).Tag.ToString());
        }

        private void buttonFilterStatuses_Click(object sender, EventArgs e)
        {
            List<Post> posts = m_ActiveUserManager.FetchPostsListByText(textBoxFilteredStatusInput.Text.ToLower());
            m_ActiveUserManager.m_PostsFilteredByTextOfUser = posts;
            if (posts != null && posts.Count > 0)
            {
                populateFilteredStatus(0);
            }
            else
            {
                buttonNextFilteredStatuses.Enabled = false;
                buttonPreviousFilteredStatuses.Enabled = false;
                richTextBoxFilteredStatus.Text = string.Empty;
                labelActualTypeOfFilteredPost.Text = string.Empty;
            }
        }

        private void buttonPreviousFilteredStatuses_Click(object sender, EventArgs e)
        {
            populateFilteredStatus(m_CurrentShowedFilteredStatusIndex + 1);
        }

        private void buttonNextFilteredStatuses_Click(object sender, EventArgs e)
        {
            populateFilteredStatus(m_CurrentShowedFilteredStatusIndex - 1);
        }
    }
}