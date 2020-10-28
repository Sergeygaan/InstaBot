namespace ColorProfileForm
{
    partial class ColorProfile
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonGetHardDisk = new System.Windows.Forms.Button();
            this.panelImage = new System.Windows.Forms.Panel();
            this.panelColor = new System.Windows.Forms.Panel();
            this.buttonCalculateColors = new System.Windows.Forms.Button();
            this.buttonGetImage = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericImage = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelProgress = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericImage)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGetHardDisk
            // 
            this.buttonGetHardDisk.Location = new System.Drawing.Point(9, 19);
            this.buttonGetHardDisk.Name = "buttonGetHardDisk";
            this.buttonGetHardDisk.Size = new System.Drawing.Size(135, 23);
            this.buttonGetHardDisk.TabIndex = 0;
            this.buttonGetHardDisk.Text = "Get image HardDisk";
            this.buttonGetHardDisk.UseVisualStyleBackColor = true;
            this.buttonGetHardDisk.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelImage
            // 
            this.panelImage.AutoScroll = true;
            this.panelImage.Location = new System.Drawing.Point(12, 12);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(745, 700);
            this.panelImage.TabIndex = 1;
            this.panelImage.Scroll += new System.Windows.Forms.ScrollEventHandler(this.PanelImage_Scroll);
            this.panelImage.Click += new System.EventHandler(this.panelImage_Click);
            // 
            // panelColor
            // 
            this.panelColor.AutoScroll = true;
            this.panelColor.Location = new System.Drawing.Point(772, 12);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(745, 700);
            this.panelColor.TabIndex = 2;
            this.panelColor.Scroll += new System.Windows.Forms.ScrollEventHandler(this.PanelColor_Scroll);
            this.panelColor.Click += new System.EventHandler(this.panelColor_Click);
            // 
            // buttonCalculateColors
            // 
            this.buttonCalculateColors.Location = new System.Drawing.Point(9, 19);
            this.buttonCalculateColors.Name = "buttonCalculateColors";
            this.buttonCalculateColors.Size = new System.Drawing.Size(135, 23);
            this.buttonCalculateColors.TabIndex = 3;
            this.buttonCalculateColors.Text = "Calculate colors";
            this.buttonCalculateColors.UseVisualStyleBackColor = true;
            this.buttonCalculateColors.Click += new System.EventHandler(this.buttonCalculateColors_Click);
            // 
            // buttonGetImage
            // 
            this.buttonGetImage.Location = new System.Drawing.Point(9, 71);
            this.buttonGetImage.Name = "buttonGetImage";
            this.buttonGetImage.Size = new System.Drawing.Size(135, 23);
            this.buttonGetImage.TabIndex = 4;
            this.buttonGetImage.Text = "Get image";
            this.buttonGetImage.UseVisualStyleBackColor = true;
            this.buttonGetImage.Click += new System.EventHandler(this.buttonInstagram_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonGetHardDisk);
            this.groupBox1.Location = new System.Drawing.Point(1523, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(164, 55);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Disk";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericImage);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.UserName);
            this.groupBox2.Controls.Add(this.buttonGetImage);
            this.groupBox2.Location = new System.Drawing.Point(1523, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(164, 100);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Instagram";
            // 
            // numericImage
            // 
            this.numericImage.Location = new System.Drawing.Point(41, 45);
            this.numericImage.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericImage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericImage.Name = "numericImage";
            this.numericImage.Size = new System.Drawing.Size(100, 20);
            this.numericImage.TabIndex = 8;
            this.numericImage.Value = new decimal(new int[] {
            1,
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonCalculateColors);
            this.groupBox3.Location = new System.Drawing.Point(1523, 179);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(164, 55);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ColorProfile";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labelProgress);
            this.groupBox4.Location = new System.Drawing.Point(1523, 240);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(164, 38);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Progress";
            // 
            // labelProgress
            // 
            this.labelProgress.AutoSize = true;
            this.labelProgress.Location = new System.Drawing.Point(6, 16);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(57, 13);
            this.labelProgress.TabIndex = 0;
            this.labelProgress.Text = "Processed";
            // 
            // ColorProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1699, 725);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelColor);
            this.Controls.Add(this.panelImage);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ColorProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ColorProfile";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericImage)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGetHardDisk;
        private System.Windows.Forms.Panel panelImage;
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.Button buttonCalculateColors;
        private System.Windows.Forms.Button buttonGetImage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericImage;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label labelProgress;
    }
}

