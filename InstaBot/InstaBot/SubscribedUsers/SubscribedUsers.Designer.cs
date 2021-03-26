namespace InstaBot
{
    partial class SubscribedUsers
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericImage = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.TextBox();
            this.buttonStartAnalysis = new System.Windows.Forms.Button();
            this.ListOfUsersToCheck = new FollowersList();
            this.label3 = new System.Windows.Forms.Label();
            this.ListOfSubscribedUsers = new FollowersList();
            this.label4 = new System.Windows.Forms.Label();
            this.ListOfLikedUsers = new FollowersList();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericImage)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericImage);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.UserName);
            this.groupBox2.Controls.Add(this.buttonStartAnalysis);
            this.groupBox2.Location = new System.Drawing.Point(1280, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(164, 100);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Instagram";
            // 
            // numericImage
            // 
            this.numericImage.Increment = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.numericImage.Location = new System.Drawing.Point(41, 45);
            this.numericImage.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numericImage.Name = "numericImage";
            this.numericImage.ReadOnly = true;
            this.numericImage.Size = new System.Drawing.Size(100, 20);
            this.numericImage.TabIndex = 8;
            this.numericImage.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Count";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "User";
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(41, 19);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(100, 20);
            this.UserName.TabIndex = 5;
            // 
            // buttonStartAnalysis
            // 
            this.buttonStartAnalysis.Location = new System.Drawing.Point(9, 71);
            this.buttonStartAnalysis.Name = "buttonStartAnalysis";
            this.buttonStartAnalysis.Size = new System.Drawing.Size(135, 23);
            this.buttonStartAnalysis.TabIndex = 4;
            this.buttonStartAnalysis.Text = "Start analysis";
            this.buttonStartAnalysis.UseVisualStyleBackColor = true;
            this.buttonStartAnalysis.Click += new System.EventHandler(this.ButtonStartAnalysis_Click);
            // 
            // ListOfUsersToCheck
            // 
            this.ListOfUsersToCheck.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ListOfUsersToCheck.Location = new System.Drawing.Point(12, 23);
            this.ListOfUsersToCheck.Name = "ListOfUsersToCheck";
            this.ListOfUsersToCheck.Size = new System.Drawing.Size(409, 415);
            this.ListOfUsersToCheck.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "List of users to check";
            // 
            // ListOfSubscribedUsers
            // 
            this.ListOfSubscribedUsers.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ListOfSubscribedUsers.Location = new System.Drawing.Point(450, 23);
            this.ListOfSubscribedUsers.Name = "ListOfSubscribedUsers";
            this.ListOfSubscribedUsers.Size = new System.Drawing.Size(409, 327);
            this.ListOfSubscribedUsers.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(447, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "List of subscribed users";
            // 
            // ListOfLikedUsers
            // 
            this.ListOfLikedUsers.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ListOfLikedUsers.Location = new System.Drawing.Point(865, 23);
            this.ListOfLikedUsers.Name = "ListOfLikedUsers";
            this.ListOfLikedUsers.Size = new System.Drawing.Size(409, 327);
            this.ListOfLikedUsers.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(862, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "List of liked users";
            // 
            // SubscribedUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ListOfLikedUsers);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ListOfSubscribedUsers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ListOfUsersToCheck);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SubscribedUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SubscribedUsers";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numericImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.Button buttonStartAnalysis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private FollowersList ListOfUsersToCheck;
        private FollowersList ListOfSubscribedUsers;
        private FollowersList ListOfLikedUsers;
    }
}