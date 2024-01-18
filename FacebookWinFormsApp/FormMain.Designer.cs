﻿namespace BasicFacebookFeatures
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
            this.NextPostButton = new System.Windows.Forms.Button();
            this.PreviousPostButton = new System.Windows.Forms.Button();
            this.PostRichTextBox = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RememberMeCheckBox = new System.Windows.Forms.CheckBox();
            this.FavoritePagesListBox = new System.Windows.Forms.ListBox();
            this.FavoritePagesLabel = new System.Windows.Forms.Label();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.textBoxAppID = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(1621, 1053);
            this.tabControl1.TabIndex = 54;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.NextPostButton);
            this.tabPage1.Controls.Add(this.PreviousPostButton);
            this.tabPage1.Controls.Add(this.PostRichTextBox);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.RememberMeCheckBox);
            this.tabPage1.Controls.Add(this.FavoritePagesListBox);
            this.tabPage1.Controls.Add(this.FavoritePagesLabel);
            this.tabPage1.Controls.Add(this.pictureBoxProfile);
            this.tabPage1.Controls.Add(this.textBoxAppID);
            this.tabPage1.Controls.Add(this.buttonLogout);
            this.tabPage1.Controls.Add(this.buttonLogin);
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1613, 1010);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // NextPostButton
            // 
            this.NextPostButton.Enabled = false;
            this.NextPostButton.Location = new System.Drawing.Point(532, 614);
            this.NextPostButton.Name = "NextPostButton";
            this.NextPostButton.Size = new System.Drawing.Size(145, 60);
            this.NextPostButton.TabIndex = 63;
            this.NextPostButton.Text = "Next";
            this.NextPostButton.UseVisualStyleBackColor = true;
            this.NextPostButton.Click += new System.EventHandler(this.NextPostButton_Click);
            // 
            // PreviousPostButton
            // 
            this.PreviousPostButton.Enabled = false;
            this.PreviousPostButton.Location = new System.Drawing.Point(354, 614);
            this.PreviousPostButton.Name = "PreviousPostButton";
            this.PreviousPostButton.Size = new System.Drawing.Size(145, 60);
            this.PreviousPostButton.TabIndex = 62;
            this.PreviousPostButton.Text = "Previous";
            this.PreviousPostButton.UseVisualStyleBackColor = true;
            this.PreviousPostButton.Click += new System.EventHandler(this.PreviousPostButton_Click);
            // 
            // PostRichTextBox
            // 
            this.PostRichTextBox.Location = new System.Drawing.Point(354, 324);
            this.PostRichTextBox.Name = "PostRichTextBox";
            this.PostRichTextBox.ReadOnly = true;
            this.PostRichTextBox.Size = new System.Drawing.Size(323, 274);
            this.PostRichTextBox.TabIndex = 61;
            this.PostRichTextBox.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(57, 644);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
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
            this.FavoritePagesListBox.Location = new System.Drawing.Point(35, 324);
            this.FavoritePagesListBox.Name = "FavoritePagesListBox";
            this.FavoritePagesListBox.Size = new System.Drawing.Size(251, 274);
            this.FavoritePagesListBox.TabIndex = 58;
            this.FavoritePagesListBox.SelectedIndexChanged += new System.EventHandler(this.FavoritePagesListBox_SelectedIndexChanged);
            // 
            // FavoritePagesLabel
            // 
            this.FavoritePagesLabel.AutoSize = true;
            this.FavoritePagesLabel.Location = new System.Drawing.Point(72, 275);
            this.FavoritePagesLabel.Name = "FavoritePagesLabel";
            this.FavoritePagesLabel.Size = new System.Drawing.Size(185, 30);
            this.FavoritePagesLabel.TabIndex = 57;
            this.FavoritePagesLabel.Text = "Favorite Pages";
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(35, 174);
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
            this.textBoxAppID.Size = new System.Drawing.Size(237, 37);
            this.textBoxAppID.TabIndex = 54;
            this.textBoxAppID.Text = "936827228016864";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1621, 1053);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button NextPostButton;
        private System.Windows.Forms.Button PreviousPostButton;
        private System.Windows.Forms.RichTextBox PostRichTextBox;
    }
}

