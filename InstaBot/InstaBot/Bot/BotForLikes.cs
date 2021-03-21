using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestDataService;
using TestDataService.Data.UserActivitySection;

namespace InstaBot.Bot
{
    public partial class BotForLikes : Form
    {
        public BotForLikes(InstagramClient instagramClient)
        {
            InitializeComponent();

            _instagramClient = instagramClient;

            _rand = new Random();
            _usersList = new List<InstagramUser>();
        }

        private void LoadActiveFollowersButton_Click(object sender, EventArgs e)
        {
            var open_dialog = new OpenFileDialog
            {
                Filter = "Image Files(*.txt;)|*.txt|All files (*.*)|*.*",
                Multiselect = false
            };
            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamReader stream = new StreamReader(open_dialog.FileName))
                    {
                        _usersList = JsonConvert.DeserializeObject<List<InstagramUser>>(stream.ReadToEnd());
                    }
                }
                catch { }
            }

            GetItemListBox(ActiveFollowersUserslistBox, _usersList);
        }

        private void GetItemListBox(ListBox listBox, List<InstagramUser> instagramUserList)
        {
            var resultsList = instagramUserList.OrderByDescending(u => u.NumberLikes).ToList();

            foreach (var instagramUser in resultsList)
            {
                listBox.Items.Add($"Profile = {instagramUser.UserName},  likes = {instagramUser.NumberLikes}");
            }
        }

        private async void StartButton_Click(object sender, EventArgs e)
        {
            await Task.Run(() => SetLikes());
        }

        private async void SetLikes()
        {
            if (LogListBox.InvokeRequired)
            {
                LogListBox.Invoke(new MethodInvoker(delegate { LogListBox.Items.Clear(); }));
            }
            else
            {
                LogListBox.Items.Clear();
            }

            var resultsList = _usersList.OrderByDescending(u => u.NumberLikes).ToList();

            foreach (var instagramUser in resultsList)
            {
                Thread.Sleep(_rand.Next(1000, 5000));

                var userMediaList = await _instagramClient.GetUserMedia(instagramUser.UserName, 1);
                var instaMediaForInstaUser = userMediaList?.Value;

                if (instaMediaForInstaUser.Any() && instaMediaForInstaUser.Count >= 3)
                {
                    foreach (var currentMedia in instaMediaForInstaUser.ToList().Take(3))
                    {
                        Thread.Sleep(_rand.Next(1000, 15000));

                        var likeMedia = _instagramClient.LikeMedia(currentMedia.InstaIdentifier).Result.Value;

                        if (likeMedia)
                        {
                            GetTextLog($"Поставили лайк записи {currentMedia.Code} пользователю: {instagramUser.UserName}");
                        }
                    }
                }
                else
                {
                    GetTextLog($"У пользователя {instagramUser.UserName} нет публикаций");
                }
            }
        }

        private void GetTextLog(string text)
        {
            if (LogListBox.InvokeRequired)
            {
                LogListBox.Invoke(new MethodInvoker(delegate { LogListBox.Items.Add(text); }));
            }
            else
            {
                LogListBox.Items.Add(text);
            }
        }

        private InstagramClient _instagramClient;

        private List<InstagramUser> _usersList;

        private readonly Random _rand;
    }
}
