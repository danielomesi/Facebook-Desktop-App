using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        // sum minutes logged in and show statistics about it
        // option for timer in bottom of form
        // statistics in about section
        // option 1: average check ins (like: you post every 2 weeks)
        // option 2: average photos in album
        // option 3: make ai correction for text for post 
        // create post in ordered time

        const int k_StartIndex = 0;
        FacebookWrapper.LoginResult m_LoginResult;
        ActiveUserManager m_ActiveUserManager;
        AppSettings m_AppSettings;
        int m_CurrentShowedStatusIndex;
        int m_CurrentShowedImagePostIndex;
        int m_CurrentShowedAlbumIndex;
        int m_CurrentShowedPhotoIndexInAlbum;
        int m_CurrentShowedSuggestedAiTextIndex;

        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 25;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns");

            if (m_LoginResult == null)
            {
                login();
            }
        }

        private void login()
        {
            try
            {
                m_LoginResult = FacebookService.Login(
                ///Desig's app ID: 1450160541956417  
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
            m_ActiveUserManager = new ActiveUserManager(m_LoginResult.LoggedInUser);

            buttonLogin.Text = $"Logged in as {m_LoginResult.LoggedInUser.Name}";
            buttonLogin.BackColor = Color.LightGreen;
            buttonLogin.Enabled = false;
            RememberMeCheckBox.Enabled = false;
            buttonLogout.Enabled = true;

            initiateFormData();   
        }

        private void initiateFormData()
        {
            bool isLoggedIn = true;
            toggleDisplayedElements(isLoggedIn);

            populateAboutTab();

            populateListBox(FavoritePagesListBox,
                m_ActiveUserManager.FetchNamesOfObjectList<Page>(m_LoginResult.LoggedInUser.LikedPages.ToList()));
            populateListBox(FriendsListBox, m_ActiveUserManager.GenerateFriendsNamesDummyData());
            populateListBox(AlbumsListBox,
                m_ActiveUserManager.FetchNamesOfObjectList<Album>(m_LoginResult.LoggedInUser.Albums.ToList()));
            populateStatus(k_StartIndex);
            populateImagePost(k_StartIndex);
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            m_LoginResult = null;
            m_ActiveUserManager = null;

            resetFormData();
        }

        private void resetFormData()
        {
            buttonLogin.Text = "Login";
            buttonLogin.BackColor = buttonLogout.BackColor;
            buttonLogin.Enabled = true;
            buttonLogout.Enabled = false;
            RememberMeCheckBox.Enabled = true;

            toggleDisplayedElements(false);

            //AlbumsListBox.Items.Clear();
            //FriendsListBox.Items.Clear();
            //FavoritePagesListBox.Items.Clear();
            FavPagePictureBox.Image = null;
            ImagePostPictureBox.Image = null;
            AlbumPictureBox.Image = null;
            PostRichTextBox.Text = string.Empty;
        }

        private void toggleDisplayedElements(bool i_Show)
        {
            FavoritePagesLabel.Visible = i_Show;
            MyStatusesLabel.Visible = i_Show;
            MyImagePostsLabel.Visible = i_Show; 
            MyFriendsLabel.Visible = i_Show;
            FavoritePagesListBox.Visible = i_Show;
            PostRichTextBox.Visible = i_Show;
            ImagePostPictureBox.Visible = i_Show;
            FriendsListBox.Visible = i_Show;
            FavPagePictureBox.Visible = i_Show;
            PreviousImagePostButton.Visible = i_Show;
            NextImagePostButton.Visible = i_Show;
            PreviousStatusButton.Visible = i_Show;
            NextStatusButton.Visible = i_Show;

            foreach (Control control in AboutTab.Controls)
            {
                control.Visible = i_Show;
            }

            foreach (Control control in AlbumsTab.Controls)
            {
                control.Visible = i_Show;
            }
        }


        private void formMainShown(object sender, EventArgs e)
        {
            m_AppSettings = AppSettings.LoadFromFile();

            if (m_AppSettings != null)
            {
                this.Size = m_AppSettings.m_LastWindowSize;
                this.Location = m_AppSettings.m_LastWindowLocation;
                RememberMeCheckBox.Checked = m_AppSettings.m_RememberUser;

                m_LoginResult = FacebookService.Connect(m_AppSettings.m_LastAccessToken);

                if (string.IsNullOrEmpty(m_LoginResult.ErrorMessage))
                {
                    setLoggedInUser();
                }
            }
            else
            {
                m_AppSettings = new AppSettings();
            }
        }

        private void formMainFormClosing(object sender, FormClosingEventArgs e)
        {
            if (RememberMeCheckBox.Checked && m_LoginResult != null &&
                string.IsNullOrEmpty(m_LoginResult.ErrorMessage))
            {
                m_AppSettings.m_LastAccessToken = m_LoginResult.AccessToken;
                m_AppSettings.m_RememberUser = true;
                m_AppSettings.m_LastWindowSize = this.Size;
                m_AppSettings.m_LastWindowLocation = this.Location;
                m_AppSettings.SaveToFile();
            }
            else
            {
                if (!AppSettings.ClearFile())
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

        private void handlePreviousAndNextButtons(int m_CurrentShowedIndex, int m_SizeOfObjects, Button i_PreviousButton, Button i_NextButton)
        {
            i_PreviousButton.Enabled = (m_CurrentShowedIndex != (m_SizeOfObjects - 1));
            i_NextButton.Enabled = (m_CurrentShowedIndex != 0);
        }

        // -------------
        // About
        // -------------
        private void populateAboutTab()
        {
            User currentUser = m_LoginResult.LoggedInUser;
            FullNameLabelData.Text = !string.IsNullOrEmpty(currentUser.Name) ? currentUser.Name : string.Empty;
            birthdayLabelData.Text = !string.IsNullOrEmpty(currentUser.Birthday) ? currentUser.Birthday : string.Empty;
            genderLabelData.Text = !string.IsNullOrEmpty(currentUser.Gender.ToString()) ? currentUser.Gender.ToString() : string.Empty;
            emailLabelData.Text = !string.IsNullOrEmpty(currentUser.Email) ? currentUser.Email : string.Empty;
        }

        // -------------
        // Pages
        // -------------
        private void favoritePagesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FacebookWrapper.ObjectModel.Page chosenPage;
            string imageUrl;

            chosenPage = m_LoginResult.LoggedInUser.LikedPages[(sender as ListBox).SelectedIndex];
            imageUrl = ActiveUserManager.FetchPagePhoto(chosenPage);
            FavPagePictureBox.Load(imageUrl);
        }

        // -------------
        // Posts
        // -------------
        private void populateStatus(int i_PostIndex)
        {
            Post post;

            post = m_ActiveUserManager.FetchPostByIndex(Post.eType.status, i_PostIndex);
            if (post != null)
            {
                PostRichTextBox.Text = post.Message;
                m_CurrentShowedStatusIndex = i_PostIndex;
                handlePreviousAndNextButtons(m_CurrentShowedStatusIndex, m_ActiveUserManager.m_StatusPostsListSize, PreviousStatusButton, NextStatusButton);
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

        // -------------
        // Image Posts
        // -------------
        private void populateImagePost(int i_PostIndex)
        {
            Post post;

            post = m_ActiveUserManager.FetchPostByIndex(Post.eType.photo, i_PostIndex);
            if (post != null)
            {
                ImagePostPictureBox.Load(post.PictureURL);
                m_CurrentShowedImagePostIndex = i_PostIndex;
                handlePreviousAndNextButtons(m_CurrentShowedImagePostIndex, m_ActiveUserManager.m_PhotoPostsListSize, PreviousImagePostButton, NextImagePostButton);
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
            Post post;
            string message;

            post = m_ActiveUserManager.FetchPostByIndex(Post.eType.photo, m_CurrentShowedImagePostIndex);
            message = post.Message;

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
            m_ActiveUserManager.m_AiSuggestionsForStatuses = await AITextGenerator.AITextGenerator.ParaphraseTextAsync(WriteStatusRichTextBox.Text);
            populateAiSuggestionTextBox(k_StartIndex);
        }

        private void populateAiSuggestionTextBox(int i_SuggestionIndex)
        {
            List<string> suggestionsList = m_ActiveUserManager.m_AiSuggestionsForStatuses;

            if (suggestionsList.Any())
            {
                SuggestedByAITextBox.Text = suggestionsList[i_SuggestionIndex];
                m_CurrentShowedSuggestedAiTextIndex = i_SuggestionIndex;
                handlePreviousAndNextButtons(m_CurrentShowedSuggestedAiTextIndex, suggestionsList.Count, PreviousSuggestedTextButton, NextSuggestedTextButton);
                PostActionButton.Enabled = true;
            }
            else
            {
                SuggestedByAITextBox.Text = "This is not a valid text to rephrase. Please avoid new lines and special characters.";
                NextSuggestedTextButton.Enabled = false;
                PreviousSuggestedTextButton.Enabled = false;
                PostActionButton.Enabled = false;
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
                Status postedStatus = m_LoginResult.LoggedInUser.PostStatus(SuggestedByAITextBox.Text);
                MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}