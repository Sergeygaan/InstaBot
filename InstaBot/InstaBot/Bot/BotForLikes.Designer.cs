namespace InstaBot.Bot
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
            this.StartButton = new System.Windows.Forms.Button();
            this.followersList = new FollowersList();
            this.affixedLikes1 = new AffixedLikes();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(427, 27);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(141, 23);
            this.StartButton.TabIndex = 12;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // followersList
            // 
            this.followersList.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.followersList.Location = new System.Drawing.Point(12, 8);
            this.followersList.Name = "followersList";
            this.followersList.Size = new System.Drawing.Size(409, 415);
            this.followersList.TabIndex = 23;
            // 
            // affixedLikes1
            // 
            this.affixedLikes1.Location = new System.Drawing.Point(574, 12);
            this.affixedLikes1.Name = "affixedLikes1";
            this.affixedLikes1.Size = new System.Drawing.Size(660, 361);
            this.affixedLikes1.TabIndex = 24;
            // 
            // BotForLikes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 428);
            this.Controls.Add(this.affixedLikes1);
            this.Controls.Add(this.followersList);
            this.Controls.Add(this.StartButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BotForLikes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BotForLikes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BotForLikes_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button StartButton;
        private FollowersList followersList;
        private AffixedLikes affixedLikes1;
    }
}