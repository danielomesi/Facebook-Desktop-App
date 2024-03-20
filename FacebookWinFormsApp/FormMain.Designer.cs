namespace BasicFacebookFeatures
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label happyBirthdayLabel;
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabLogin = new System.Windows.Forms.TabPage();
            this.checkBoxRememberMe = new System.Windows.Forms.CheckBox();
            this.textBoxAppID = new System.Windows.Forms.TextBox();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.userNameBirthdayLabel = new System.Windows.Forms.Label();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelActualTypeOfFilteredPost = new System.Windows.Forms.Label();
            this.labelTypeOfFilteredPost = new System.Windows.Forms.Label();
            this.buttonNextFilteredStatuses = new System.Windows.Forms.Button();
            this.buttonPreviousFilteredStatuses = new System.Windows.Forms.Button();
            this.richTextBoxFilteredStatus = new System.Windows.Forms.RichTextBox();
            this.buttonFilterStatuses = new System.Windows.Forms.Button();
            this.textBoxFilteredStatusInput = new System.Windows.Forms.TextBox();
            this.myFriendsLabel = new System.Windows.Forms.Label();
            this.friendsListBox = new System.Windows.Forms.ListBox();
            this.friendBirthdayLabel = new System.Windows.Forms.Label();
            this.friendImageNormalPictureBox = new System.Windows.Forms.PictureBox();
            this.labelFavoritePages = new System.Windows.Forms.Label();
            this.uRLLinkLabel = new System.Windows.Forms.LinkLabel();
            this.pageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBoxFavPagesList = new System.Windows.Forms.ListBox();
            this.favPageImageNormalPictureBox = new System.Windows.Forms.PictureBox();
            this.labelMyImagePosts = new System.Windows.Forms.Label();
            this.buttonNextImagePost = new System.Windows.Forms.Button();
            this.buttonPreviousImagePost = new System.Windows.Forms.Button();
            this.pictureBoxImagePost = new System.Windows.Forms.PictureBox();
            this.labelMyStatuses = new System.Windows.Forms.Label();
            this.buttonNextStatus = new System.Windows.Forms.Button();
            this.buttonPreviousStatus = new System.Windows.Forms.Button();
            this.richTextBoxStatus = new System.Windows.Forms.RichTextBox();
            this.AlbumsTab = new System.Windows.Forms.TabPage();
            this.albumCreatedAtLabel = new System.Windows.Forms.Label();
            this.AlbumImagesLabel = new System.Windows.Forms.Label();
            this.AlbumImageNextButton = new System.Windows.Forms.Button();
            this.AlbumImagePerviousButton = new System.Windows.Forms.Button();
            this.AlbumPictureBox = new System.Windows.Forms.PictureBox();
            this.AlbumsLabel = new System.Windows.Forms.Label();
            this.AlbumsListBox = new System.Windows.Forms.ListBox();
            this.tabAIRephraser = new System.Windows.Forms.TabPage();
            this.creditLabel = new System.Windows.Forms.Label();
            this.labelRephraserNote = new System.Windows.Forms.Label();
            this.ButtonPost = new System.Windows.Forms.Button();
            this.buttonNextSuggestedText = new System.Windows.Forms.Button();
            this.buttonPreviousSuggestedText = new System.Windows.Forms.Button();
            this.richTextBoxWritePhrase = new System.Windows.Forms.RichTextBox();
            this.buttonStartRephrase = new System.Windows.Forms.Button();
            this.textBoxSuggestedByAI = new System.Windows.Forms.RichTextBox();
            this.tabTimeUsage = new System.Windows.Forms.TabPage();
            this.labelLastLogin = new System.Windows.Forms.Label();
            this.labelOverallElapsedTime = new System.Windows.Forms.Label();
            this.labelElapsedTime = new System.Windows.Forms.Label();
            this.tabAbout = new System.Windows.Forms.TabPage();
            this.labelBasicUserInfo = new System.Windows.Forms.Label();
            this.labelDataEmail = new System.Windows.Forms.Label();
            this.labelDataGender = new System.Windows.Forms.Label();
            this.labelDataBirthday = new System.Windows.Forms.Label();
            this.labelDataFullName = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelbirthday = new System.Windows.Forms.Label();
            this.labelFullName = new System.Windows.Forms.Label();
            happyBirthdayLabel = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabLogin.SuspendLayout();
            this.tabHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendImageNormalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.favPageImageNormalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagePost)).BeginInit();
            this.AlbumsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumPictureBox)).BeginInit();
            this.tabAIRephraser.SuspendLayout();
            this.tabTimeUsage.SuspendLayout();
            this.tabAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // happyBirthdayLabel
            // 
            happyBirthdayLabel.AutoSize = true;
            happyBirthdayLabel.Location = new System.Drawing.Point(338, 437);
            happyBirthdayLabel.Name = "happyBirthdayLabel";
            happyBirthdayLabel.Size = new System.Drawing.Size(65, 18);
            happyBirthdayLabel.TabIndex = 91;
            happyBirthdayLabel.Text = "Birthday:";
            happyBirthdayLabel.Visible = false;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabLogin);
            this.tabControl.Controls.Add(this.tabHome);
            this.tabControl.Controls.Add(this.AlbumsTab);
            this.tabControl.Controls.Add(this.tabAIRephraser);
            this.tabControl.Controls.Add(this.tabTimeUsage);
            this.tabControl.Controls.Add(this.tabAbout);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1152, 694);
            this.tabControl.TabIndex = 54;
            // 
            // tabLogin
            // 
            this.tabLogin.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabLogin.Controls.Add(this.checkBoxRememberMe);
            this.tabLogin.Controls.Add(this.textBoxAppID);
            this.tabLogin.Controls.Add(this.buttonLogout);
            this.tabLogin.Controls.Add(this.buttonLogin);
            this.tabLogin.Location = new System.Drawing.Point(4, 27);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogin.Size = new System.Drawing.Size(1144, 663);
            this.tabLogin.TabIndex = 4;
            this.tabLogin.Text = "Login";
            // 
            // checkBoxRememberMe
            // 
            this.checkBoxRememberMe.AutoSize = true;
            this.checkBoxRememberMe.Enabled = false;
            this.checkBoxRememberMe.Location = new System.Drawing.Point(37, 121);
            this.checkBoxRememberMe.Name = "checkBoxRememberMe";
            this.checkBoxRememberMe.Size = new System.Drawing.Size(126, 22);
            this.checkBoxRememberMe.TabIndex = 63;
            this.checkBoxRememberMe.Text = "Remember Me";
            this.checkBoxRememberMe.UseVisualStyleBackColor = true;
            // 
            // textBoxAppID
            // 
            this.textBoxAppID.BackColor = System.Drawing.Color.Lavender;
            this.textBoxAppID.Location = new System.Drawing.Point(319, 70);
            this.textBoxAppID.Name = "textBoxAppID";
            this.textBoxAppID.Size = new System.Drawing.Size(237, 24);
            this.textBoxAppID.TabIndex = 62;
            this.textBoxAppID.Text = "936827228016864";
            // 
            // buttonLogout
            // 
            this.buttonLogout.Enabled = false;
            this.buttonLogout.Location = new System.Drawing.Point(20, 66);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(268, 32);
            this.buttonLogout.TabIndex = 61;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogoutClick);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Enabled = false;
            this.buttonLogin.Location = new System.Drawing.Point(20, 26);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(268, 32);
            this.buttonLogin.TabIndex = 60;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLoginClick);
            // 
            // tabHome
            // 
            this.tabHome.AutoScroll = true;
            this.tabHome.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabHome.Controls.Add(this.userNameBirthdayLabel);
            this.tabHome.Controls.Add(happyBirthdayLabel);
            this.tabHome.Controls.Add(this.labelActualTypeOfFilteredPost);
            this.tabHome.Controls.Add(this.labelTypeOfFilteredPost);
            this.tabHome.Controls.Add(this.buttonNextFilteredStatuses);
            this.tabHome.Controls.Add(this.buttonPreviousFilteredStatuses);
            this.tabHome.Controls.Add(this.richTextBoxFilteredStatus);
            this.tabHome.Controls.Add(this.buttonFilterStatuses);
            this.tabHome.Controls.Add(this.textBoxFilteredStatusInput);
            this.tabHome.Controls.Add(this.myFriendsLabel);
            this.tabHome.Controls.Add(this.friendsListBox);
            this.tabHome.Controls.Add(this.friendBirthdayLabel);
            this.tabHome.Controls.Add(this.friendImageNormalPictureBox);
            this.tabHome.Controls.Add(this.labelFavoritePages);
            this.tabHome.Controls.Add(this.uRLLinkLabel);
            this.tabHome.Controls.Add(this.listBoxFavPagesList);
            this.tabHome.Controls.Add(this.favPageImageNormalPictureBox);
            this.tabHome.Controls.Add(this.labelMyImagePosts);
            this.tabHome.Controls.Add(this.buttonNextImagePost);
            this.tabHome.Controls.Add(this.buttonPreviousImagePost);
            this.tabHome.Controls.Add(this.pictureBoxImagePost);
            this.tabHome.Controls.Add(this.labelMyStatuses);
            this.tabHome.Controls.Add(this.buttonNextStatus);
            this.tabHome.Controls.Add(this.buttonPreviousStatus);
            this.tabHome.Controls.Add(this.richTextBoxStatus);
            this.tabHome.Location = new System.Drawing.Point(4, 27);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(1144, 663);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Home";
            // 
            // userNameBirthdayLabel
            // 
            this.userNameBirthdayLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Name", true));
            this.userNameBirthdayLabel.Location = new System.Drawing.Point(338, 300);
            this.userNameBirthdayLabel.Name = "userNameBirthdayLabel";
            this.userNameBirthdayLabel.Size = new System.Drawing.Size(105, 18);
            this.userNameBirthdayLabel.TabIndex = 92;
            this.userNameBirthdayLabel.Visible = false;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // labelActualTypeOfFilteredPost
            // 
            this.labelActualTypeOfFilteredPost.AutoSize = true;
            this.labelActualTypeOfFilteredPost.Location = new System.Drawing.Point(663, 533);
            this.labelActualTypeOfFilteredPost.Name = "labelActualTypeOfFilteredPost";
            this.labelActualTypeOfFilteredPost.Size = new System.Drawing.Size(0, 18);
            this.labelActualTypeOfFilteredPost.TabIndex = 90;
            // 
            // labelTypeOfFilteredPost
            // 
            this.labelTypeOfFilteredPost.AutoSize = true;
            this.labelTypeOfFilteredPost.Location = new System.Drawing.Point(561, 533);
            this.labelTypeOfFilteredPost.Name = "labelTypeOfFilteredPost";
            this.labelTypeOfFilteredPost.Size = new System.Drawing.Size(83, 18);
            this.labelTypeOfFilteredPost.TabIndex = 89;
            this.labelTypeOfFilteredPost.Text = "Post Type: ";
            this.labelTypeOfFilteredPost.Visible = false;
            // 
            // buttonNextFilteredStatuses
            // 
            this.buttonNextFilteredStatuses.Enabled = false;
            this.buttonNextFilteredStatuses.Location = new System.Drawing.Point(712, 566);
            this.buttonNextFilteredStatuses.Name = "buttonNextFilteredStatuses";
            this.buttonNextFilteredStatuses.Size = new System.Drawing.Size(112, 50);
            this.buttonNextFilteredStatuses.TabIndex = 88;
            this.buttonNextFilteredStatuses.Text = "Next";
            this.buttonNextFilteredStatuses.UseVisualStyleBackColor = true;
            this.buttonNextFilteredStatuses.Visible = false;
            this.buttonNextFilteredStatuses.Click += new System.EventHandler(this.buttonNextFilteredStatuses_Click);
            // 
            // buttonPreviousFilteredStatuses
            // 
            this.buttonPreviousFilteredStatuses.Enabled = false;
            this.buttonPreviousFilteredStatuses.Location = new System.Drawing.Point(562, 566);
            this.buttonPreviousFilteredStatuses.Name = "buttonPreviousFilteredStatuses";
            this.buttonPreviousFilteredStatuses.Size = new System.Drawing.Size(123, 50);
            this.buttonPreviousFilteredStatuses.TabIndex = 87;
            this.buttonPreviousFilteredStatuses.Text = "Previous";
            this.buttonPreviousFilteredStatuses.UseVisualStyleBackColor = true;
            this.buttonPreviousFilteredStatuses.Visible = false;
            this.buttonPreviousFilteredStatuses.Click += new System.EventHandler(this.buttonPreviousFilteredStatuses_Click);
            // 
            // richTextBoxFilteredStatus
            // 
            this.richTextBoxFilteredStatus.BackColor = System.Drawing.Color.Lavender;
            this.richTextBoxFilteredStatus.Location = new System.Drawing.Point(562, 434);
            this.richTextBoxFilteredStatus.Name = "richTextBoxFilteredStatus";
            this.richTextBoxFilteredStatus.Size = new System.Drawing.Size(271, 96);
            this.richTextBoxFilteredStatus.TabIndex = 86;
            this.richTextBoxFilteredStatus.Text = "";
            this.richTextBoxFilteredStatus.Visible = false;
            // 
            // buttonFilterStatuses
            // 
            this.buttonFilterStatuses.Location = new System.Drawing.Point(741, 383);
            this.buttonFilterStatuses.Name = "buttonFilterStatuses";
            this.buttonFilterStatuses.Size = new System.Drawing.Size(92, 38);
            this.buttonFilterStatuses.TabIndex = 85;
            this.buttonFilterStatuses.Text = "Filter";
            this.buttonFilterStatuses.UseVisualStyleBackColor = true;
            this.buttonFilterStatuses.Visible = false;
            this.buttonFilterStatuses.Click += new System.EventHandler(this.buttonFilterStatuses_Click);
            // 
            // textBoxFilteredStatusInput
            // 
            this.textBoxFilteredStatusInput.BackColor = System.Drawing.Color.Lavender;
            this.textBoxFilteredStatusInput.Location = new System.Drawing.Point(562, 390);
            this.textBoxFilteredStatusInput.Name = "textBoxFilteredStatusInput";
            this.textBoxFilteredStatusInput.Size = new System.Drawing.Size(162, 24);
            this.textBoxFilteredStatusInput.TabIndex = 84;
            this.textBoxFilteredStatusInput.Visible = false;
            // 
            // myFriendsLabel
            // 
            this.myFriendsLabel.AutoSize = true;
            this.myFriendsLabel.Location = new System.Drawing.Point(375, 43);
            this.myFriendsLabel.Name = "myFriendsLabel";
            this.myFriendsLabel.Size = new System.Drawing.Size(81, 18);
            this.myFriendsLabel.TabIndex = 81;
            this.myFriendsLabel.Text = "My Friends";
            this.myFriendsLabel.Visible = false;
            // 
            // friendsListBox
            // 
            this.friendsListBox.BackColor = System.Drawing.Color.Lavender;
            this.friendsListBox.DataSource = this.userBindingSource;
            this.friendsListBox.DisplayMember = "Name";
            this.friendsListBox.FormattingEnabled = true;
            this.friendsListBox.ItemHeight = 18;
            this.friendsListBox.Location = new System.Drawing.Point(299, 72);
            this.friendsListBox.Name = "friendsListBox";
            this.friendsListBox.Size = new System.Drawing.Size(252, 220);
            this.friendsListBox.TabIndex = 80;
            this.friendsListBox.Visible = false;
            // 
            // friendBirthdayLabel
            // 
            this.friendBirthdayLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Birthday", true));
            this.friendBirthdayLabel.Location = new System.Drawing.Point(338, 465);
            this.friendBirthdayLabel.Name = "friendBirthdayLabel";
            this.friendBirthdayLabel.Size = new System.Drawing.Size(105, 18);
            this.friendBirthdayLabel.TabIndex = 77;
            this.friendBirthdayLabel.Visible = false;
            // 
            // friendImageNormalPictureBox
            // 
            this.friendImageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.userBindingSource, "ImageNormal", true));
            this.friendImageNormalPictureBox.Location = new System.Drawing.Point(341, 326);
            this.friendImageNormalPictureBox.Name = "friendImageNormalPictureBox";
            this.friendImageNormalPictureBox.Size = new System.Drawing.Size(115, 105);
            this.friendImageNormalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.friendImageNormalPictureBox.TabIndex = 79;
            this.friendImageNormalPictureBox.TabStop = false;
            this.friendImageNormalPictureBox.Visible = false;
            // 
            // labelFavoritePages
            // 
            this.labelFavoritePages.AutoSize = true;
            this.labelFavoritePages.Location = new System.Drawing.Point(71, 43);
            this.labelFavoritePages.Name = "labelFavoritePages";
            this.labelFavoritePages.Size = new System.Drawing.Size(131, 18);
            this.labelFavoritePages.TabIndex = 76;
            this.labelFavoritePages.Text = "My Favorite Pages";
            this.labelFavoritePages.Visible = false;
            // 
            // uRLLinkLabel
            // 
            this.uRLLinkLabel.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.pageBindingSource, "URL", true));
            this.uRLLinkLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "Name", true));
            this.uRLLinkLabel.Location = new System.Drawing.Point(69, 300);
            this.uRLLinkLabel.Name = "uRLLinkLabel";
            this.uRLLinkLabel.Size = new System.Drawing.Size(133, 18);
            this.uRLLinkLabel.TabIndex = 75;
            this.uRLLinkLabel.Visible = false;
            this.uRLLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.uRLLinkLabel_LinkClicked);
            // 
            // pageBindingSource
            // 
            this.pageBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Page);
            // 
            // listBoxFavPagesList
            // 
            this.listBoxFavPagesList.BackColor = System.Drawing.Color.Lavender;
            this.listBoxFavPagesList.DataSource = this.pageBindingSource;
            this.listBoxFavPagesList.DisplayMember = "Name";
            this.listBoxFavPagesList.FormattingEnabled = true;
            this.listBoxFavPagesList.ItemHeight = 18;
            this.listBoxFavPagesList.Location = new System.Drawing.Point(21, 72);
            this.listBoxFavPagesList.Name = "listBoxFavPagesList";
            this.listBoxFavPagesList.Size = new System.Drawing.Size(252, 220);
            this.listBoxFavPagesList.TabIndex = 74;
            this.listBoxFavPagesList.Visible = false;
            // 
            // favPageImageNormalPictureBox
            // 
            this.favPageImageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.pageBindingSource, "ImageNormal", true));
            this.favPageImageNormalPictureBox.Location = new System.Drawing.Point(74, 326);
            this.favPageImageNormalPictureBox.Name = "favPageImageNormalPictureBox";
            this.favPageImageNormalPictureBox.Size = new System.Drawing.Size(115, 105);
            this.favPageImageNormalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.favPageImageNormalPictureBox.TabIndex = 71;
            this.favPageImageNormalPictureBox.TabStop = false;
            this.favPageImageNormalPictureBox.Visible = false;
            // 
            // labelMyImagePosts
            // 
            this.labelMyImagePosts.AutoSize = true;
            this.labelMyImagePosts.Location = new System.Drawing.Point(915, 43);
            this.labelMyImagePosts.Name = "labelMyImagePosts";
            this.labelMyImagePosts.Size = new System.Drawing.Size(115, 18);
            this.labelMyImagePosts.TabIndex = 68;
            this.labelMyImagePosts.Text = "My Image Posts";
            this.labelMyImagePosts.Visible = false;
            // 
            // buttonNextImagePost
            // 
            this.buttonNextImagePost.Enabled = false;
            this.buttonNextImagePost.Location = new System.Drawing.Point(990, 298);
            this.buttonNextImagePost.Name = "buttonNextImagePost";
            this.buttonNextImagePost.Size = new System.Drawing.Size(109, 49);
            this.buttonNextImagePost.TabIndex = 67;
            this.buttonNextImagePost.Text = "Next";
            this.buttonNextImagePost.UseVisualStyleBackColor = true;
            this.buttonNextImagePost.Visible = false;
            this.buttonNextImagePost.Click += new System.EventHandler(this.nextImagePostButton_Click);
            // 
            // buttonPreviousImagePost
            // 
            this.buttonPreviousImagePost.Enabled = false;
            this.buttonPreviousImagePost.Location = new System.Drawing.Point(850, 298);
            this.buttonPreviousImagePost.Name = "buttonPreviousImagePost";
            this.buttonPreviousImagePost.Size = new System.Drawing.Size(109, 49);
            this.buttonPreviousImagePost.TabIndex = 66;
            this.buttonPreviousImagePost.Text = "Previous";
            this.buttonPreviousImagePost.UseVisualStyleBackColor = true;
            this.buttonPreviousImagePost.Visible = false;
            this.buttonPreviousImagePost.Click += new System.EventHandler(this.previousImagePostButton_Click);
            // 
            // pictureBoxImagePost
            // 
            this.pictureBoxImagePost.Location = new System.Drawing.Point(850, 72);
            this.pictureBoxImagePost.Name = "pictureBoxImagePost";
            this.pictureBoxImagePost.Size = new System.Drawing.Size(252, 220);
            this.pictureBoxImagePost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImagePost.TabIndex = 65;
            this.pictureBoxImagePost.TabStop = false;
            this.pictureBoxImagePost.Visible = false;
            this.pictureBoxImagePost.Click += new System.EventHandler(this.imagePostPictureBox_Click);
            // 
            // labelMyStatuses
            // 
            this.labelMyStatuses.AutoSize = true;
            this.labelMyStatuses.Location = new System.Drawing.Point(654, 43);
            this.labelMyStatuses.Name = "labelMyStatuses";
            this.labelMyStatuses.Size = new System.Drawing.Size(90, 18);
            this.labelMyStatuses.TabIndex = 64;
            this.labelMyStatuses.Text = "My Statuses";
            this.labelMyStatuses.Visible = false;
            // 
            // buttonNextStatus
            // 
            this.buttonNextStatus.Enabled = false;
            this.buttonNextStatus.Location = new System.Drawing.Point(706, 298);
            this.buttonNextStatus.Name = "buttonNextStatus";
            this.buttonNextStatus.Size = new System.Drawing.Size(109, 48);
            this.buttonNextStatus.TabIndex = 63;
            this.buttonNextStatus.Text = "Next";
            this.buttonNextStatus.UseVisualStyleBackColor = true;
            this.buttonNextStatus.Visible = false;
            this.buttonNextStatus.Click += new System.EventHandler(this.nextPostButton_Click);
            // 
            // buttonPreviousStatus
            // 
            this.buttonPreviousStatus.Enabled = false;
            this.buttonPreviousStatus.Location = new System.Drawing.Point(578, 298);
            this.buttonPreviousStatus.Name = "buttonPreviousStatus";
            this.buttonPreviousStatus.Size = new System.Drawing.Size(106, 48);
            this.buttonPreviousStatus.TabIndex = 62;
            this.buttonPreviousStatus.Text = "Previous";
            this.buttonPreviousStatus.UseVisualStyleBackColor = true;
            this.buttonPreviousStatus.Visible = false;
            this.buttonPreviousStatus.Click += new System.EventHandler(this.previousPostButton_Click);
            // 
            // richTextBoxStatus
            // 
            this.richTextBoxStatus.BackColor = System.Drawing.Color.Lavender;
            this.richTextBoxStatus.Location = new System.Drawing.Point(572, 72);
            this.richTextBoxStatus.Name = "richTextBoxStatus";
            this.richTextBoxStatus.ReadOnly = true;
            this.richTextBoxStatus.Size = new System.Drawing.Size(252, 220);
            this.richTextBoxStatus.TabIndex = 61;
            this.richTextBoxStatus.Text = "";
            this.richTextBoxStatus.Visible = false;
            // 
            // AlbumsTab
            // 
            this.AlbumsTab.AutoScroll = true;
            this.AlbumsTab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AlbumsTab.Controls.Add(this.albumCreatedAtLabel);
            this.AlbumsTab.Controls.Add(this.AlbumImagesLabel);
            this.AlbumsTab.Controls.Add(this.AlbumImageNextButton);
            this.AlbumsTab.Controls.Add(this.AlbumImagePerviousButton);
            this.AlbumsTab.Controls.Add(this.AlbumPictureBox);
            this.AlbumsTab.Controls.Add(this.AlbumsLabel);
            this.AlbumsTab.Controls.Add(this.AlbumsListBox);
            this.AlbumsTab.Location = new System.Drawing.Point(4, 27);
            this.AlbumsTab.Name = "AlbumsTab";
            this.AlbumsTab.Padding = new System.Windows.Forms.Padding(3);
            this.AlbumsTab.Size = new System.Drawing.Size(1144, 663);
            this.AlbumsTab.TabIndex = 1;
            this.AlbumsTab.Text = "Albums";
            // 
            // albumCreatedAtLabel
            // 
            this.albumCreatedAtLabel.AutoSize = true;
            this.albumCreatedAtLabel.Location = new System.Drawing.Point(384, 360);
            this.albumCreatedAtLabel.Name = "albumCreatedAtLabel";
            this.albumCreatedAtLabel.Size = new System.Drawing.Size(0, 18);
            this.albumCreatedAtLabel.TabIndex = 73;
            // 
            // AlbumImagesLabel
            // 
            this.AlbumImagesLabel.AutoSize = true;
            this.AlbumImagesLabel.Location = new System.Drawing.Point(533, 64);
            this.AlbumImagesLabel.Name = "AlbumImagesLabel";
            this.AlbumImagesLabel.Size = new System.Drawing.Size(0, 18);
            this.AlbumImagesLabel.TabIndex = 72;
            // 
            // AlbumImageNextButton
            // 
            this.AlbumImageNextButton.Enabled = false;
            this.AlbumImageNextButton.Location = new System.Drawing.Point(566, 410);
            this.AlbumImageNextButton.Name = "AlbumImageNextButton";
            this.AlbumImageNextButton.Size = new System.Drawing.Size(162, 53);
            this.AlbumImageNextButton.TabIndex = 71;
            this.AlbumImageNextButton.Text = "Next";
            this.AlbumImageNextButton.UseVisualStyleBackColor = true;
            this.AlbumImageNextButton.Visible = false;
            this.AlbumImageNextButton.Click += new System.EventHandler(this.albumImageNextButton_Click);
            // 
            // AlbumImagePerviousButton
            // 
            this.AlbumImagePerviousButton.Enabled = false;
            this.AlbumImagePerviousButton.Location = new System.Drawing.Point(362, 410);
            this.AlbumImagePerviousButton.Name = "AlbumImagePerviousButton";
            this.AlbumImagePerviousButton.Size = new System.Drawing.Size(162, 53);
            this.AlbumImagePerviousButton.TabIndex = 70;
            this.AlbumImagePerviousButton.Text = "Previous";
            this.AlbumImagePerviousButton.UseVisualStyleBackColor = true;
            this.AlbumImagePerviousButton.Visible = false;
            this.AlbumImagePerviousButton.Click += new System.EventHandler(this.albumImagePerviousButton_Click);
            // 
            // AlbumPictureBox
            // 
            this.AlbumPictureBox.Location = new System.Drawing.Point(362, 93);
            this.AlbumPictureBox.Name = "AlbumPictureBox";
            this.AlbumPictureBox.Size = new System.Drawing.Size(366, 264);
            this.AlbumPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AlbumPictureBox.TabIndex = 69;
            this.AlbumPictureBox.TabStop = false;
            this.AlbumPictureBox.Visible = false;
            // 
            // AlbumsLabel
            // 
            this.AlbumsLabel.AutoSize = true;
            this.AlbumsLabel.Location = new System.Drawing.Point(82, 64);
            this.AlbumsLabel.Name = "AlbumsLabel";
            this.AlbumsLabel.Size = new System.Drawing.Size(101, 18);
            this.AlbumsLabel.TabIndex = 60;
            this.AlbumsLabel.Text = "Album Names";
            this.AlbumsLabel.Visible = false;
            // 
            // AlbumsListBox
            // 
            this.AlbumsListBox.BackColor = System.Drawing.Color.Lavender;
            this.AlbumsListBox.FormattingEnabled = true;
            this.AlbumsListBox.ItemHeight = 18;
            this.AlbumsListBox.Location = new System.Drawing.Point(44, 93);
            this.AlbumsListBox.Name = "AlbumsListBox";
            this.AlbumsListBox.Size = new System.Drawing.Size(251, 166);
            this.AlbumsListBox.TabIndex = 59;
            this.AlbumsListBox.Visible = false;
            this.AlbumsListBox.SelectedIndexChanged += new System.EventHandler(this.albumsListBox_SelectedIndexChanged);
            // 
            // tabAIRephraser
            // 
            this.tabAIRephraser.AutoScroll = true;
            this.tabAIRephraser.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabAIRephraser.Controls.Add(this.creditLabel);
            this.tabAIRephraser.Controls.Add(this.labelRephraserNote);
            this.tabAIRephraser.Controls.Add(this.ButtonPost);
            this.tabAIRephraser.Controls.Add(this.buttonNextSuggestedText);
            this.tabAIRephraser.Controls.Add(this.buttonPreviousSuggestedText);
            this.tabAIRephraser.Controls.Add(this.richTextBoxWritePhrase);
            this.tabAIRephraser.Controls.Add(this.buttonStartRephrase);
            this.tabAIRephraser.Controls.Add(this.textBoxSuggestedByAI);
            this.tabAIRephraser.Location = new System.Drawing.Point(4, 27);
            this.tabAIRephraser.Name = "tabAIRephraser";
            this.tabAIRephraser.Padding = new System.Windows.Forms.Padding(3);
            this.tabAIRephraser.Size = new System.Drawing.Size(1144, 663);
            this.tabAIRephraser.TabIndex = 3;
            this.tabAIRephraser.Text = "AI Rephraser";
            // 
            // creditLabel
            // 
            this.creditLabel.AutoSize = true;
            this.creditLabel.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditLabel.Location = new System.Drawing.Point(100, 595);
            this.creditLabel.Name = "creditLabel";
            this.creditLabel.Size = new System.Drawing.Size(177, 27);
            this.creditLabel.TabIndex = 75;
            this.creditLabel.Text = "© Paraphrase API service";
            this.creditLabel.Visible = false;
            // 
            // labelRephraserNote
            // 
            this.labelRephraserNote.AutoSize = true;
            this.labelRephraserNote.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRephraserNote.Location = new System.Drawing.Point(47, 42);
            this.labelRephraserNote.Name = "labelRephraserNote";
            this.labelRephraserNote.Size = new System.Drawing.Size(588, 27);
            this.labelRephraserNote.TabIndex = 74;
            this.labelRephraserNote.Text = "Let AI suggest you better rephrasing of your text! Note: New lines are not allowe" +
    "d";
            this.labelRephraserNote.Visible = false;
            // 
            // ButtonPost
            // 
            this.ButtonPost.Enabled = false;
            this.ButtonPost.Location = new System.Drawing.Point(570, 527);
            this.ButtonPost.Name = "ButtonPost";
            this.ButtonPost.Size = new System.Drawing.Size(191, 76);
            this.ButtonPost.TabIndex = 73;
            this.ButtonPost.Text = "Post!";
            this.ButtonPost.UseVisualStyleBackColor = true;
            this.ButtonPost.Visible = false;
            this.ButtonPost.Click += new System.EventHandler(this.postActionButton_Click);
            // 
            // buttonNextSuggestedText
            // 
            this.buttonNextSuggestedText.Enabled = false;
            this.buttonNextSuggestedText.Location = new System.Drawing.Point(674, 461);
            this.buttonNextSuggestedText.Name = "buttonNextSuggestedText";
            this.buttonNextSuggestedText.Size = new System.Drawing.Size(145, 60);
            this.buttonNextSuggestedText.TabIndex = 72;
            this.buttonNextSuggestedText.Text = "-->";
            this.buttonNextSuggestedText.UseVisualStyleBackColor = true;
            this.buttonNextSuggestedText.Visible = false;
            this.buttonNextSuggestedText.Click += new System.EventHandler(this.nextSuggestedTextButton_Click);
            // 
            // buttonPreviousSuggestedText
            // 
            this.buttonPreviousSuggestedText.Enabled = false;
            this.buttonPreviousSuggestedText.Location = new System.Drawing.Point(523, 461);
            this.buttonPreviousSuggestedText.Name = "buttonPreviousSuggestedText";
            this.buttonPreviousSuggestedText.Size = new System.Drawing.Size(145, 60);
            this.buttonPreviousSuggestedText.TabIndex = 71;
            this.buttonPreviousSuggestedText.Text = "<--";
            this.buttonPreviousSuggestedText.UseVisualStyleBackColor = true;
            this.buttonPreviousSuggestedText.Visible = false;
            this.buttonPreviousSuggestedText.Click += new System.EventHandler(this.previousSuggestedTextButton_Click);
            // 
            // richTextBoxWritePhrase
            // 
            this.richTextBoxWritePhrase.BackColor = System.Drawing.Color.Lavender;
            this.richTextBoxWritePhrase.Location = new System.Drawing.Point(37, 128);
            this.richTextBoxWritePhrase.Name = "richTextBoxWritePhrase";
            this.richTextBoxWritePhrase.Size = new System.Drawing.Size(403, 327);
            this.richTextBoxWritePhrase.TabIndex = 64;
            this.richTextBoxWritePhrase.Text = "";
            this.richTextBoxWritePhrase.Visible = false;
            // 
            // buttonStartRephrase
            // 
            this.buttonStartRephrase.Location = new System.Drawing.Point(156, 461);
            this.buttonStartRephrase.Name = "buttonStartRephrase";
            this.buttonStartRephrase.Size = new System.Drawing.Size(153, 77);
            this.buttonStartRephrase.TabIndex = 63;
            this.buttonStartRephrase.Text = "Start";
            this.buttonStartRephrase.UseVisualStyleBackColor = true;
            this.buttonStartRephrase.Visible = false;
            this.buttonStartRephrase.Click += new System.EventHandler(this.startAiButton_Click);
            // 
            // textBoxSuggestedByAI
            // 
            this.textBoxSuggestedByAI.BackColor = System.Drawing.Color.Lavender;
            this.textBoxSuggestedByAI.Location = new System.Drawing.Point(457, 128);
            this.textBoxSuggestedByAI.Name = "textBoxSuggestedByAI";
            this.textBoxSuggestedByAI.ReadOnly = true;
            this.textBoxSuggestedByAI.Size = new System.Drawing.Size(403, 327);
            this.textBoxSuggestedByAI.TabIndex = 62;
            this.textBoxSuggestedByAI.Text = "";
            this.textBoxSuggestedByAI.Visible = false;
            // 
            // tabTimeUsage
            // 
            this.tabTimeUsage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabTimeUsage.Controls.Add(this.labelLastLogin);
            this.tabTimeUsage.Controls.Add(this.labelOverallElapsedTime);
            this.tabTimeUsage.Controls.Add(this.labelElapsedTime);
            this.tabTimeUsage.Location = new System.Drawing.Point(4, 27);
            this.tabTimeUsage.Name = "tabTimeUsage";
            this.tabTimeUsage.Padding = new System.Windows.Forms.Padding(3);
            this.tabTimeUsage.Size = new System.Drawing.Size(1144, 663);
            this.tabTimeUsage.TabIndex = 5;
            this.tabTimeUsage.Text = "Time Usage";
            // 
            // labelLastLogin
            // 
            this.labelLastLogin.AutoSize = true;
            this.labelLastLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastLogin.Location = new System.Drawing.Point(149, 446);
            this.labelLastLogin.Name = "labelLastLogin";
            this.labelLastLogin.Size = new System.Drawing.Size(0, 55);
            this.labelLastLogin.TabIndex = 74;
            this.labelLastLogin.Visible = false;
            // 
            // labelOverallElapsedTime
            // 
            this.labelOverallElapsedTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelOverallElapsedTime.AutoSize = true;
            this.labelOverallElapsedTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOverallElapsedTime.Location = new System.Drawing.Point(149, 267);
            this.labelOverallElapsedTime.Name = "labelOverallElapsedTime";
            this.labelOverallElapsedTime.Size = new System.Drawing.Size(0, 55);
            this.labelOverallElapsedTime.TabIndex = 73;
            this.labelOverallElapsedTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelOverallElapsedTime.Visible = false;
            // 
            // labelElapsedTime
            // 
            this.labelElapsedTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelElapsedTime.AutoSize = true;
            this.labelElapsedTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelElapsedTime.Location = new System.Drawing.Point(149, 87);
            this.labelElapsedTime.Name = "labelElapsedTime";
            this.labelElapsedTime.Size = new System.Drawing.Size(0, 55);
            this.labelElapsedTime.TabIndex = 72;
            this.labelElapsedTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelElapsedTime.Visible = false;
            // 
            // tabAbout
            // 
            this.tabAbout.AutoScroll = true;
            this.tabAbout.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabAbout.Controls.Add(this.labelBasicUserInfo);
            this.tabAbout.Controls.Add(this.labelDataEmail);
            this.tabAbout.Controls.Add(this.labelDataGender);
            this.tabAbout.Controls.Add(this.labelDataBirthday);
            this.tabAbout.Controls.Add(this.labelDataFullName);
            this.tabAbout.Controls.Add(this.labelEmail);
            this.tabAbout.Controls.Add(this.labelGender);
            this.tabAbout.Controls.Add(this.labelbirthday);
            this.tabAbout.Controls.Add(this.labelFullName);
            this.tabAbout.Location = new System.Drawing.Point(4, 27);
            this.tabAbout.Name = "tabAbout";
            this.tabAbout.Padding = new System.Windows.Forms.Padding(3);
            this.tabAbout.Size = new System.Drawing.Size(1144, 663);
            this.tabAbout.TabIndex = 2;
            this.tabAbout.Text = "About";
            // 
            // labelBasicUserInfo
            // 
            this.labelBasicUserInfo.AutoSize = true;
            this.labelBasicUserInfo.Font = new System.Drawing.Font("Myanmar Text", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBasicUserInfo.Location = new System.Drawing.Point(62, 58);
            this.labelBasicUserInfo.Name = "labelBasicUserInfo";
            this.labelBasicUserInfo.Size = new System.Drawing.Size(121, 27);
            this.labelBasicUserInfo.TabIndex = 8;
            this.labelBasicUserInfo.Text = "Basic User Info:";
            this.labelBasicUserInfo.Visible = false;
            // 
            // labelDataEmail
            // 
            this.labelDataEmail.AutoSize = true;
            this.labelDataEmail.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataEmail.Location = new System.Drawing.Point(223, 295);
            this.labelDataEmail.Name = "labelDataEmail";
            this.labelDataEmail.Size = new System.Drawing.Size(50, 27);
            this.labelDataEmail.TabIndex = 7;
            this.labelDataEmail.Text = "Email";
            this.labelDataEmail.Visible = false;
            // 
            // labelDataGender
            // 
            this.labelDataGender.AutoSize = true;
            this.labelDataGender.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataGender.Location = new System.Drawing.Point(223, 236);
            this.labelDataGender.Name = "labelDataGender";
            this.labelDataGender.Size = new System.Drawing.Size(63, 27);
            this.labelDataGender.TabIndex = 6;
            this.labelDataGender.Text = "Gender";
            this.labelDataGender.Visible = false;
            // 
            // labelDataBirthday
            // 
            this.labelDataBirthday.AutoSize = true;
            this.labelDataBirthday.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataBirthday.Location = new System.Drawing.Point(223, 180);
            this.labelDataBirthday.Name = "labelDataBirthday";
            this.labelDataBirthday.Size = new System.Drawing.Size(72, 27);
            this.labelDataBirthday.TabIndex = 5;
            this.labelDataBirthday.Text = "Birthday";
            this.labelDataBirthday.Visible = false;
            // 
            // labelDataFullName
            // 
            this.labelDataFullName.AutoSize = true;
            this.labelDataFullName.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataFullName.Location = new System.Drawing.Point(222, 125);
            this.labelDataFullName.Name = "labelDataFullName";
            this.labelDataFullName.Size = new System.Drawing.Size(83, 27);
            this.labelDataFullName.TabIndex = 4;
            this.labelDataFullName.Text = "Full Name";
            this.labelDataFullName.Visible = false;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(62, 295);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(56, 27);
            this.labelEmail.TabIndex = 3;
            this.labelEmail.Text = "Email: ";
            this.labelEmail.Visible = false;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.Location = new System.Drawing.Point(62, 236);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(67, 27);
            this.labelGender.TabIndex = 2;
            this.labelGender.Text = "Gender: ";
            this.labelGender.Visible = false;
            // 
            // labelbirthday
            // 
            this.labelbirthday.AutoSize = true;
            this.labelbirthday.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelbirthday.Location = new System.Drawing.Point(62, 180);
            this.labelbirthday.Name = "labelbirthday";
            this.labelbirthday.Size = new System.Drawing.Size(74, 27);
            this.labelbirthday.TabIndex = 1;
            this.labelbirthday.Text = "Birthday: ";
            this.labelbirthday.Visible = false;
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFullName.Location = new System.Drawing.Point(62, 125);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(86, 27);
            this.labelFullName.TabIndex = 0;
            this.labelFullName.Text = "Full Name: ";
            this.labelFullName.Visible = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1152, 694);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Best Facebook App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formMain_FormClosing);
            this.Shown += new System.EventHandler(this.formMain_Shown);
            this.tabControl.ResumeLayout(false);
            this.tabLogin.ResumeLayout(false);
            this.tabLogin.PerformLayout();
            this.tabHome.ResumeLayout(false);
            this.tabHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendImageNormalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.favPageImageNormalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagePost)).EndInit();
            this.AlbumsTab.ResumeLayout(false);
            this.AlbumsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumPictureBox)).EndInit();
            this.tabAIRephraser.ResumeLayout(false);
            this.tabAIRephraser.PerformLayout();
            this.tabTimeUsage.ResumeLayout(false);
            this.tabTimeUsage.PerformLayout();
            this.tabAbout.ResumeLayout(false);
            this.tabAbout.PerformLayout();
            this.ResumeLayout(false);

        }

		#endregion
        private System.Windows.Forms.TabPage AlbumsTab;
        private System.Windows.Forms.Label AlbumsLabel;
        private System.Windows.Forms.ListBox AlbumsListBox;
        private System.Windows.Forms.Label AlbumImagesLabel;
        private System.Windows.Forms.Button AlbumImageNextButton;
        private System.Windows.Forms.Button AlbumImagePerviousButton;
        private System.Windows.Forms.PictureBox AlbumPictureBox;
        private System.Windows.Forms.TabPage tabAbout;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelbirthday;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Label labelDataEmail;
        private System.Windows.Forms.Label labelDataGender;
        private System.Windows.Forms.Label labelDataBirthday;
        private System.Windows.Forms.Label labelDataFullName;
        private System.Windows.Forms.TabPage tabAIRephraser;
        private System.Windows.Forms.RichTextBox textBoxSuggestedByAI;
        private System.Windows.Forms.Button buttonStartRephrase;
        private System.Windows.Forms.RichTextBox richTextBoxWritePhrase;
        private System.Windows.Forms.Button buttonPreviousSuggestedText;
        private System.Windows.Forms.Button buttonNextSuggestedText;
        private System.Windows.Forms.Label labelRephraserNote;
        private System.Windows.Forms.Button ButtonPost;
        private System.Windows.Forms.Label labelBasicUserInfo;
        private System.Windows.Forms.Label albumCreatedAtLabel;
        private System.Windows.Forms.Label creditLabel;
        private System.Windows.Forms.TabPage tabTimeUsage;
        private System.Windows.Forms.Label labelElapsedTime;
        private System.Windows.Forms.Label labelOverallElapsedTime;
        private System.Windows.Forms.Label labelLastLogin;
        private System.Windows.Forms.BindingSource pageBindingSource;
        private System.Windows.Forms.TabPage tabLogin;
        private System.Windows.Forms.CheckBox checkBoxRememberMe;
        private System.Windows.Forms.TextBox textBoxAppID;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.Label myFriendsLabel;
        private System.Windows.Forms.ListBox friendsListBox;
        private System.Windows.Forms.Label friendBirthdayLabel;
        private System.Windows.Forms.PictureBox friendImageNormalPictureBox;
        private System.Windows.Forms.Label labelFavoritePages;
        private System.Windows.Forms.LinkLabel uRLLinkLabel;
        private System.Windows.Forms.ListBox listBoxFavPagesList;
        private System.Windows.Forms.PictureBox favPageImageNormalPictureBox;
        private System.Windows.Forms.Label labelMyImagePosts;
        private System.Windows.Forms.Button buttonNextImagePost;
        private System.Windows.Forms.Button buttonPreviousImagePost;
        private System.Windows.Forms.PictureBox pictureBoxImagePost;
        private System.Windows.Forms.Label labelMyStatuses;
        private System.Windows.Forms.Button buttonNextStatus;
        private System.Windows.Forms.Button buttonPreviousStatus;
        private System.Windows.Forms.RichTextBox richTextBoxStatus;
        private System.Windows.Forms.RichTextBox richTextBoxFilteredStatus;
        private System.Windows.Forms.Button buttonFilterStatuses;
        private System.Windows.Forms.TextBox textBoxFilteredStatusInput;
        private System.Windows.Forms.Button buttonNextFilteredStatuses;
        private System.Windows.Forms.Button buttonPreviousFilteredStatuses;
        private System.Windows.Forms.Label labelActualTypeOfFilteredPost;
        private System.Windows.Forms.Label labelTypeOfFilteredPost;
        private System.Windows.Forms.Label userNameBirthdayLabel;
    }
}

