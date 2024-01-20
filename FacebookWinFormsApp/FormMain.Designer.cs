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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.HomeTab = new System.Windows.Forms.TabPage();
            this.MyFriendsLabel = new System.Windows.Forms.Label();
            this.FriendsListBox = new System.Windows.Forms.ListBox();
            this.MyImagePostsLabel = new System.Windows.Forms.Label();
            this.NextImagePostButton = new System.Windows.Forms.Button();
            this.PreviousImagePostButton = new System.Windows.Forms.Button();
            this.ImagePostPictureBox = new System.Windows.Forms.PictureBox();
            this.MyStatusesLabel = new System.Windows.Forms.Label();
            this.NextStatusButton = new System.Windows.Forms.Button();
            this.PreviousStatusButton = new System.Windows.Forms.Button();
            this.PostRichTextBox = new System.Windows.Forms.RichTextBox();
            this.FavPagePictureBox = new System.Windows.Forms.PictureBox();
            this.RememberMeCheckBox = new System.Windows.Forms.CheckBox();
            this.FavoritePagesListBox = new System.Windows.Forms.ListBox();
            this.FavoritePagesLabel = new System.Windows.Forms.Label();
            this.textBoxAppID = new System.Windows.Forms.TextBox();
            this.AlbumsTab = new System.Windows.Forms.TabPage();
            this.AlbumImagesLabel = new System.Windows.Forms.Label();
            this.AlbumImageNextButton = new System.Windows.Forms.Button();
            this.AlbumImagePerviousButton = new System.Windows.Forms.Button();
            this.AlbumPictureBox = new System.Windows.Forms.PictureBox();
            this.AlbumsLabel = new System.Windows.Forms.Label();
            this.AlbumsListBox = new System.Windows.Forms.ListBox();
            this.AboutTab = new System.Windows.Forms.TabPage();
            this.emailLabelData = new System.Windows.Forms.Label();
            this.genderLabelData = new System.Windows.Forms.Label();
            this.birthdayLabelData = new System.Windows.Forms.Label();
            this.FullNameLabelData = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.birthdayLabel = new System.Windows.Forms.Label();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.AIRephraser = new System.Windows.Forms.TabPage();
            this.StartRephraseButton = new System.Windows.Forms.Button();
            this.SuggestedByAITextBox = new System.Windows.Forms.RichTextBox();
            this.WriteStatusRichTextBox = new System.Windows.Forms.RichTextBox();
            this.PreviousSuggestedTextButton = new System.Windows.Forms.Button();
            this.NextSuggestedTextButton = new System.Windows.Forms.Button();
            this.PostActionButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.HomeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePostPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FavPagePictureBox)).BeginInit();
            this.AlbumsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumPictureBox)).BeginInit();
            this.AboutTab.SuspendLayout();
            this.AIRephraser.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(18, 17);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(268, 32);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Enabled = false;
            this.buttonLogout.Location = new System.Drawing.Point(18, 57);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(268, 32);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.HomeTab);
            this.tabControl.Controls.Add(this.AlbumsTab);
            this.tabControl.Controls.Add(this.AboutTab);
            this.tabControl.Controls.Add(this.AIRephraser);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1539, 1050);
            this.tabControl.TabIndex = 54;
            // 
            // HomeTab
            // 
            this.HomeTab.Controls.Add(this.MyFriendsLabel);
            this.HomeTab.Controls.Add(this.FriendsListBox);
            this.HomeTab.Controls.Add(this.MyImagePostsLabel);
            this.HomeTab.Controls.Add(this.NextImagePostButton);
            this.HomeTab.Controls.Add(this.PreviousImagePostButton);
            this.HomeTab.Controls.Add(this.ImagePostPictureBox);
            this.HomeTab.Controls.Add(this.MyStatusesLabel);
            this.HomeTab.Controls.Add(this.NextStatusButton);
            this.HomeTab.Controls.Add(this.PreviousStatusButton);
            this.HomeTab.Controls.Add(this.PostRichTextBox);
            this.HomeTab.Controls.Add(this.FavPagePictureBox);
            this.HomeTab.Controls.Add(this.RememberMeCheckBox);
            this.HomeTab.Controls.Add(this.FavoritePagesListBox);
            this.HomeTab.Controls.Add(this.FavoritePagesLabel);
            this.HomeTab.Controls.Add(this.textBoxAppID);
            this.HomeTab.Controls.Add(this.buttonLogout);
            this.HomeTab.Controls.Add(this.buttonLogin);
            this.HomeTab.Location = new System.Drawing.Point(4, 39);
            this.HomeTab.Name = "HomeTab";
            this.HomeTab.Padding = new System.Windows.Forms.Padding(3);
            this.HomeTab.Size = new System.Drawing.Size(1531, 1007);
            this.HomeTab.TabIndex = 0;
            this.HomeTab.Text = "Home";
            this.HomeTab.UseVisualStyleBackColor = true;
            // 
            // MyFriendsLabel
            // 
            this.MyFriendsLabel.AutoSize = true;
            this.MyFriendsLabel.Location = new System.Drawing.Point(1246, 172);
            this.MyFriendsLabel.Name = "MyFriendsLabel";
            this.MyFriendsLabel.Size = new System.Drawing.Size(141, 30);
            this.MyFriendsLabel.TabIndex = 70;
            this.MyFriendsLabel.Text = "My Friends";
            this.MyFriendsLabel.Visible = false;
            // 
            // FriendsListBox
            // 
            this.FriendsListBox.FormattingEnabled = true;
            this.FriendsListBox.ItemHeight = 30;
            this.FriendsListBox.Location = new System.Drawing.Point(1159, 221);
            this.FriendsListBox.Name = "FriendsListBox";
            this.FriendsListBox.Size = new System.Drawing.Size(335, 244);
            this.FriendsListBox.TabIndex = 69;
            this.FriendsListBox.Visible = false;
            // 
            // MyImagePostsLabel
            // 
            this.MyImagePostsLabel.AutoSize = true;
            this.MyImagePostsLabel.Location = new System.Drawing.Point(827, 172);
            this.MyImagePostsLabel.Name = "MyImagePostsLabel";
            this.MyImagePostsLabel.Size = new System.Drawing.Size(196, 30);
            this.MyImagePostsLabel.TabIndex = 68;
            this.MyImagePostsLabel.Text = "My Image Posts";
            this.MyImagePostsLabel.Visible = false;
            // 
            // NextImagePostButton
            // 
            this.NextImagePostButton.Enabled = false;
            this.NextImagePostButton.Location = new System.Drawing.Point(955, 511);
            this.NextImagePostButton.Name = "NextImagePostButton";
            this.NextImagePostButton.Size = new System.Drawing.Size(145, 60);
            this.NextImagePostButton.TabIndex = 67;
            this.NextImagePostButton.Text = "Next";
            this.NextImagePostButton.UseVisualStyleBackColor = true;
            this.NextImagePostButton.Visible = false;
            this.NextImagePostButton.Click += new System.EventHandler(this.NextImagePostButton_Click);
            // 
            // PreviousImagePostButton
            // 
            this.PreviousImagePostButton.Enabled = false;
            this.PreviousImagePostButton.Location = new System.Drawing.Point(751, 511);
            this.PreviousImagePostButton.Name = "PreviousImagePostButton";
            this.PreviousImagePostButton.Size = new System.Drawing.Size(145, 60);
            this.PreviousImagePostButton.TabIndex = 66;
            this.PreviousImagePostButton.Text = "Previous";
            this.PreviousImagePostButton.UseVisualStyleBackColor = true;
            this.PreviousImagePostButton.Visible = false;
            this.PreviousImagePostButton.Click += new System.EventHandler(this.PreviousImagePostButton_Click);
            // 
            // ImagePostPictureBox
            // 
            this.ImagePostPictureBox.Location = new System.Drawing.Point(751, 221);
            this.ImagePostPictureBox.Name = "ImagePostPictureBox";
            this.ImagePostPictureBox.Size = new System.Drawing.Size(349, 271);
            this.ImagePostPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImagePostPictureBox.TabIndex = 65;
            this.ImagePostPictureBox.TabStop = false;
            this.ImagePostPictureBox.Visible = false;
            this.ImagePostPictureBox.Click += new System.EventHandler(this.ImagePostPictureBox_Click);
            // 
            // MyStatusesLabel
            // 
            this.MyStatusesLabel.AutoSize = true;
            this.MyStatusesLabel.Location = new System.Drawing.Point(438, 172);
            this.MyStatusesLabel.Name = "MyStatusesLabel";
            this.MyStatusesLabel.Size = new System.Drawing.Size(154, 30);
            this.MyStatusesLabel.TabIndex = 64;
            this.MyStatusesLabel.Text = "My Statuses";
            this.MyStatusesLabel.Visible = false;
            // 
            // NextStatusButton
            // 
            this.NextStatusButton.Enabled = false;
            this.NextStatusButton.Location = new System.Drawing.Point(545, 511);
            this.NextStatusButton.Name = "NextStatusButton";
            this.NextStatusButton.Size = new System.Drawing.Size(145, 60);
            this.NextStatusButton.TabIndex = 63;
            this.NextStatusButton.Text = "Next";
            this.NextStatusButton.UseVisualStyleBackColor = true;
            this.NextStatusButton.Visible = false;
            this.NextStatusButton.Click += new System.EventHandler(this.NextPostButton_Click);
            // 
            // PreviousStatusButton
            // 
            this.PreviousStatusButton.Enabled = false;
            this.PreviousStatusButton.Location = new System.Drawing.Point(367, 511);
            this.PreviousStatusButton.Name = "PreviousStatusButton";
            this.PreviousStatusButton.Size = new System.Drawing.Size(145, 60);
            this.PreviousStatusButton.TabIndex = 62;
            this.PreviousStatusButton.Text = "Previous";
            this.PreviousStatusButton.UseVisualStyleBackColor = true;
            this.PreviousStatusButton.Visible = false;
            this.PreviousStatusButton.Click += new System.EventHandler(this.PreviousPostButton_Click);
            // 
            // PostRichTextBox
            // 
            this.PostRichTextBox.Location = new System.Drawing.Point(367, 221);
            this.PostRichTextBox.Name = "PostRichTextBox";
            this.PostRichTextBox.ReadOnly = true;
            this.PostRichTextBox.Size = new System.Drawing.Size(323, 274);
            this.PostRichTextBox.TabIndex = 61;
            this.PostRichTextBox.Text = "";
            this.PostRichTextBox.Visible = false;
            // 
            // FavPagePictureBox
            // 
            this.FavPagePictureBox.Location = new System.Drawing.Point(70, 511);
            this.FavPagePictureBox.Name = "FavPagePictureBox";
            this.FavPagePictureBox.Size = new System.Drawing.Size(200, 200);
            this.FavPagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FavPagePictureBox.TabIndex = 60;
            this.FavPagePictureBox.TabStop = false;
            this.FavPagePictureBox.Visible = false;
            // 
            // RememberMeCheckBox
            // 
            this.RememberMeCheckBox.AutoSize = true;
            this.RememberMeCheckBox.Location = new System.Drawing.Point(35, 112);
            this.RememberMeCheckBox.Name = "RememberMeCheckBox";
            this.RememberMeCheckBox.Size = new System.Drawing.Size(210, 34);
            this.RememberMeCheckBox.TabIndex = 59;
            this.RememberMeCheckBox.Text = "Remember Me";
            this.RememberMeCheckBox.UseVisualStyleBackColor = true;
            // 
            // FavoritePagesListBox
            // 
            this.FavoritePagesListBox.FormattingEnabled = true;
            this.FavoritePagesListBox.ItemHeight = 30;
            this.FavoritePagesListBox.Location = new System.Drawing.Point(48, 221);
            this.FavoritePagesListBox.Name = "FavoritePagesListBox";
            this.FavoritePagesListBox.Size = new System.Drawing.Size(251, 214);
            this.FavoritePagesListBox.TabIndex = 58;
            this.FavoritePagesListBox.Visible = false;
            this.FavoritePagesListBox.SelectedIndexChanged += new System.EventHandler(this.FavoritePagesListBox_SelectedIndexChanged);
            // 
            // FavoritePagesLabel
            // 
            this.FavoritePagesLabel.AutoSize = true;
            this.FavoritePagesLabel.Location = new System.Drawing.Point(85, 172);
            this.FavoritePagesLabel.Name = "FavoritePagesLabel";
            this.FavoritePagesLabel.Size = new System.Drawing.Size(185, 30);
            this.FavoritePagesLabel.TabIndex = 57;
            this.FavoritePagesLabel.Text = "Favorite Pages";
            this.FavoritePagesLabel.Visible = false;
            // 
            // textBoxAppID
            // 
            this.textBoxAppID.Location = new System.Drawing.Point(317, 61);
            this.textBoxAppID.Name = "textBoxAppID";
            this.textBoxAppID.Size = new System.Drawing.Size(237, 37);
            this.textBoxAppID.TabIndex = 54;
            this.textBoxAppID.Text = "936827228016864";
            // 
            // AlbumsTab
            // 
            this.AlbumsTab.Controls.Add(this.AlbumImagesLabel);
            this.AlbumsTab.Controls.Add(this.AlbumImageNextButton);
            this.AlbumsTab.Controls.Add(this.AlbumImagePerviousButton);
            this.AlbumsTab.Controls.Add(this.AlbumPictureBox);
            this.AlbumsTab.Controls.Add(this.AlbumsLabel);
            this.AlbumsTab.Controls.Add(this.AlbumsListBox);
            this.AlbumsTab.Location = new System.Drawing.Point(4, 39);
            this.AlbumsTab.Name = "AlbumsTab";
            this.AlbumsTab.Padding = new System.Windows.Forms.Padding(3);
            this.AlbumsTab.Size = new System.Drawing.Size(1531, 1007);
            this.AlbumsTab.TabIndex = 1;
            this.AlbumsTab.Text = "Albums";
            this.AlbumsTab.UseVisualStyleBackColor = true;
            // 
            // AlbumImagesLabel
            // 
            this.AlbumImagesLabel.AutoSize = true;
            this.AlbumImagesLabel.Location = new System.Drawing.Point(486, 111);
            this.AlbumImagesLabel.Name = "AlbumImagesLabel";
            this.AlbumImagesLabel.Size = new System.Drawing.Size(0, 30);
            this.AlbumImagesLabel.TabIndex = 72;
            // 
            // AlbumImageNextButton
            // 
            this.AlbumImageNextButton.Enabled = false;
            this.AlbumImageNextButton.Location = new System.Drawing.Point(567, 459);
            this.AlbumImageNextButton.Name = "AlbumImageNextButton";
            this.AlbumImageNextButton.Size = new System.Drawing.Size(145, 60);
            this.AlbumImageNextButton.TabIndex = 71;
            this.AlbumImageNextButton.Text = "Next";
            this.AlbumImageNextButton.UseVisualStyleBackColor = true;
            this.AlbumImageNextButton.Visible = false;
            this.AlbumImageNextButton.Click += new System.EventHandler(this.AlbumImageNextButton_Click);
            // 
            // AlbumImagePerviousButton
            // 
            this.AlbumImagePerviousButton.Enabled = false;
            this.AlbumImagePerviousButton.Location = new System.Drawing.Point(363, 459);
            this.AlbumImagePerviousButton.Name = "AlbumImagePerviousButton";
            this.AlbumImagePerviousButton.Size = new System.Drawing.Size(145, 60);
            this.AlbumImagePerviousButton.TabIndex = 70;
            this.AlbumImagePerviousButton.Text = "Previous";
            this.AlbumImagePerviousButton.UseVisualStyleBackColor = true;
            this.AlbumImagePerviousButton.Visible = false;
            this.AlbumImagePerviousButton.Click += new System.EventHandler(this.AlbumImagePerviousButton_Click);
            // 
            // AlbumPictureBox
            // 
            this.AlbumPictureBox.Location = new System.Drawing.Point(363, 169);
            this.AlbumPictureBox.Name = "AlbumPictureBox";
            this.AlbumPictureBox.Size = new System.Drawing.Size(349, 271);
            this.AlbumPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AlbumPictureBox.TabIndex = 69;
            this.AlbumPictureBox.TabStop = false;
            this.AlbumPictureBox.Visible = false;
            // 
            // AlbumsLabel
            // 
            this.AlbumsLabel.AutoSize = true;
            this.AlbumsLabel.Location = new System.Drawing.Point(68, 120);
            this.AlbumsLabel.Name = "AlbumsLabel";
            this.AlbumsLabel.Size = new System.Drawing.Size(175, 30);
            this.AlbumsLabel.TabIndex = 60;
            this.AlbumsLabel.Text = "Album Names";
            this.AlbumsLabel.Visible = false;
            // 
            // AlbumsListBox
            // 
            this.AlbumsListBox.FormattingEnabled = true;
            this.AlbumsListBox.ItemHeight = 30;
            this.AlbumsListBox.Location = new System.Drawing.Point(30, 169);
            this.AlbumsListBox.Name = "AlbumsListBox";
            this.AlbumsListBox.Size = new System.Drawing.Size(251, 214);
            this.AlbumsListBox.TabIndex = 59;
            this.AlbumsListBox.Visible = false;
            this.AlbumsListBox.SelectedIndexChanged += new System.EventHandler(this.AlbumsListBox_SelectedIndexChanged);
            // 
            // AboutTab
            // 
            this.AboutTab.Controls.Add(this.emailLabelData);
            this.AboutTab.Controls.Add(this.genderLabelData);
            this.AboutTab.Controls.Add(this.birthdayLabelData);
            this.AboutTab.Controls.Add(this.FullNameLabelData);
            this.AboutTab.Controls.Add(this.emailLabel);
            this.AboutTab.Controls.Add(this.genderLabel);
            this.AboutTab.Controls.Add(this.birthdayLabel);
            this.AboutTab.Controls.Add(this.fullNameLabel);
            this.AboutTab.Location = new System.Drawing.Point(4, 39);
            this.AboutTab.Name = "AboutTab";
            this.AboutTab.Padding = new System.Windows.Forms.Padding(3);
            this.AboutTab.Size = new System.Drawing.Size(1531, 1007);
            this.AboutTab.TabIndex = 2;
            this.AboutTab.Text = "About";
            this.AboutTab.UseVisualStyleBackColor = true;
            // 
            // emailLabelData
            // 
            this.emailLabelData.AutoSize = true;
            this.emailLabelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabelData.Location = new System.Drawing.Point(222, 238);
            this.emailLabelData.Name = "emailLabelData";
            this.emailLabelData.Size = new System.Drawing.Size(83, 30);
            this.emailLabelData.TabIndex = 7;
            this.emailLabelData.Text = "Email";
            this.emailLabelData.Visible = false;
            // 
            // genderLabelData
            // 
            this.genderLabelData.AutoSize = true;
            this.genderLabelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLabelData.Location = new System.Drawing.Point(222, 179);
            this.genderLabelData.Name = "genderLabelData";
            this.genderLabelData.Size = new System.Drawing.Size(104, 30);
            this.genderLabelData.TabIndex = 6;
            this.genderLabelData.Text = "Gender";
            this.genderLabelData.Visible = false;
            // 
            // birthdayLabelData
            // 
            this.birthdayLabelData.AutoSize = true;
            this.birthdayLabelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdayLabelData.Location = new System.Drawing.Point(222, 123);
            this.birthdayLabelData.Name = "birthdayLabelData";
            this.birthdayLabelData.Size = new System.Drawing.Size(115, 30);
            this.birthdayLabelData.TabIndex = 5;
            this.birthdayLabelData.Text = "Birthday";
            this.birthdayLabelData.Visible = false;
            // 
            // FullNameLabelData
            // 
            this.FullNameLabelData.AutoSize = true;
            this.FullNameLabelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullNameLabelData.Location = new System.Drawing.Point(221, 68);
            this.FullNameLabelData.Name = "FullNameLabelData";
            this.FullNameLabelData.Size = new System.Drawing.Size(140, 30);
            this.FullNameLabelData.TabIndex = 4;
            this.FullNameLabelData.Text = "Full Name";
            this.FullNameLabelData.Visible = false;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(61, 238);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(92, 30);
            this.emailLabel.TabIndex = 3;
            this.emailLabel.Text = "Email: ";
            this.emailLabel.Visible = false;
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(61, 179);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(112, 30);
            this.genderLabel.TabIndex = 2;
            this.genderLabel.Text = "Gender: ";
            this.genderLabel.Visible = false;
            // 
            // birthdayLabel
            // 
            this.birthdayLabel.AutoSize = true;
            this.birthdayLabel.Location = new System.Drawing.Point(61, 123);
            this.birthdayLabel.Name = "birthdayLabel";
            this.birthdayLabel.Size = new System.Drawing.Size(121, 30);
            this.birthdayLabel.TabIndex = 1;
            this.birthdayLabel.Text = "Birthday: ";
            this.birthdayLabel.Visible = false;
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Location = new System.Drawing.Point(61, 68);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(145, 30);
            this.fullNameLabel.TabIndex = 0;
            this.fullNameLabel.Text = "Full Name: ";
            this.fullNameLabel.Visible = false;
            // 
            // AIRephraser
            // 
            this.AIRephraser.Controls.Add(this.label1);
            this.AIRephraser.Controls.Add(this.PostActionButton);
            this.AIRephraser.Controls.Add(this.NextSuggestedTextButton);
            this.AIRephraser.Controls.Add(this.PreviousSuggestedTextButton);
            this.AIRephraser.Controls.Add(this.WriteStatusRichTextBox);
            this.AIRephraser.Controls.Add(this.StartRephraseButton);
            this.AIRephraser.Controls.Add(this.SuggestedByAITextBox);
            this.AIRephraser.Location = new System.Drawing.Point(4, 39);
            this.AIRephraser.Name = "AIRephraser";
            this.AIRephraser.Padding = new System.Windows.Forms.Padding(3);
            this.AIRephraser.Size = new System.Drawing.Size(1531, 1007);
            this.AIRephraser.TabIndex = 3;
            this.AIRephraser.Text = "AI Rephraser";
            this.AIRephraser.UseVisualStyleBackColor = true;
            // 
            // StartRephraseButton
            // 
            this.StartRephraseButton.Location = new System.Drawing.Point(157, 476);
            this.StartRephraseButton.Name = "StartRephraseButton";
            this.StartRephraseButton.Size = new System.Drawing.Size(153, 77);
            this.StartRephraseButton.TabIndex = 63;
            this.StartRephraseButton.Text = "Start";
            this.StartRephraseButton.UseVisualStyleBackColor = true;
            this.StartRephraseButton.Click += new System.EventHandler(this.StartAiButton_Click);
            // 
            // SuggestedByAITextBox
            // 
            this.SuggestedByAITextBox.Location = new System.Drawing.Point(561, 111);
            this.SuggestedByAITextBox.Name = "SuggestedByAITextBox";
            this.SuggestedByAITextBox.ReadOnly = true;
            this.SuggestedByAITextBox.Size = new System.Drawing.Size(592, 327);
            this.SuggestedByAITextBox.TabIndex = 62;
            this.SuggestedByAITextBox.Text = "";
            // 
            // WriteStatusRichTextBox
            // 
            this.WriteStatusRichTextBox.Location = new System.Drawing.Point(31, 111);
            this.WriteStatusRichTextBox.Name = "WriteStatusRichTextBox";
            this.WriteStatusRichTextBox.Size = new System.Drawing.Size(404, 344);
            this.WriteStatusRichTextBox.TabIndex = 64;
            this.WriteStatusRichTextBox.Text = "";
            // 
            // PreviousSuggestedTextButton
            // 
            this.PreviousSuggestedTextButton.Enabled = false;
            this.PreviousSuggestedTextButton.Location = new System.Drawing.Point(666, 484);
            this.PreviousSuggestedTextButton.Name = "PreviousSuggestedTextButton";
            this.PreviousSuggestedTextButton.Size = new System.Drawing.Size(145, 60);
            this.PreviousSuggestedTextButton.TabIndex = 71;
            this.PreviousSuggestedTextButton.Text = "Previous";
            this.PreviousSuggestedTextButton.UseVisualStyleBackColor = true;
            this.PreviousSuggestedTextButton.Click += new System.EventHandler(this.PreviousSuggestedTextButton_Click);
            // 
            // NextSuggestedTextButton
            // 
            this.NextSuggestedTextButton.Enabled = false;
            this.NextSuggestedTextButton.Location = new System.Drawing.Point(900, 484);
            this.NextSuggestedTextButton.Name = "NextSuggestedTextButton";
            this.NextSuggestedTextButton.Size = new System.Drawing.Size(145, 60);
            this.NextSuggestedTextButton.TabIndex = 72;
            this.NextSuggestedTextButton.Text = "Next";
            this.NextSuggestedTextButton.UseVisualStyleBackColor = true;
            this.NextSuggestedTextButton.Click += new System.EventHandler(this.NextSuggestedTextButton_Click);
            // 
            // PostActionButton
            // 
            this.PostActionButton.Location = new System.Drawing.Point(962, 561);
            this.PostActionButton.Name = "PostActionButton";
            this.PostActionButton.Size = new System.Drawing.Size(191, 76);
            this.PostActionButton.TabIndex = 73;
            this.PostActionButton.Text = "Post!";
            this.PostActionButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(928, 30);
            this.label1.TabIndex = 74;
            this.label1.Text = "Let AI suggest you better rephrasing of your text! Note: New lines are not allowe" +
    "d";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1539, 1050);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Best Facebook App";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.tabControl.ResumeLayout(false);
            this.HomeTab.ResumeLayout(false);
            this.HomeTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePostPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FavPagePictureBox)).EndInit();
            this.AlbumsTab.ResumeLayout(false);
            this.AlbumsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumPictureBox)).EndInit();
            this.AboutTab.ResumeLayout(false);
            this.AboutTab.PerformLayout();
            this.AIRephraser.ResumeLayout(false);
            this.AIRephraser.PerformLayout();
            this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.Button buttonLogout;
		private System.Windows.Forms.TabPage HomeTab;
        private System.Windows.Forms.TextBox textBoxAppID;
        private System.Windows.Forms.Label FavoritePagesLabel;
        private System.Windows.Forms.ListBox FavoritePagesListBox;
        private System.Windows.Forms.CheckBox RememberMeCheckBox;
        private System.Windows.Forms.PictureBox FavPagePictureBox;
        private System.Windows.Forms.Button NextStatusButton;
        private System.Windows.Forms.Button PreviousStatusButton;
        private System.Windows.Forms.RichTextBox PostRichTextBox;
        private System.Windows.Forms.Label MyStatusesLabel;
        private System.Windows.Forms.PictureBox ImagePostPictureBox;
        private System.Windows.Forms.Button NextImagePostButton;
        private System.Windows.Forms.Button PreviousImagePostButton;
        private System.Windows.Forms.Label MyImagePostsLabel;
        private System.Windows.Forms.Label MyFriendsLabel;
        private System.Windows.Forms.ListBox FriendsListBox;
        private System.Windows.Forms.TabPage AlbumsTab;
        private System.Windows.Forms.Label AlbumsLabel;
        private System.Windows.Forms.ListBox AlbumsListBox;
        private System.Windows.Forms.Label AlbumImagesLabel;
        private System.Windows.Forms.Button AlbumImageNextButton;
        private System.Windows.Forms.Button AlbumImagePerviousButton;
        private System.Windows.Forms.PictureBox AlbumPictureBox;
        private System.Windows.Forms.TabPage AboutTab;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label birthdayLabel;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Label emailLabelData;
        private System.Windows.Forms.Label genderLabelData;
        private System.Windows.Forms.Label birthdayLabelData;
        private System.Windows.Forms.Label FullNameLabelData;
        private System.Windows.Forms.TabPage AIRephraser;
        private System.Windows.Forms.RichTextBox SuggestedByAITextBox;
        private System.Windows.Forms.Button StartRephraseButton;
        private System.Windows.Forms.RichTextBox WriteStatusRichTextBox;
        private System.Windows.Forms.Button PreviousSuggestedTextButton;
        private System.Windows.Forms.Button NextSuggestedTextButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PostActionButton;
    }
}

