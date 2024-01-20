using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        const int k_FirstPostIndex = 0;
        FacebookWrapper.LoginResult m_LoginResult;
        ActiveUserManager m_ActiveUserManager;
        AppSettings m_AppSettings;
        int m_CurrentShowedStatusIndex;
        int m_CurrentShowedImagePostIndex;


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
                "user_link");
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

            buttonLogin.Text = $"Logged in as {m_ActiveUserManager.GetNameOfUser()}";
            buttonLogin.BackColor = Color.LightGreen;
            pictureBoxProfile.ImageLocation = m_LoginResult.LoggedInUser.PictureNormalURL;
            buttonLogin.Enabled = false;
            RememberMeCheckBox.Enabled = false;
            buttonLogout.Enabled = true;


            populateLikedPages();
            populateStatus(k_FirstPostIndex);
            populateImagePost(k_FirstPostIndex);
        }

        private void populateLikedPages()
        {
            List<string> namesList;

            namesList = m_ActiveUserManager.FetchLikedPagesNames();
            FavoritePagesListBox.Items.AddRange(namesList.ToArray());
        }

        private void populateStatus(int i_PostIndex)
        {
            FacebookWrapper.ObjectModel.Post post;

            post = m_ActiveUserManager.FetchPostByIndex(Post.eType.status, i_PostIndex);
            if (post != null)
            {
                PostRichTextBox.Text = post.Message;
                m_CurrentShowedStatusIndex = i_PostIndex;
                HandlePreviousAndNextButtons(m_CurrentShowedStatusIndex, m_ActiveUserManager.m_StatusPostsListSize,
                    PreviousStatusButton, NextStatusButton);
            }
        }

        private void populateImagePost(int i_PostIndex)
        {
            FacebookWrapper.ObjectModel.Post post;

            post = m_ActiveUserManager.FetchPostByIndex(Post.eType.photo, i_PostIndex);
            if (post != null)
            {
                ImagePostPictureBox.Load(post.PictureURL);
                m_CurrentShowedImagePostIndex = i_PostIndex;
                HandlePreviousAndNextButtons(m_CurrentShowedImagePostIndex, m_ActiveUserManager.m_PhotoPostsListSize,
                    PreviousImagePostButton, NextImagePostButton);
            }
        }

        private void HandlePreviousAndNextButtons(int m_CurrentShowedIndex, int m_SizeOfObjects,
            Button i_PreviousButton, Button i_NextButton)
        {
            if (m_CurrentShowedIndex == (m_SizeOfObjects - 1))
            {
                i_PreviousButton.Enabled = false;
            }
            else
            {
                i_PreviousButton.Enabled = true;
            }

            if (m_CurrentShowedIndex == 0)
            {
                i_NextButton.Enabled = false;
            }
            else
            {
                i_NextButton.Enabled = true;
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            buttonLogin.Text = "Login";
            buttonLogin.BackColor = buttonLogout.BackColor;
            m_LoginResult = null;
            buttonLogin.Enabled = true;
            buttonLogout.Enabled = false;
            RememberMeCheckBox.Enabled = true;
        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            m_AppSettings = AppSettings.LoadFromFile();

            if (m_AppSettings != null)
            {
                this.Size = m_AppSettings.LastWindowSize;
                this.Location = m_AppSettings.LastWindowLocation;
                this.RememberMeCheckBox.Checked = true;
                m_LoginResult = FacebookService.Connect(m_AppSettings.LastAccessToken);
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

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (RememberMeCheckBox.Checked && m_LoginResult!=null &&
                string.IsNullOrEmpty(m_LoginResult.ErrorMessage))
            {
                m_AppSettings.LastAccessToken = m_LoginResult.AccessToken;
                m_AppSettings.RememberUser = true;
                m_AppSettings.LastWindowSize = this.Size;
                m_AppSettings.LastWindowLocation = this.Location;
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

        private void FavoritePagesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FacebookWrapper.ObjectModel.Page chosenPage;
            string imageUrl;

            chosenPage = m_LoginResult.LoggedInUser.LikedPages[(sender as ListBox).SelectedIndex];
            imageUrl = ActiveUserManager.FetchPagePhoto(chosenPage);
            FavPagePictureBox.Load(imageUrl);
        }

        private void PreviousPostButton_Click(object sender, EventArgs e)
        {
            populateStatus(m_CurrentShowedStatusIndex + 1);
        }

        private void NextPostButton_Click(object sender, EventArgs e)
        {
            populateStatus(m_CurrentShowedStatusIndex - 1);
        }

        private void PreviousImagePostButton_Click(object sender, EventArgs e)
        {
            populateImagePost(m_CurrentShowedImagePostIndex + 1);
        }

        private void NextImagePostButton_Click(object sender, EventArgs e)
        {
            populateImagePost(m_CurrentShowedImagePostIndex - 1);
        }

        private void ImagePostPictureBox_Click(object sender, EventArgs e)
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
    }
}