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
            this.Main = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonColorProfile = new System.Windows.Forms.Button();
            this.gbAccountSettings = new System.Windows.Forms.GroupBox();
            this.btnAccountLogout = new System.Windows.Forms.Button();
            this.btnAccountLogin = new System.Windows.Forms.Button();
            this.lblAccountLoginStatus = new System.Windows.Forms.Label();
            this.lblAccountPassword = new System.Windows.Forms.Label();
            this.lblAccountUsername = new System.Windows.Forms.Label();
            this.txtAccountPassword = new System.Windows.Forms.TextBox();
            this.txtAccountUsername = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Main.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbAccountSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main
            // 
            this.Main.Controls.Add(this.tabPage1);
            this.Main.Controls.Add(this.tabPage2);
            this.Main.Location = new System.Drawing.Point(12, 12);
            this.Main.Name = "Main";
            this.Main.SelectedIndex = 0;
            this.Main.Size = new System.Drawing.Size(609, 426);
            this.Main.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonColorProfile);
            this.tabPage1.Controls.Add(this.gbAccountSettings);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(601, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "User";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonColorProfile
            // 
            this.buttonColorProfile.Location = new System.Drawing.Point(515, 371);
            this.buttonColorProfile.Name = "buttonColorProfile";
            this.buttonColorProfile.Size = new System.Drawing.Size(75, 23);
            this.buttonColorProfile.TabIndex = 4;
            this.buttonColorProfile.Text = "ColorProfile";
            this.buttonColorProfile.UseVisualStyleBackColor = true;
            this.buttonColorProfile.Click += new System.EventHandler(this.ButtonColorProfile_Click);
            // 
            // gbAccountSettings
            // 
            this.gbAccountSettings.Controls.Add(this.btnAccountLogout);
            this.gbAccountSettings.Controls.Add(this.btnAccountLogin);
            this.gbAccountSettings.Controls.Add(this.lblAccountLoginStatus);
            this.gbAccountSettings.Controls.Add(this.lblAccountPassword);
            this.gbAccountSettings.Controls.Add(this.lblAccountUsername);
            this.gbAccountSettings.Controls.Add(this.txtAccountPassword);
            this.gbAccountSettings.Controls.Add(this.txtAccountUsername);
            this.gbAccountSettings.Location = new System.Drawing.Point(6, 6);
            this.gbAccountSettings.Name = "gbAccountSettings";
            this.gbAccountSettings.Size = new System.Drawing.Size(584, 80);
            this.gbAccountSettings.TabIndex = 3;
            this.gbAccountSettings.TabStop = false;
            this.gbAccountSettings.Text = "Account Settings";
            // 
            // btnAccountLogout
            // 
            this.btnAccountLogout.Enabled = false;
            this.btnAccountLogout.Location = new System.Drawing.Point(492, 48);
            this.btnAccountLogout.Name = "btnAccountLogout";
            this.btnAccountLogout.Size = new System.Drawing.Size(75, 23);
            this.btnAccountLogout.TabIndex = 4;
            this.btnAccountLogout.Text = "Logout";
            this.btnAccountLogout.UseVisualStyleBackColor = true;
            this.btnAccountLogout.Click += new System.EventHandler(this.BtnAccountLogout_Click);
            // 
            // btnAccountLogin
            // 
            this.btnAccountLogin.Location = new System.Drawing.Point(492, 19);
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
            this.lblAccountLoginStatus.Location = new System.Drawing.Point(14, 58);
            this.lblAccountLoginStatus.Name = "lblAccountLoginStatus";
            this.lblAccountLoginStatus.Size = new System.Drawing.Size(40, 13);
            this.lblAccountLoginStatus.TabIndex = 1;
            this.lblAccountLoginStatus.Text = "Status:";
            // 
            // lblAccountPassword
            // 
            this.lblAccountPassword.AutoSize = true;
            this.lblAccountPassword.Location = new System.Drawing.Point(257, 17);
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
            this.txtAccountPassword.Location = new System.Drawing.Point(260, 33);
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
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(601, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // InstaBot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Main);
            this.Name = "InstaBot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InstaBot";
            this.Main.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gbAccountSettings.ResumeLayout(false);
            this.gbAccountSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Main;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox gbAccountSettings;
        private System.Windows.Forms.Button btnAccountLogout;
        private System.Windows.Forms.Button btnAccountLogin;
        private System.Windows.Forms.Label lblAccountLoginStatus;
        private System.Windows.Forms.Label lblAccountPassword;
        private System.Windows.Forms.Label lblAccountUsername;
        private System.Windows.Forms.TextBox txtAccountPassword;
        private System.Windows.Forms.TextBox txtAccountUsername;
        private System.Windows.Forms.Button buttonColorProfile;
    }
}

