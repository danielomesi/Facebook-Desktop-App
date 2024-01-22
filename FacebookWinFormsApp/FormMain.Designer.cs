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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.LoginTab = new System.Windows.Forms.TabPage();
            this.RememberMeCheckBox = new System.Windows.Forms.CheckBox();
            this.textBoxAppID = new System.Windows.Forms.TextBox();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.HomeTab = new System.Windows.Forms.TabPage();
            this.elapsedTimeLabel = new System.Windows.Forms.Label();
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
            this.FavoritePagesListBox = new System.Windows.Forms.ListBox();
            this.FavoritePagesLabel = new System.Windows.Forms.Label();
            this.AlbumsTab = new System.Windows.Forms.TabPage();
            this.albumCreatedAtLabel = new System.Windows.Forms.Label();
            this.AlbumImagesLabel = new System.Windows.Forms.Label();
            this.AlbumImageNextButton = new System.Windows.Forms.Button();
            this.AlbumImagePerviousButton = new System.Windows.Forms.Button();
            this.AlbumPictureBox = new System.Windows.Forms.PictureBox();
            this.AlbumsLabel = new System.Windows.Forms.Label();
            this.AlbumsListBox = new System.Windows.Forms.ListBox();
            this.AIRephraserTab = new System.Windows.Forms.TabPage();
            this.creditLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PostActionButton = new System.Windows.Forms.Button();
            this.NextSuggestedTextButton = new System.Windows.Forms.Button();
            this.PreviousSuggestedTextButton = new System.Windows.Forms.Button();
            this.WriteStatusRichTextBox = new System.Windows.Forms.RichTextBox();
            this.StartRephraseButton = new System.Windows.Forms.Button();
            this.SuggestedByAITextBox = new System.Windows.Forms.RichTextBox();
            this.AboutTab = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.emailLabelData = new System.Windows.Forms.Label();
            this.genderLabelData = new System.Windows.Forms.Label();
            this.birthdayLabelData = new System.Windows.Forms.Label();
            this.FullNameLabelData = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.birthdayLabel = new System.Windows.Forms.Label();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.LoginTab.SuspendLayout();
            this.HomeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePostPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FavPagePictureBox)).BeginInit();
            this.AlbumsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumPictureBox)).BeginInit();
            this.AIRephraserTab.SuspendLayout();
            this.AboutTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.LoginTab);
            this.tabControl.Controls.Add(this.HomeTab);
            this.tabControl.Controls.Add(this.AlbumsTab);
            this.tabControl.Controls.Add(this.AIRephraserTab);
            this.tabControl.Controls.Add(this.AboutTab);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1168, 698);
            this.tabControl.TabIndex = 54;
            // 
            // LoginTab
            // 
            this.LoginTab.Controls.Add(this.RememberMeCheckBox);
            this.LoginTab.Controls.Add(this.textBoxAppID);
            this.LoginTab.Controls.Add(this.buttonLogout);
            this.LoginTab.Controls.Add(this.buttonLogin);
            this.LoginTab.Location = new System.Drawing.Point(4, 35);
            this.LoginTab.Name = "LoginTab";
            this.LoginTab.Padding = new System.Windows.Forms.Padding(3);
            this.LoginTab.Size = new System.Drawing.Size(1160, 659);
            this.LoginTab.TabIndex = 4;
            this.LoginTab.Text = "Login";
            this.LoginTab.UseVisualStyleBackColor = true;
            // 
            // RememberMeCheckBox
            // 
            this.RememberMeCheckBox.AutoSize = true;
            this.RememberMeCheckBox.Location = new System.Drawing.Point(37, 121);
            this.RememberMeCheckBox.Name = "RememberMeCheckBox";
            this.RememberMeCheckBox.Size = new System.Drawing.Size(183, 30);
            this.RememberMeCheckBox.TabIndex = 63;
            this.RememberMeCheckBox.Text = "Remember Me";
            this.RememberMeCheckBox.UseVisualStyleBackColor = true;
            // 
            // textBoxAppID
            // 
            this.textBoxAppID.Location = new System.Drawing.Point(319, 70);
            this.textBoxAppID.Name = "textBoxAppID";
            this.textBoxAppID.Size = new System.Drawing.Size(237, 32);
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
            this.buttonLogin.Location = new System.Drawing.Point(20, 26);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(268, 32);
            this.buttonLogin.TabIndex = 60;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLoginClick);
            // 
            // HomeTab
            // 
            this.HomeTab.AutoScroll = true;
            this.HomeTab.Controls.Add(this.elapsedTimeLabel);
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
            this.HomeTab.Controls.Add(this.FavoritePagesListBox);
            this.HomeTab.Controls.Add(this.FavoritePagesLabel);
            this.HomeTab.Location = new System.Drawing.Point(4, 35);
            this.HomeTab.Name = "HomeTab";
            this.HomeTab.Padding = new System.Windows.Forms.Padding(3);
            this.HomeTab.Size = new System.Drawing.Size(1160, 659);
            this.HomeTab.TabIndex = 0;
            this.HomeTab.Text = "Home";
            this.HomeTab.UseVisualStyleBackColor = true;
            // 
            // elapsedTimeLabel
            // 
            this.elapsedTimeLabel.AutoSize = true;
            this.elapsedTimeLabel.Location = new System.Drawing.Point(415, 555);
            this.elapsedTimeLabel.Name = "elapsedTimeLabel";
            this.elapsedTimeLabel.Size = new System.Drawing.Size(0, 26);
            this.elapsedTimeLabel.TabIndex = 71;
            // 
            // MyFriendsLabel
            // 
            this.MyFriendsLabel.AutoSize = true;
            this.MyFriendsLabel.Location = new System.Drawing.Point(906, 61);
            this.MyFriendsLabel.Name = "MyFriendsLabel";
            this.MyFriendsLabel.Size = new System.Drawing.Size(159, 26);
            this.MyFriendsLabel.TabIndex = 70;
            this.MyFriendsLabel.Text = "My Friends List";
            this.MyFriendsLabel.Visible = false;
            // 
            // FriendsListBox
            // 
            this.FriendsListBox.FormattingEnabled = true;
            this.FriendsListBox.ItemHeight = 26;
            this.FriendsListBox.Location = new System.Drawing.Point(854, 90);
            this.FriendsListBox.Name = "FriendsListBox";
            this.FriendsListBox.Size = new System.Drawing.Size(249, 212);
            this.FriendsListBox.TabIndex = 69;
            this.FriendsListBox.Visible = false;
            // 
            // MyImagePostsLabel
            // 
            this.MyImagePostsLabel.AutoSize = true;
            this.MyImagePostsLabel.Location = new System.Drawing.Point(627, 61);
            this.MyImagePostsLabel.Name = "MyImagePostsLabel";
            this.MyImagePostsLabel.Size = new System.Drawing.Size(169, 26);
            this.MyImagePostsLabel.TabIndex = 68;
            this.MyImagePostsLabel.Text = "My Image Posts";
            this.MyImagePostsLabel.Visible = false;
            // 
            // NextImagePostButton
            // 
            this.NextImagePostButton.Enabled = false;
            this.NextImagePostButton.Location = new System.Drawing.Point(724, 308);
            this.NextImagePostButton.Name = "NextImagePostButton";
            this.NextImagePostButton.Size = new System.Drawing.Size(109, 49);
            this.NextImagePostButton.TabIndex = 67;
            this.NextImagePostButton.Text = "Next";
            this.NextImagePostButton.UseVisualStyleBackColor = true;
            this.NextImagePostButton.Visible = false;
            this.NextImagePostButton.Click += new System.EventHandler(this.nextImagePostButton_Click);
            // 
            // PreviousImagePostButton
            // 
            this.PreviousImagePostButton.Enabled = false;
            this.PreviousImagePostButton.Location = new System.Drawing.Point(584, 308);
            this.PreviousImagePostButton.Name = "PreviousImagePostButton";
            this.PreviousImagePostButton.Size = new System.Drawing.Size(109, 49);
            this.PreviousImagePostButton.TabIndex = 66;
            this.PreviousImagePostButton.Text = "Previous";
            this.PreviousImagePostButton.UseVisualStyleBackColor = true;
            this.PreviousImagePostButton.Visible = false;
            this.PreviousImagePostButton.Click += new System.EventHandler(this.previousImagePostButton_Click);
            // 
            // ImagePostPictureBox
            // 
            this.ImagePostPictureBox.Location = new System.Drawing.Point(584, 90);
            this.ImagePostPictureBox.Name = "ImagePostPictureBox";
            this.ImagePostPictureBox.Size = new System.Drawing.Size(249, 212);
            this.ImagePostPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImagePostPictureBox.TabIndex = 65;
            this.ImagePostPictureBox.TabStop = false;
            this.ImagePostPictureBox.Visible = false;
            this.ImagePostPictureBox.Click += new System.EventHandler(this.imagePostPictureBox_Click);
            // 
            // MyStatusesLabel
            // 
            this.MyStatusesLabel.AutoSize = true;
            this.MyStatusesLabel.Location = new System.Drawing.Point(373, 61);
            this.MyStatusesLabel.Name = "MyStatusesLabel";
            this.MyStatusesLabel.Size = new System.Drawing.Size(132, 26);
            this.MyStatusesLabel.TabIndex = 64;
            this.MyStatusesLabel.Text = "My Statuses";
            this.MyStatusesLabel.Visible = false;
            // 
            // NextStatusButton
            // 
            this.NextStatusButton.Enabled = false;
            this.NextStatusButton.Location = new System.Drawing.Point(447, 309);
            this.NextStatusButton.Name = "NextStatusButton";
            this.NextStatusButton.Size = new System.Drawing.Size(109, 48);
            this.NextStatusButton.TabIndex = 63;
            this.NextStatusButton.Text = "Next";
            this.NextStatusButton.UseVisualStyleBackColor = true;
            this.NextStatusButton.Visible = false;
            this.NextStatusButton.Click += new System.EventHandler(this.nextPostButton_Click);
            // 
            // PreviousStatusButton
            // 
            this.PreviousStatusButton.Enabled = false;
            this.PreviousStatusButton.Location = new System.Drawing.Point(319, 309);
            this.PreviousStatusButton.Name = "PreviousStatusButton";
            this.PreviousStatusButton.Size = new System.Drawing.Size(106, 48);
            this.PreviousStatusButton.TabIndex = 62;
            this.PreviousStatusButton.Text = "Previous";
            this.PreviousStatusButton.UseVisualStyleBackColor = true;
            this.PreviousStatusButton.Visible = false;
            this.PreviousStatusButton.Click += new System.EventHandler(this.previousPostButton_Click);
            // 
            // PostRichTextBox
            // 
            this.PostRichTextBox.Location = new System.Drawing.Point(319, 90);
            this.PostRichTextBox.Name = "PostRichTextBox";
            this.PostRichTextBox.ReadOnly = true;
            this.PostRichTextBox.Size = new System.Drawing.Size(237, 212);
            this.PostRichTextBox.TabIndex = 61;
            this.PostRichTextBox.Text = "";
            this.PostRichTextBox.Visible = false;
            // 
            // FavPagePictureBox
            // 
            this.FavPagePictureBox.Location = new System.Drawing.Point(85, 327);
            this.FavPagePictureBox.Name = "FavPagePictureBox";
            this.FavPagePictureBox.Size = new System.Drawing.Size(150, 150);
            this.FavPagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FavPagePictureBox.TabIndex = 60;
            this.FavPagePictureBox.TabStop = false;
            this.FavPagePictureBox.Visible = false;
            // 
            // FavoritePagesListBox
            // 
            this.FavoritePagesListBox.FormattingEnabled = true;
            this.FavoritePagesListBox.ItemHeight = 26;
            this.FavoritePagesListBox.Location = new System.Drawing.Point(37, 90);
            this.FavoritePagesListBox.Name = "FavoritePagesListBox";
            this.FavoritePagesListBox.Size = new System.Drawing.Size(251, 212);
            this.FavoritePagesListBox.TabIndex = 58;
            this.FavoritePagesListBox.Visible = false;
            this.FavoritePagesListBox.SelectedIndexChanged += new System.EventHandler(this.favoritePagesListBox_SelectedIndexChanged);
            // 
            // FavoritePagesLabel
            // 
            this.FavoritePagesLabel.AutoSize = true;
            this.FavoritePagesLabel.Location = new System.Drawing.Point(80, 61);
            this.FavoritePagesLabel.Name = "FavoritePagesLabel";
            this.FavoritePagesLabel.Size = new System.Drawing.Size(158, 26);
            this.FavoritePagesLabel.TabIndex = 57;
            this.FavoritePagesLabel.Text = "Favorite Pages";
            this.FavoritePagesLabel.Visible = false;
            // 
            // AlbumsTab
            // 
            this.AlbumsTab.AutoScroll = true;
            this.AlbumsTab.Controls.Add(this.albumCreatedAtLabel);
            this.AlbumsTab.Controls.Add(this.AlbumImagesLabel);
            this.AlbumsTab.Controls.Add(this.AlbumImageNextButton);
            this.AlbumsTab.Controls.Add(this.AlbumImagePerviousButton);
            this.AlbumsTab.Controls.Add(this.AlbumPictureBox);
            this.AlbumsTab.Controls.Add(this.AlbumsLabel);
            this.AlbumsTab.Controls.Add(this.AlbumsListBox);
            this.AlbumsTab.Location = new System.Drawing.Point(4, 35);
            this.AlbumsTab.Name = "AlbumsTab";
            this.AlbumsTab.Padding = new System.Windows.Forms.Padding(3);
            this.AlbumsTab.Size = new System.Drawing.Size(1160, 659);
            this.AlbumsTab.TabIndex = 1;
            this.AlbumsTab.Text = "Albums";
            this.AlbumsTab.UseVisualStyleBackColor = true;
            // 
            // albumCreatedAtLabel
            // 
            this.albumCreatedAtLabel.AutoSize = true;
            this.albumCreatedAtLabel.Location = new System.Drawing.Point(384, 360);
            this.albumCreatedAtLabel.Name = "albumCreatedAtLabel";
            this.albumCreatedAtLabel.Size = new System.Drawing.Size(0, 26);
            this.albumCreatedAtLabel.TabIndex = 73;
            // 
            // AlbumImagesLabel
            // 
            this.AlbumImagesLabel.AutoSize = true;
            this.AlbumImagesLabel.Location = new System.Drawing.Point(533, 64);
            this.AlbumImagesLabel.Name = "AlbumImagesLabel";
            this.AlbumImagesLabel.Size = new System.Drawing.Size(0, 26);
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
            this.AlbumsLabel.Size = new System.Drawing.Size(151, 26);
            this.AlbumsLabel.TabIndex = 60;
            this.AlbumsLabel.Text = "Album Names";
            this.AlbumsLabel.Visible = false;
            // 
            // AlbumsListBox
            // 
            this.AlbumsListBox.FormattingEnabled = true;
            this.AlbumsListBox.ItemHeight = 26;
            this.AlbumsListBox.Location = new System.Drawing.Point(44, 93);
            this.AlbumsListBox.Name = "AlbumsListBox";
            this.AlbumsListBox.Size = new System.Drawing.Size(251, 212);
            this.AlbumsListBox.TabIndex = 59;
            this.AlbumsListBox.Visible = false;
            this.AlbumsListBox.SelectedIndexChanged += new System.EventHandler(this.albumsListBox_SelectedIndexChanged);
            // 
            // AIRephraserTab
            // 
            this.AIRephraserTab.AutoScroll = true;
            this.AIRephraserTab.Controls.Add(this.creditLabel);
            this.AIRephraserTab.Controls.Add(this.label1);
            this.AIRephraserTab.Controls.Add(this.PostActionButton);
            this.AIRephraserTab.Controls.Add(this.NextSuggestedTextButton);
            this.AIRephraserTab.Controls.Add(this.PreviousSuggestedTextButton);
            this.AIRephraserTab.Controls.Add(this.WriteStatusRichTextBox);
            this.AIRephraserTab.Controls.Add(this.StartRephraseButton);
            this.AIRephraserTab.Controls.Add(this.SuggestedByAITextBox);
            this.AIRephraserTab.Location = new System.Drawing.Point(4, 35);
            this.AIRephraserTab.Name = "AIRephraserTab";
            this.AIRephraserTab.Padding = new System.Windows.Forms.Padding(3);
            this.AIRephraserTab.Size = new System.Drawing.Size(1160, 659);
            this.AIRephraserTab.TabIndex = 3;
            this.AIRephraserTab.Text = "AI Rephraser";
            this.AIRephraserTab.UseVisualStyleBackColor = true;
            // 
            // creditLabel
            // 
            this.creditLabel.AutoSize = true;
            this.creditLabel.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditLabel.Location = new System.Drawing.Point(100, 595);
            this.creditLabel.Name = "creditLabel";
            this.creditLabel.Size = new System.Drawing.Size(261, 39);
            this.creditLabel.TabIndex = 75;
            this.creditLabel.Text = "© Paraphrase API service";
            this.creditLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(869, 39);
            this.label1.TabIndex = 74;
            this.label1.Text = "Let AI suggest you better rephrasing of your text! Note: New lines are not allowe" +
    "d";
            this.label1.Visible = false;
            // 
            // PostActionButton
            // 
            this.PostActionButton.Enabled = false;
            this.PostActionButton.Location = new System.Drawing.Point(570, 527);
            this.PostActionButton.Name = "PostActionButton";
            this.PostActionButton.Size = new System.Drawing.Size(191, 76);
            this.PostActionButton.TabIndex = 73;
            this.PostActionButton.Text = "Post!";
            this.PostActionButton.UseVisualStyleBackColor = true;
            this.PostActionButton.Visible = false;
            this.PostActionButton.Click += new System.EventHandler(this.postActionButton_Click);
            // 
            // NextSuggestedTextButton
            // 
            this.NextSuggestedTextButton.Enabled = false;
            this.NextSuggestedTextButton.Location = new System.Drawing.Point(674, 461);
            this.NextSuggestedTextButton.Name = "NextSuggestedTextButton";
            this.NextSuggestedTextButton.Size = new System.Drawing.Size(145, 60);
            this.NextSuggestedTextButton.TabIndex = 72;
            this.NextSuggestedTextButton.Text = "-->";
            this.NextSuggestedTextButton.UseVisualStyleBackColor = true;
            this.NextSuggestedTextButton.Visible = false;
            this.NextSuggestedTextButton.Click += new System.EventHandler(this.nextSuggestedTextButton_Click);
            // 
            // PreviousSuggestedTextButton
            // 
            this.PreviousSuggestedTextButton.Enabled = false;
            this.PreviousSuggestedTextButton.Location = new System.Drawing.Point(523, 461);
            this.PreviousSuggestedTextButton.Name = "PreviousSuggestedTextButton";
            this.PreviousSuggestedTextButton.Size = new System.Drawing.Size(145, 60);
            this.PreviousSuggestedTextButton.TabIndex = 71;
            this.PreviousSuggestedTextButton.Text = "<--";
            this.PreviousSuggestedTextButton.UseVisualStyleBackColor = true;
            this.PreviousSuggestedTextButton.Visible = false;
            this.PreviousSuggestedTextButton.Click += new System.EventHandler(this.previousSuggestedTextButton_Click);
            // 
            // WriteStatusRichTextBox
            // 
            this.WriteStatusRichTextBox.Location = new System.Drawing.Point(37, 128);
            this.WriteStatusRichTextBox.Name = "WriteStatusRichTextBox";
            this.WriteStatusRichTextBox.Size = new System.Drawing.Size(403, 327);
            this.WriteStatusRichTextBox.TabIndex = 64;
            this.WriteStatusRichTextBox.Text = "";
            this.WriteStatusRichTextBox.Visible = false;
            // 
            // StartRephraseButton
            // 
            this.StartRephraseButton.Location = new System.Drawing.Point(156, 461);
            this.StartRephraseButton.Name = "StartRephraseButton";
            this.StartRephraseButton.Size = new System.Drawing.Size(153, 77);
            this.StartRephraseButton.TabIndex = 63;
            this.StartRephraseButton.Text = "Start";
            this.StartRephraseButton.UseVisualStyleBackColor = true;
            this.StartRephraseButton.Visible = false;
            this.StartRephraseButton.Click += new System.EventHandler(this.startAiButton_Click);
            // 
            // SuggestedByAITextBox
            // 
            this.SuggestedByAITextBox.Location = new System.Drawing.Point(457, 128);
            this.SuggestedByAITextBox.Name = "SuggestedByAITextBox";
            this.SuggestedByAITextBox.ReadOnly = true;
            this.SuggestedByAITextBox.Size = new System.Drawing.Size(403, 327);
            this.SuggestedByAITextBox.TabIndex = 62;
            this.SuggestedByAITextBox.Text = "";
            this.SuggestedByAITextBox.Visible = false;
            // 
            // AboutTab
            // 
            this.AboutTab.AutoScroll = true;
            this.AboutTab.Controls.Add(this.label2);
            this.AboutTab.Controls.Add(this.emailLabelData);
            this.AboutTab.Controls.Add(this.genderLabelData);
            this.AboutTab.Controls.Add(this.birthdayLabelData);
            this.AboutTab.Controls.Add(this.FullNameLabelData);
            this.AboutTab.Controls.Add(this.emailLabel);
            this.AboutTab.Controls.Add(this.genderLabel);
            this.AboutTab.Controls.Add(this.birthdayLabel);
            this.AboutTab.Controls.Add(this.fullNameLabel);
            this.AboutTab.Location = new System.Drawing.Point(4, 35);
            this.AboutTab.Name = "AboutTab";
            this.AboutTab.Padding = new System.Windows.Forms.Padding(3);
            this.AboutTab.Size = new System.Drawing.Size(1160, 659);
            this.AboutTab.TabIndex = 2;
            this.AboutTab.Text = "About";
            this.AboutTab.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 39);
            this.label2.TabIndex = 8;
            this.label2.Text = "Basic User Info:";
            this.label2.Visible = false;
            // 
            // emailLabelData
            // 
            this.emailLabelData.AutoSize = true;
            this.emailLabelData.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabelData.Location = new System.Drawing.Point(223, 295);
            this.emailLabelData.Name = "emailLabelData";
            this.emailLabelData.Size = new System.Drawing.Size(73, 39);
            this.emailLabelData.TabIndex = 7;
            this.emailLabelData.Text = "Email";
            this.emailLabelData.Visible = false;
            // 
            // genderLabelData
            // 
            this.genderLabelData.AutoSize = true;
            this.genderLabelData.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLabelData.Location = new System.Drawing.Point(223, 236);
            this.genderLabelData.Name = "genderLabelData";
            this.genderLabelData.Size = new System.Drawing.Size(93, 39);
            this.genderLabelData.TabIndex = 6;
            this.genderLabelData.Text = "Gender";
            this.genderLabelData.Visible = false;
            // 
            // birthdayLabelData
            // 
            this.birthdayLabelData.AutoSize = true;
            this.birthdayLabelData.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdayLabelData.Location = new System.Drawing.Point(223, 180);
            this.birthdayLabelData.Name = "birthdayLabelData";
            this.birthdayLabelData.Size = new System.Drawing.Size(106, 39);
            this.birthdayLabelData.TabIndex = 5;
            this.birthdayLabelData.Text = "Birthday";
            this.birthdayLabelData.Visible = false;
            // 
            // FullNameLabelData
            // 
            this.FullNameLabelData.AutoSize = true;
            this.FullNameLabelData.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullNameLabelData.Location = new System.Drawing.Point(222, 125);
            this.FullNameLabelData.Name = "FullNameLabelData";
            this.FullNameLabelData.Size = new System.Drawing.Size(120, 39);
            this.FullNameLabelData.TabIndex = 4;
            this.FullNameLabelData.Text = "Full Name";
            this.FullNameLabelData.Visible = false;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(62, 295);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(79, 39);
            this.emailLabel.TabIndex = 3;
            this.emailLabel.Text = "Email: ";
            this.emailLabel.Visible = false;
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLabel.Location = new System.Drawing.Point(62, 236);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(100, 39);
            this.genderLabel.TabIndex = 2;
            this.genderLabel.Text = "Gender: ";
            this.genderLabel.Visible = false;
            // 
            // birthdayLabel
            // 
            this.birthdayLabel.AutoSize = true;
            this.birthdayLabel.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdayLabel.Location = new System.Drawing.Point(62, 180);
            this.birthdayLabel.Name = "birthdayLabel";
            this.birthdayLabel.Size = new System.Drawing.Size(108, 39);
            this.birthdayLabel.TabIndex = 1;
            this.birthdayLabel.Text = "Birthday: ";
            this.birthdayLabel.Visible = false;
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullNameLabel.Location = new System.Drawing.Point(62, 125);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(125, 39);
            this.fullNameLabel.TabIndex = 0;
            this.fullNameLabel.Text = "Full Name: ";
            this.fullNameLabel.Visible = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1168, 698);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Best Facebook App";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formMainFormClosing);
            this.Shown += new System.EventHandler(this.formMainShown);
            this.tabControl.ResumeLayout(false);
            this.LoginTab.ResumeLayout(false);
            this.LoginTab.PerformLayout();
            this.HomeTab.ResumeLayout(false);
            this.HomeTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePostPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FavPagePictureBox)).EndInit();
            this.AlbumsTab.ResumeLayout(false);
            this.AlbumsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumPictureBox)).EndInit();
            this.AIRephraserTab.ResumeLayout(false);
            this.AIRephraserTab.PerformLayout();
            this.AboutTab.ResumeLayout(false);
            this.AboutTab.PerformLayout();
            this.ResumeLayout(false);

        }

		#endregion
		private System.Windows.Forms.TabPage HomeTab;
        private System.Windows.Forms.Label FavoritePagesLabel;
        private System.Windows.Forms.ListBox FavoritePagesListBox;
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
        private System.Windows.Forms.TabPage AIRephraserTab;
        private System.Windows.Forms.RichTextBox SuggestedByAITextBox;
        private System.Windows.Forms.Button StartRephraseButton;
        private System.Windows.Forms.RichTextBox WriteStatusRichTextBox;
        private System.Windows.Forms.Button PreviousSuggestedTextButton;
        private System.Windows.Forms.Button NextSuggestedTextButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PostActionButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label albumCreatedAtLabel;
        private System.Windows.Forms.TabPage LoginTab;
        private System.Windows.Forms.CheckBox RememberMeCheckBox;
        private System.Windows.Forms.TextBox textBoxAppID;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label creditLabel;
        private System.Windows.Forms.Label elapsedTimeLabel;
    }
}

