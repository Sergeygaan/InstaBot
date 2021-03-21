namespace InstaBot.UserActivitySection
{
    partial class UserActivity
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
            this.ActiveFollowersUserslistBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SaveActiveFollowersButton = new System.Windows.Forms.Button();
            this.LoadActiveFollowersButton = new System.Windows.Forms.Button();
            this.SaveActiveNotFollowers = new System.Windows.Forms.Button();
            this.LoadActiveNotFollowers = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ActiveNotFollowersUsersListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericImage);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.UserName);
            this.groupBox2.Controls.Add(this.buttonStartAnalysis);
            this.groupBox2.Location = new System.Drawing.Point(717, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(164, 100);
            this.groupBox2.TabIndex = 7;
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
            // ActiveFollowersUserslistBox
            // 
            this.ActiveFollowersUserslistBox.FormattingEnabled = true;
            this.ActiveFollowersUserslistBox.Location = new System.Drawing.Point(12, 28);
            this.ActiveFollowersUserslistBox.Name = "ActiveFollowersUserslistBox";
            this.ActiveFollowersUserslistBox.Size = new System.Drawing.Size(332, 277);
            this.ActiveFollowersUserslistBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Active followers users";
            // 
            // SaveActiveFollowersButton
            // 
            this.SaveActiveFollowersButton.Location = new System.Drawing.Point(6, 19);
            this.SaveActiveFollowersButton.Name = "SaveActiveFollowersButton";
            this.SaveActiveFollowersButton.Size = new System.Drawing.Size(141, 23);
            this.SaveActiveFollowersButton.TabIndex = 10;
            this.SaveActiveFollowersButton.Text = "Save active followers";
            this.SaveActiveFollowersButton.UseVisualStyleBackColor = true;
            this.SaveActiveFollowersButton.Click += new System.EventHandler(this.SaveActiveFollowersButton_Click);
            // 
            // LoadActiveFollowersButton
            // 
            this.LoadActiveFollowersButton.Location = new System.Drawing.Point(6, 48);
            this.LoadActiveFollowersButton.Name = "LoadActiveFollowersButton";
            this.LoadActiveFollowersButton.Size = new System.Drawing.Size(141, 23);
            this.LoadActiveFollowersButton.TabIndex = 11;
            this.LoadActiveFollowersButton.Text = "Load active followers";
            this.LoadActiveFollowersButton.UseVisualStyleBackColor = true;
            this.LoadActiveFollowersButton.Click += new System.EventHandler(this.LoadActiveFollowersButton_Click);
            // 
            // SaveActiveNotFollowers
            // 
            this.SaveActiveNotFollowers.Location = new System.Drawing.Point(7, 19);
            this.SaveActiveNotFollowers.Name = "SaveActiveNotFollowers";
            this.SaveActiveNotFollowers.Size = new System.Drawing.Size(141, 23);
            this.SaveActiveNotFollowers.TabIndex = 12;
            this.SaveActiveNotFollowers.Text = "Save active not followers";
            this.SaveActiveNotFollowers.UseVisualStyleBackColor = true;
            this.SaveActiveNotFollowers.Click += new System.EventHandler(this.SaveActiveNotFollowers_Click);
            // 
            // LoadActiveNotFollowers
            // 
            this.LoadActiveNotFollowers.Location = new System.Drawing.Point(7, 48);
            this.LoadActiveNotFollowers.Name = "LoadActiveNotFollowers";
            this.LoadActiveNotFollowers.Size = new System.Drawing.Size(141, 23);
            this.LoadActiveNotFollowers.TabIndex = 13;
            this.LoadActiveNotFollowers.Text = "Load active not followers";
            this.LoadActiveNotFollowers.UseVisualStyleBackColor = true;
            this.LoadActiveNotFollowers.Click += new System.EventHandler(this.LoadActiveNotFollowers_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Active not followers users";
            // 
            // ActiveNotFollowersUsersListBox
            // 
            this.ActiveNotFollowersUsersListBox.FormattingEnabled = true;
            this.ActiveNotFollowersUsersListBox.Location = new System.Drawing.Point(379, 28);
            this.ActiveNotFollowersUsersListBox.Name = "ActiveNotFollowersUsersListBox";
            this.ActiveNotFollowersUsersListBox.Size = new System.Drawing.Size(332, 277);
            this.ActiveNotFollowersUsersListBox.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SaveActiveFollowersButton);
            this.groupBox1.Controls.Add(this.LoadActiveFollowersButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 311);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 79);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Active followers users";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SaveActiveNotFollowers);
            this.groupBox3.Controls.Add(this.LoadActiveNotFollowers);
            this.groupBox3.Location = new System.Drawing.Point(379, 311);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(154, 78);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Active not followers users";
            // 
            // UserActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 397);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ActiveNotFollowersUsersListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ActiveFollowersUserslistBox);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserActivity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UserActivity";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
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
        private System.Windows.Forms.ListBox ActiveFollowersUserslistBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SaveActiveFollowersButton;
        private System.Windows.Forms.Button LoadActiveFollowersButton;
        private System.Windows.Forms.Button SaveActiveNotFollowers;
        private System.Windows.Forms.Button LoadActiveNotFollowers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox ActiveNotFollowersUsersListBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}