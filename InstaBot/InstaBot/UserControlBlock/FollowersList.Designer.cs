namespace InstaBot
{
    partial class FollowersList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UserListView = new System.Windows.Forms.ListView();
            this.User = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NumberLikes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LikeSet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.CountLabel = new System.Windows.Forms.Label();
            this.LikesPostedLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserListView
            // 
            this.UserListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.User,
            this.NumberLikes,
            this.LikeSet});
            this.UserListView.FullRowSelect = true;
            this.UserListView.GridLines = true;
            this.UserListView.HideSelection = false;
            this.UserListView.Location = new System.Drawing.Point(3, 16);
            this.UserListView.MultiSelect = false;
            this.UserListView.Name = "UserListView";
            this.UserListView.Size = new System.Drawing.Size(397, 304);
            this.UserListView.TabIndex = 0;
            this.UserListView.UseCompatibleStateImageBehavior = false;
            this.UserListView.View = System.Windows.Forms.View.Details;
            // 
            // User
            // 
            this.User.Text = "User";
            this.User.Width = 180;
            // 
            // NumberLikes
            // 
            this.NumberLikes.Text = "Number likes";
            this.NumberLikes.Width = 100;
            // 
            // LikeSet
            // 
            this.LikeSet.Text = "Like set";
            this.LikeSet.Width = 100;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SaveButton);
            this.groupBox1.Controls.Add(this.LoadButton);
            this.groupBox1.Location = new System.Drawing.Point(3, 326);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(105, 82);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File operations";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(6, 19);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(85, 23);
            this.SaveButton.TabIndex = 10;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(6, 48);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(85, 23);
            this.LoadButton.TabIndex = 11;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Location = new System.Drawing.Point(6, 0);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(47, 13);
            this.CountLabel.TabIndex = 18;
            this.CountLabel.Text = "Count: 0";
            // 
            // LikesPostedLabel
            // 
            this.LikesPostedLabel.AutoSize = true;
            this.LikesPostedLabel.Location = new System.Drawing.Point(278, 0);
            this.LikesPostedLabel.Name = "LikesPostedLabel";
            this.LikesPostedLabel.Size = new System.Drawing.Size(79, 13);
            this.LikesPostedLabel.TabIndex = 19;
            this.LikesPostedLabel.Text = "Likes posted: 0";
            // 
            // FollowersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.Controls.Add(this.LikesPostedLabel);
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.UserListView);
            this.DoubleBuffered = true;
            this.Name = "FollowersList";
            this.Size = new System.Drawing.Size(409, 415);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView UserListView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Label CountLabel;
        private System.Windows.Forms.ColumnHeader LikeSet;
        private System.Windows.Forms.ColumnHeader User;
        private System.Windows.Forms.ColumnHeader NumberLikes;
        private System.Windows.Forms.Label LikesPostedLabel;
    }
}
