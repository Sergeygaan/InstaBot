using Extensions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
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
            _bitmapList = new List<Bitmap>();
            _colorImage = new List<Bitmap>();

            _instagramClient = instagramClient;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await Task.Run(() => BlockElement(false));
            await Task.Run(() => OutputProgress("Loading"));

            _bitmapList.Clear();
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
                        _bitmapList.Add(new Bitmap(fileName));
                    }
                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            for(var index = 0; index< _bitmapList.Count; index++)
            {
                await Task.Run(() => GetImage(panelImage, _bitmapList[index], index));
                await Task.Run(() => OutputProgress($"Uploaded {index + 1} of {_bitmapList.Count}"));
            }

            await Task.Run(() => BlockElement(true));
        }

        private async void buttonInstagram_Click(object sender, EventArgs e)
        {
            await Task.Run(() => BlockElement(false));
            await Task.Run(() => OutputProgress("Loading"));

            _bitmapList.Clear();
            panelImage.Controls.Clear();
            var index = 0;

            var userMediaList = await _instagramClient.GetUserMedia("gaansia");

            if (userMediaList.Value != null && userMediaList.Value.Any())
            {
                foreach (var instaMedia in userMediaList.Value)
                {
                    index += 1;
                    string requestUriString = null;

                    if (instaMedia.Images != null && instaMedia.Images.Any())
                    {
                        requestUriString = instaMedia.Images.First().URI;
                    }
                    else if (instaMedia.Carousel != null && instaMedia.Carousel.Any())
                    {
                        requestUriString = instaMedia.Carousel.First().Images.First().URI;
                    }

                    await Task.Run(() => _bitmapList.Add(DownloadFile.DownloadImage(requestUriString)));
                    await Task.Run(() => GetImage(panelImage, _bitmapList.Last(), _bitmapList.Count - 1));
                    await Task.Run(() => OutputProgress($"Uploaded {index} of {userMediaList.Value.Count}"));
                }
            }

            await Task.Run(() => BlockElement(true));
        }

        private async void buttonCalculateColors_Click(object sender, EventArgs e)
        {
            await Task.Run(() => BlockElement(false));
            await Task.Run(() => OutputProgress("Processed"));

            _colorImage.Clear();
            panelColor.Controls.Clear();
            var index = 0;

            foreach (var image in _bitmapList)
            {
                index += 1;

                await Task.Run(() => _colorImage.Add(CalculateColors(image)));
                await Task.Run(() => GetImage(panelColor, _colorImage.Last(), _colorImage.Count - 1));
                await Task.Run(() => OutputProgress($"Processed {index} of {_bitmapList.Count}"));
            }

            await Task.Run(() => BlockElement(true));
        }

        private Bitmap CalculateColors(Bitmap image)
        {
            int countPixel = 0;
            int a = 0;
            int blue = 0;
            int green = 0;
            int red = 0;

            for (int x = 0; x < image.Width; x++)
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

            var myRgbColor = new Color();
            myRgbColor = Color.FromArgb(red / countPixel, green / countPixel, blue / countPixel);

            var resultBitmap = new Bitmap(WIDTH, HEIGHT);
            using (var gfx = Graphics.FromImage(resultBitmap))
            using (var brush = new SolidBrush(myRgbColor))
            {
                gfx.FillRectangle(brush, 0, 0, WIDTH, HEIGHT);
            }

            return resultBitmap;
        }

        public void GetImage(Panel panel, Bitmap bitmap, int bitmapCount)
        {
            int cols = bitmapCount % 3;
            int rows = bitmapCount / 3;

            var newPictureBox = new PictureBox
            {
                Width = WIDTH,
                Height = HEIGHT,
                Top = rows * (HEIGHT + SPACE),
                Left = cols * (WIDTH + SPACE),
                Image = bitmap,
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            if (panel.InvokeRequired)
            {
                panel.Invoke(new MethodInvoker(delegate { panel.Controls.Add(newPictureBox); }));
            }
            else
            {
                panel.Controls.Add(newPictureBox);
            }
        }

        #region Element

        private void BlockElement(bool flag)
        {
            //panelImage
            if (panelImage.InvokeRequired)
            {
                panelImage.Invoke(new MethodInvoker(delegate { panelImage.Enabled = flag; }));
            }
            else
            {
                panelImage.Enabled = flag;
            }

            //panelColor
            if (panelColor.InvokeRequired)
            {
                panelColor.Invoke(new MethodInvoker(delegate { panelColor.Enabled = flag; }));
            }
            else
            {
                panelColor.Enabled = flag;
            }

            //buttonGetHardDisk
            if (buttonGetHardDisk.InvokeRequired)
            {
                buttonGetHardDisk.Invoke(new MethodInvoker(delegate { buttonGetHardDisk.Enabled = flag; }));
            }
            else
            {
                buttonGetHardDisk.Enabled = flag;
            }

            //UserName
            if (UserName.InvokeRequired)
            {
                UserName.Invoke(new MethodInvoker(delegate { UserName.Enabled = flag; }));
            }
            else
            {
                UserName.Enabled = flag;
            }

            //numericImage
            if (numericImage.InvokeRequired)
            {
                numericImage.Invoke(new MethodInvoker(delegate { numericImage.Enabled = flag; }));
            }
            else
            {
                numericImage.Enabled = flag;
            }

            //buttonGetImage
            if (buttonGetImage.InvokeRequired)
            {
                buttonGetImage.Invoke(new MethodInvoker(delegate { buttonGetImage.Enabled = flag; }));
            }
            else
            {
                buttonGetImage.Enabled = flag;
            }

            //buttonCalculateColors
            if (buttonCalculateColors.InvokeRequired)
            {
                buttonCalculateColors.Invoke(new MethodInvoker(delegate { buttonCalculateColors.Enabled = flag; }));
            }
            else
            {
                buttonCalculateColors.Enabled = flag;
            }
        }

        private void OutputProgress(string text)
        {
            if (labelProgress.InvokeRequired)
            {
                labelProgress.Invoke(new MethodInvoker(delegate { labelProgress.Text = text; }));
            }
            else
            {
                labelProgress.Text = text;
            }
        }

        #endregion

        #region Panel

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

        private void PanelImage_Scroll(object sender, ScrollEventArgs e)
        {
            var scroll = e.OldValue - e.NewValue;
            panelColor.AutoScrollPosition = new Point(panelImage.HorizontalScroll.Value, panelImage.VerticalScroll.Value - scroll);
            panelImage.AutoScrollPosition = new Point(panelImage.HorizontalScroll.Value, panelImage.VerticalScroll.Value - scroll);
        }

        private void PanelColor_Scroll(object sender, ScrollEventArgs e)
        {
            var scroll = e.OldValue - e.NewValue;
            panelImage.AutoScrollPosition = new Point(panelColor.HorizontalScroll.Value, panelColor.VerticalScroll.Value - scroll);
            panelColor.AutoScrollPosition = new Point(panelColor.HorizontalScroll.Value, panelColor.VerticalScroll.Value - scroll);
        }

        #endregion

        private List<Bitmap> _bitmapList;
        private List<Bitmap> _colorImage;

        private InstagramClient _instagramClient;

        private object _locker = new object();
    }
}
