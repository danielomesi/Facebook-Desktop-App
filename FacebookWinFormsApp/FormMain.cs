using FacebookWrapper;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        FacebookWrapper.LoginResult m_LoginResult;
        AppSettings m_AppSettings;

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

            

            if (m_LoginResult!=null && string.IsNullOrEmpty(m_LoginResult.ErrorMessage)
                && !string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                
            }
        }

        private void setLoggedInUser()
        {
            buttonLogin.Text = $"Logged in as {m_LoginResult.LoggedInUser.Name}";
            buttonLogin.BackColor = Color.LightGreen;
            pictureBoxProfile.ImageLocation = m_LoginResult.LoggedInUser.PictureNormalURL;
            buttonLogin.Enabled = false;
            RememberMeCheckBox.Enabled = false;
            buttonLogout.Enabled = true;
            populateLikedPages();
            

           //pictureBox1.Load("https://www.cs.mta.ac.il/staff/Boaz_Cohen/me.png");
            //we start from here
            //FavoritePagesListBox.Items.Add(m_LoginResult.LoggedInUser.LikedPages[0].Name);
            //FavoritePagesListBox.Items.Add(m_LoginResult.LoggedInUser.LikedPages[1].Name);
        }

        private void populateLikedPages()
        {
            List<string> namesList;

            namesList = FormManager.FetchLikedPagesNames(m_LoginResult.LoggedInUser);
            FavoritePagesListBox.Items.AddRange(namesList.ToArray());
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
            imageUrl = FormManager.FetchPagePhoto(chosenPage);
            pictureBox1.Load(imageUrl);
        }
    }
}
