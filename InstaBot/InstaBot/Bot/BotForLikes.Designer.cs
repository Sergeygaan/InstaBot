﻿namespace InstaBot.Bot
{
    partial class BotForLikes
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LoadActiveFollowersButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ActiveFollowersUserslistBox = new System.Windows.Forms.ListBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.LogListBox = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LoadActiveFollowersButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 307);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 52);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Active followers users";
            // 
            // LoadActiveFollowersButton
            // 
            this.LoadActiveFollowersButton.Location = new System.Drawing.Point(7, 19);
            this.LoadActiveFollowersButton.Name = "LoadActiveFollowersButton";
            this.LoadActiveFollowersButton.Size = new System.Drawing.Size(141, 23);
            this.LoadActiveFollowersButton.TabIndex = 11;
            this.LoadActiveFollowersButton.Text = "Load active followers";
            this.LoadActiveFollowersButton.UseVisualStyleBackColor = true;
            this.LoadActiveFollowersButton.Click += new System.EventHandler(this.LoadActiveFollowersButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Active followers users";
            // 
            // ActiveFollowersUserslistBox
            // 
            this.ActiveFollowersUserslistBox.FormattingEnabled = true;
            this.ActiveFollowersUserslistBox.Location = new System.Drawing.Point(12, 24);
            this.ActiveFollowersUserslistBox.Name = "ActiveFollowersUserslistBox";
            this.ActiveFollowersUserslistBox.Size = new System.Drawing.Size(332, 277);
            this.ActiveFollowersUserslistBox.TabIndex = 17;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(350, 24);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(141, 23);
            this.StartButton.TabIndex = 12;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // LogListBox
            // 
            this.LogListBox.FormattingEnabled = true;
            this.LogListBox.Location = new System.Drawing.Point(497, 24);
            this.LogListBox.Name = "LogListBox";
            this.LogListBox.Size = new System.Drawing.Size(529, 277);
            this.LogListBox.TabIndex = 20;
            // 
            // BotForLikes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 363);
            this.Controls.Add(this.LogListBox);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ActiveFollowersUserslistBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BotForLikes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BotForLikes";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button LoadActiveFollowersButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox ActiveFollowersUserslistBox;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.ListBox LogListBox;
    }
}