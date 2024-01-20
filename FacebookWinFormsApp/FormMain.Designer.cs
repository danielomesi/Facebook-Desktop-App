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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.NextImagePostButton = new System.Windows.Forms.Button();
            this.PreviousImagePostButton = new System.Windows.Forms.Button();
            this.ImagePostPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NextStatusButton = new System.Windows.Forms.Button();
            this.PreviousStatusButton = new System.Windows.Forms.Button();
            this.PostRichTextBox = new System.Windows.Forms.RichTextBox();
            this.FavPagePictureBox = new System.Windows.Forms.PictureBox();
            this.RememberMeCheckBox = new System.Windows.Forms.CheckBox();
            this.FavoritePagesListBox = new System.Windows.Forms.ListBox();
            this.FavoritePagesLabel = new System.Windows.Forms.Label();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.textBoxAppID = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePostPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FavPagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1162, 773);
            this.tabControl1.TabIndex = 54;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.NextImagePostButton);
            this.tabPage1.Controls.Add(this.PreviousImagePostButton);
            this.tabPage1.Controls.Add(this.ImagePostPictureBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.NextStatusButton);
            this.tabPage1.Controls.Add(this.PreviousStatusButton);
            this.tabPage1.Controls.Add(this.PostRichTextBox);
            this.tabPage1.Controls.Add(this.FavPagePictureBox);
            this.tabPage1.Controls.Add(this.RememberMeCheckBox);
            this.tabPage1.Controls.Add(this.FavoritePagesListBox);
            this.tabPage1.Controls.Add(this.FavoritePagesLabel);
            this.tabPage1.Controls.Add(this.pictureBoxProfile);
            this.tabPage1.Controls.Add(this.textBoxAppID);
            this.tabPage1.Controls.Add(this.buttonLogout);
            this.tabPage1.Controls.Add(this.buttonLogin);
            this.tabPage1.Location = new System.Drawing.Point(4, 35);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1154, 734);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(827, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 26);
            this.label2.TabIndex = 68;
            this.label2.Text = "My Image Posts";
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
            this.ImagePostPictureBox.Click += new System.EventHandler(this.ImagePostPictureBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(438, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 26);
            this.label1.TabIndex = 64;
            this.label1.Text = "My Statuses";
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
            // 
            // FavPagePictureBox
            // 
            this.FavPagePictureBox.Location = new System.Drawing.Point(70, 511);
            this.FavPagePictureBox.Name = "FavPagePictureBox";
            this.FavPagePictureBox.Size = new System.Drawing.Size(200, 200);
            this.FavPagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FavPagePictureBox.TabIndex = 60;
            this.FavPagePictureBox.TabStop = false;
            // 
            // RememberMeCheckBox
            // 
            this.RememberMeCheckBox.AutoSize = true;
            this.RememberMeCheckBox.Location = new System.Drawing.Point(35, 112);
            this.RememberMeCheckBox.Name = "RememberMeCheckBox";
            this.RememberMeCheckBox.Size = new System.Drawing.Size(183, 30);
            this.RememberMeCheckBox.TabIndex = 59;
            this.RememberMeCheckBox.Text = "Remember Me";
            this.RememberMeCheckBox.UseVisualStyleBackColor = true;
            // 
            // FavoritePagesListBox
            // 
            this.FavoritePagesListBox.FormattingEnabled = true;
            this.FavoritePagesListBox.ItemHeight = 26;
            this.FavoritePagesListBox.Location = new System.Drawing.Point(48, 221);
            this.FavoritePagesListBox.Name = "FavoritePagesListBox";
            this.FavoritePagesListBox.Size = new System.Drawing.Size(251, 264);
            this.FavoritePagesListBox.TabIndex = 58;
            this.FavoritePagesListBox.SelectedIndexChanged += new System.EventHandler(this.FavoritePagesListBox_SelectedIndexChanged);
            // 
            // FavoritePagesLabel
            // 
            this.FavoritePagesLabel.AutoSize = true;
            this.FavoritePagesLabel.Location = new System.Drawing.Point(85, 172);
            this.FavoritePagesLabel.Name = "FavoritePagesLabel";
            this.FavoritePagesLabel.Size = new System.Drawing.Size(158, 26);
            this.FavoritePagesLabel.TabIndex = 57;
            this.FavoritePagesLabel.Text = "Favorite Pages";
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(611, 15);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(79, 78);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 55;
            this.pictureBoxProfile.TabStop = false;
            // 
            // textBoxAppID
            // 
            this.textBoxAppID.Location = new System.Drawing.Point(317, 61);
            this.textBoxAppID.Name = "textBoxAppID";
            this.textBoxAppID.Size = new System.Drawing.Size(237, 32);
            this.textBoxAppID.TabIndex = 54;
            this.textBoxAppID.Text = "936827228016864";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 773);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Best Facebook App";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePostPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FavPagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.Button buttonLogout;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBoxAppID;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Label FavoritePagesLabel;
        private System.Windows.Forms.ListBox FavoritePagesListBox;
        private System.Windows.Forms.CheckBox RememberMeCheckBox;
        private System.Windows.Forms.PictureBox FavPagePictureBox;
        private System.Windows.Forms.Button NextStatusButton;
        private System.Windows.Forms.Button PreviousStatusButton;
        private System.Windows.Forms.RichTextBox PostRichTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ImagePostPictureBox;
        private System.Windows.Forms.Button NextImagePostButton;
        private System.Windows.Forms.Button PreviousImagePostButton;
        private System.Windows.Forms.Label label2;
    }
}

