using Extensions;
using InstaSharper.API;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TestDataService;

namespace ColorProfileForm
{
    public partial class ColorProfile : Form
    {
        const int WIDTH = 200;
        const int HEIGHT = 200;
        const int SPACE = 50;

        public ColorProfile(InstagramClient instagramClient)
        {
            InitializeComponent();
            _bitmap = new List<Bitmap>();
            _instagramClient = instagramClient;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _bitmap.Clear();
            panelImage.Controls.Clear();

            var open_dialog = new OpenFileDialog
            {
                Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*", 
                Multiselect = true
            }; 
            if (open_dialog.ShowDialog() == DialogResult.OK) 
            {
                try
                {
                    foreach (var fileName in open_dialog.FileNames)
                    {
                        _bitmap.Add(new Bitmap(fileName));
                    }
                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            GetImage(panelImage, _bitmap);
        }

        private void buttonInstagram_Click(object sender, EventArgs e)
        {
            _bitmap.Clear();
            panelImage.Controls.Clear();

            var userMedia = _instagramClient.GetUserMedia("gaansia");

            if (userMedia.Value != null && userMedia.Value.Any())
            {
                _bitmap.AddRange(DownloadFile.DownloadImage(userMedia.Value));
            }

            GetImage(panelImage, _bitmap);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Bitmap> colorImage = new List<Bitmap>();
            panelColor.Controls.Clear();

            foreach(var image in _bitmap)
            {
                int a = 0;
                int blue = 0;
                int green = 0;
                int red = 0;

                int countPixel = 0;

                for(int x = 0; x <image.Width; x++)
                {
                    for (int y = 0; y < image.Height; y++)
                    {
                        countPixel += 1;
                        var color = image.GetPixel(x, y);
                        a += color.A;
                        blue += color.B;
                        green += color.G;
                        red += color.R;
                    }
                }

                Color myRgbColor = new Color();
                myRgbColor = Color.FromArgb(red / countPixel, green / countPixel, blue / countPixel);

                Bitmap Bmp = new Bitmap(WIDTH, HEIGHT);
                using (Graphics gfx = Graphics.FromImage(Bmp))
                using (SolidBrush brush = new SolidBrush(myRgbColor))
                {
                    gfx.FillRectangle(brush, 0, 0, WIDTH, HEIGHT);
                }

                colorImage.Add(Bmp);
            }

            GetImage(panelColor, colorImage);
            colorImage.Clear();
        }

        public void GetImage(Panel panel, List<Bitmap> bitmap)
        {
            int cols = 0;
            int rows = 0;
            for (int index = 0; index < bitmap.Count; index++)
            {
                var newPictureBox = new PictureBox
                {
                    Width = WIDTH,
                    Height = HEIGHT,
                    Top = rows * (HEIGHT + SPACE),
                    Left = cols * (WIDTH + SPACE),
                    Image = bitmap[index],
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                panel.Controls.Add(newPictureBox);

                cols += 1;

                if (cols >= 3)
                {
                    cols = 0;
                    rows += 1;
                }
            }
        }

        private List<Bitmap> _bitmap;

        private void panelImage_Click(object sender, EventArgs e)
        {
            if (!panelImage.Focused)
            {
                panelImage.Focus();
            }
        }

        private void panelColor_Click(object sender, EventArgs e)
        {
            if (!panelColor.Focused)
            {
                panelColor.Focus();
            }
        }

        private InstagramClient _instagramClient;
    }
}
