namespace InstaBot
{
    partial class InstaBot
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
            this.buttonColorProfile = new System.Windows.Forms.Button();
            this.gbAccountSettings = new System.Windows.Forms.GroupBox();
            this.buttonTwoFactor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTwoFactor = new System.Windows.Forms.TextBox();
            this.btnAccountLogout = new System.Windows.Forms.Button();
            this.btnAccountLogin = new System.Windows.Forms.Button();
            this.lblAccountLoginStatus = new System.Windows.Forms.Label();
            this.lblAccountPassword = new System.Windows.Forms.Label();
            this.lblAccountUsername = new System.Windows.Forms.Label();
            this.txtAccountPassword = new System.Windows.Forms.TextBox();
            this.txtAccountUsername = new System.Windows.Forms.TextBox();
            this.buttonUserActivity = new System.Windows.Forms.Button();
            this.BotForLikesButton = new System.Windows.Forms.Button();
            this.SubscribedUsersButton = new System.Windows.Forms.Button();
            this.gbAccountSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonColorProfile
            // 
            this.buttonColorProfile.Location = new System.Drawing.Point(12, 185);
            this.buttonColorProfile.Name = "buttonColorProfile";
            this.buttonColorProfile.Size = new System.Drawing.Size(75, 23);
            this.buttonColorProfile.TabIndex = 4;
            this.buttonColorProfile.Text = "ColorProfile";
            this.buttonColorProfile.UseVisualStyleBackColor = true;
            this.buttonColorProfile.Click += new System.EventHandler(this.ButtonColorProfile_Click);
            // 
            // gbAccountSettings
            // 
            this.gbAccountSettings.Controls.Add(this.buttonTwoFactor);
            this.gbAccountSettings.Controls.Add(this.label1);
            this.gbAccountSettings.Controls.Add(this.textBoxTwoFactor);
            this.gbAccountSettings.Controls.Add(this.btnAccountLogout);
            this.gbAccountSettings.Controls.Add(this.btnAccountLogin);
            this.gbAccountSettings.Controls.Add(this.lblAccountLoginStatus);
            this.gbAccountSettings.Controls.Add(this.lblAccountPassword);
            this.gbAccountSettings.Controls.Add(this.lblAccountUsername);
            this.gbAccountSettings.Controls.Add(this.txtAccountPassword);
            this.gbAccountSettings.Controls.Add(this.txtAccountUsername);
            this.gbAccountSettings.Location = new System.Drawing.Point(12, 12);
            this.gbAccountSettings.Name = "gbAccountSettings";
            this.gbAccountSettings.Size = new System.Drawing.Size(299, 153);
            this.gbAccountSettings.TabIndex = 3;
            this.gbAccountSettings.TabStop = false;
            this.gbAccountSettings.Text = "Account Settings";
            // 
            // buttonTwoFactor
            // 
            this.buttonTwoFactor.Enabled = false;
            this.buttonTwoFactor.Location = new System.Drawing.Point(217, 109);
            this.buttonTwoFactor.Name = "buttonTwoFactor";
            this.buttonTwoFactor.Size = new System.Drawing.Size(75, 23);
            this.buttonTwoFactor.TabIndex = 7;
            this.buttonTwoFactor.Text = "TwoFactor";
            this.buttonTwoFactor.UseVisualStyleBackColor = true;
            this.buttonTwoFactor.Click += new System.EventHandler(this.ButtonTwoFactor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "TwoFactor:";
            // 
            // textBoxTwoFactor
            // 
            this.textBoxTwoFactor.Enabled = false;
            this.textBoxTwoFactor.Location = new System.Drawing.Point(17, 111);
            this.textBoxTwoFactor.Name = "textBoxTwoFactor";
            this.textBoxTwoFactor.Size = new System.Drawing.Size(194, 20);
            this.textBoxTwoFactor.TabIndex = 6;
            // 
            // btnAccountLogout
            // 
            this.btnAccountLogout.Enabled = false;
            this.btnAccountLogout.Location = new System.Drawing.Point(217, 70);
            this.btnAccountLogout.Name = "btnAccountLogout";
            this.btnAccountLogout.Size = new System.Drawing.Size(75, 23);
            this.btnAccountLogout.TabIndex = 4;
            this.btnAccountLogout.Text = "Logout";
            this.btnAccountLogout.UseVisualStyleBackColor = true;
            this.btnAccountLogout.Click += new System.EventHandler(this.BtnAccountLogout_Click);
            // 
            // btnAccountLogin
            // 
            this.btnAccountLogin.Location = new System.Drawing.Point(217, 33);
            this.btnAccountLogin.Name = "btnAccountLogin";
            this.btnAccountLogin.Size = new System.Drawing.Size(75, 23);
            this.btnAccountLogin.TabIndex = 2;
            this.btnAccountLogin.Text = "Login";
            this.btnAccountLogin.UseVisualStyleBackColor = true;
            this.btnAccountLogin.Click += new System.EventHandler(this.BtnAccountLogin_Click);
            // 
            // lblAccountLoginStatus
            // 
            this.lblAccountLoginStatus.AutoSize = true;
            this.lblAccountLoginStatus.Location = new System.Drawing.Point(14, 134);
            this.lblAccountLoginStatus.Name = "lblAccountLoginStatus";
            this.lblAccountLoginStatus.Size = new System.Drawing.Size(40, 13);
            this.lblAccountLoginStatus.TabIndex = 1;
            this.lblAccountLoginStatus.Text = "Status:";
            // 
            // lblAccountPassword
            // 
            this.lblAccountPassword.AutoSize = true;
            this.lblAccountPassword.Location = new System.Drawing.Point(14, 56);
            this.lblAccountPassword.Name = "lblAccountPassword";
            this.lblAccountPassword.Size = new System.Drawing.Size(56, 13);
            this.lblAccountPassword.TabIndex = 1;
            this.lblAccountPassword.Text = "Password:";
            // 
            // lblAccountUsername
            // 
            this.lblAccountUsername.AutoSize = true;
            this.lblAccountUsername.Location = new System.Drawing.Point(14, 17);
            this.lblAccountUsername.Name = "lblAccountUsername";
            this.lblAccountUsername.Size = new System.Drawing.Size(58, 13);
            this.lblAccountUsername.TabIndex = 1;
            this.lblAccountUsername.Text = "Username:";
            // 
            // txtAccountPassword
            // 
            this.txtAccountPassword.Location = new System.Drawing.Point(17, 72);
            this.txtAccountPassword.Name = "txtAccountPassword";
            this.txtAccountPassword.Size = new System.Drawing.Size(194, 20);
            this.txtAccountPassword.TabIndex = 1;
            // 
            // txtAccountUsername
            // 
            this.txtAccountUsername.Location = new System.Drawing.Point(17, 33);
            this.txtAccountUsername.Name = "txtAccountUsername";
            this.txtAccountUsername.Size = new System.Drawing.Size(194, 20);
            this.txtAccountUsername.TabIndex = 0;
            // 
            // buttonUserActivity
            // 
            this.buttonUserActivity.Location = new System.Drawing.Point(205, 171);
            this.buttonUserActivity.Name = "buttonUserActivity";
            this.buttonUserActivity.Size = new System.Drawing.Size(99, 23);
            this.buttonUserActivity.TabIndex = 6;
            this.buttonUserActivity.Text = "UserActivity";
            this.buttonUserActivity.UseVisualStyleBackColor = true;
            this.buttonUserActivity.Click += new System.EventHandler(this.buttonUserActivity_Click);
            // 
            // BotForLikesButton
            // 
            this.BotForLikesButton.Location = new System.Drawing.Point(205, 200);
            this.BotForLikesButton.Name = "BotForLikesButton";
            this.BotForLikesButton.Size = new System.Drawing.Size(99, 23);
            this.BotForLikesButton.TabIndex = 7;
            this.BotForLikesButton.Text = "BotForLikes";
            this.BotForLikesButton.UseVisualStyleBackColor = true;
            this.BotForLikesButton.Click += new System.EventHandler(this.BotForLikesButton_Click);
            // 
            // SubscribedUsersButton
            // 
            this.SubscribedUsersButton.Location = new System.Drawing.Point(205, 229);
            this.SubscribedUsersButton.Name = "SubscribedUsersButton";
            this.SubscribedUsersButton.Size = new System.Drawing.Size(99, 23);
            this.SubscribedUsersButton.TabIndex = 8;
            this.SubscribedUsersButton.Text = "SubscribedUsers";
            this.SubscribedUsersButton.UseVisualStyleBackColor = true;
            this.SubscribedUsersButton.Click += new System.EventHandler(this.SubscribedUsersButton_Click);
            // 
            // InstaBot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 285);
            this.Controls.Add(this.SubscribedUsersButton);
            this.Controls.Add(this.BotForLikesButton);
            this.Controls.Add(this.buttonUserActivity);
            this.Controls.Add(this.buttonColorProfile);
            this.Controls.Add(this.gbAccountSettings);
            this.Name = "InstaBot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InstaBot";
            this.gbAccountSettings.ResumeLayout(false);
            this.gbAccountSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbAccountSettings;
        private System.Windows.Forms.Button btnAccountLogout;
        private System.Windows.Forms.Button btnAccountLogin;
        private System.Windows.Forms.Label lblAccountLoginStatus;
        private System.Windows.Forms.Label lblAccountPassword;
        private System.Windows.Forms.Label lblAccountUsername;
        private System.Windows.Forms.TextBox txtAccountPassword;
        private System.Windows.Forms.TextBox txtAccountUsername;
        private System.Windows.Forms.Button buttonColorProfile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTwoFactor;
        private System.Windows.Forms.Button buttonTwoFactor;
        private System.Windows.Forms.Button buttonUserActivity;
        private System.Windows.Forms.Button BotForLikesButton;
        private System.Windows.Forms.Button SubscribedUsersButton;
    }
}

