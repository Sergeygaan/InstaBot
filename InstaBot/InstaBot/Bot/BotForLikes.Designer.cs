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
            this.LogListBox = new System.Windows.Forms.ListBox();
            this.labelNumberLikePlaced = new System.Windows.Forms.Label();
            this.followersList = new FollowersList();
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
            // LogListBox
            // 
            this.LogListBox.FormattingEnabled = true;
            this.LogListBox.Location = new System.Drawing.Point(587, 27);
            this.LogListBox.Name = "LogListBox";
            this.LogListBox.Size = new System.Drawing.Size(529, 303);
            this.LogListBox.TabIndex = 20;
            // 
            // labelNumberLikePlaced
            // 
            this.labelNumberLikePlaced.AutoSize = true;
            this.labelNumberLikePlaced.Location = new System.Drawing.Point(584, 8);
            this.labelNumberLikePlaced.Name = "labelNumberLikePlaced";
            this.labelNumberLikePlaced.Size = new System.Drawing.Size(127, 13);
            this.labelNumberLikePlaced.TabIndex = 22;
            this.labelNumberLikePlaced.Text = "Number of likes placed: 0";
            // 
            // followersList
            // 
            this.followersList.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.followersList.Location = new System.Drawing.Point(12, 8);
            this.followersList.Name = "followersList";
            this.followersList.Size = new System.Drawing.Size(409, 415);
            this.followersList.TabIndex = 23;
            // 
            // BotForLikes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 428);
            this.Controls.Add(this.followersList);
            this.Controls.Add(this.labelNumberLikePlaced);
            this.Controls.Add(this.LogListBox);
            this.Controls.Add(this.StartButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BotForLikes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BotForLikes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BotForLikes_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.ListBox LogListBox;
        private System.Windows.Forms.Label labelNumberLikePlaced;
        private FollowersList followersList;
    }
}