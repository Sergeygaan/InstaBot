namespace InstaBot
{
    partial class AffixedLikes
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
            this.AffixedLikesListView = new System.Windows.Forms.ListView();
            this.User = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Media = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Text = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelNumberLikePlaced = new System.Windows.Forms.Label();
            this.OpenMediaButton = new System.Windows.Forms.Button();
            this.OpenUserButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AffixedLikesListView
            // 
            this.AffixedLikesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.User,
            this.Media,
            this.Text});
            this.AffixedLikesListView.FullRowSelect = true;
            this.AffixedLikesListView.GridLines = true;
            this.AffixedLikesListView.HideSelection = false;
            this.AffixedLikesListView.Location = new System.Drawing.Point(3, 16);
            this.AffixedLikesListView.MultiSelect = false;
            this.AffixedLikesListView.Name = "AffixedLikesListView";
            this.AffixedLikesListView.Size = new System.Drawing.Size(649, 304);
            this.AffixedLikesListView.TabIndex = 1;
            this.AffixedLikesListView.UseCompatibleStateImageBehavior = false;
            this.AffixedLikesListView.View = System.Windows.Forms.View.Details;
            // 
            // User
            // 
            this.User.Text = "User";
            this.User.Width = 200;
            // 
            // Media
            // 
            this.Media.Text = "Media";
            this.Media.Width = 200;
            // 
            // Text
            // 
            this.Text.Text = "Text";
            this.Text.Width = 200;
            // 
            // labelNumberLikePlaced
            // 
            this.labelNumberLikePlaced.AutoSize = true;
            this.labelNumberLikePlaced.Location = new System.Drawing.Point(3, 0);
            this.labelNumberLikePlaced.Name = "labelNumberLikePlaced";
            this.labelNumberLikePlaced.Size = new System.Drawing.Size(127, 13);
            this.labelNumberLikePlaced.TabIndex = 23;
            this.labelNumberLikePlaced.Text = "Number of likes placed: 0";
            // 
            // OpenMediaButton
            // 
            this.OpenMediaButton.Location = new System.Drawing.Point(556, 326);
            this.OpenMediaButton.Name = "OpenMediaButton";
            this.OpenMediaButton.Size = new System.Drawing.Size(96, 23);
            this.OpenMediaButton.TabIndex = 24;
            this.OpenMediaButton.Text = "Open media";
            this.OpenMediaButton.UseVisualStyleBackColor = true;
            this.OpenMediaButton.Click += new System.EventHandler(this.OpenMediaButton_Click);
            // 
            // OpenUserButton
            // 
            this.OpenUserButton.Location = new System.Drawing.Point(454, 326);
            this.OpenUserButton.Name = "OpenUserButton";
            this.OpenUserButton.Size = new System.Drawing.Size(96, 23);
            this.OpenUserButton.TabIndex = 25;
            this.OpenUserButton.Text = "Open user";
            this.OpenUserButton.UseVisualStyleBackColor = true;
            this.OpenUserButton.Click += new System.EventHandler(this.OpenUserButton_Click);
            // 
            // AffixedLikes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.OpenUserButton);
            this.Controls.Add(this.OpenMediaButton);
            this.Controls.Add(this.labelNumberLikePlaced);
            this.Controls.Add(this.AffixedLikesListView);
            this.Name = "AffixedLikes";
            this.Size = new System.Drawing.Size(665, 371);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView AffixedLikesListView;
        private System.Windows.Forms.ColumnHeader User;
        private System.Windows.Forms.ColumnHeader Media;
        private System.Windows.Forms.ColumnHeader Text;
        private System.Windows.Forms.Label labelNumberLikePlaced;
        private System.Windows.Forms.Button OpenMediaButton;
        private System.Windows.Forms.Button OpenUserButton;
    }
}
