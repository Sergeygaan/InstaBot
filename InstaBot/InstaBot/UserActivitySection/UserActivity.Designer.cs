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
            this.groupBox2.Location = new System.Drawing.Point(1197, 12);
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
            // UserActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 470);
            this.Controls.Add(this.groupBox2);
            this.Name = "UserActivity";
            this.Text = "UserActivity";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numericImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.Button buttonStartAnalysis;
    }
}