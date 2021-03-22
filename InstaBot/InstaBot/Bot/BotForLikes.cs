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
            _cts = new CancellationTokenSource();
            _token = _cts.Token;

            GetTextFile(_numberLikesDayFileName);
            SetNumberLikesDayLabel();
        }

        #region File

        private void SaveActiveFollowersButton_Click(object sender, EventArgs e)
        {
            var saveDialog = new SaveFileDialog
            {
                Filter = "Image Files(.txt)|*.txt|All files (*.*)|*.*",
                FileName = "ActiveFollowersUsersList_" + DateTime.Now.ToString("yyyy-MM-dd_HH_mm_ss") + ".txt"
            };
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter file = File.CreateText(saveDialog.FileName))
                {
                    var resultsList = _usersList.OrderByDescending(u => u.NumberLikes).ToList();

                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(file, resultsList);

                    _saveUsersList = true;
                }
            }
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

        #endregion

        private void GetItemListBox(ListBox listBox, List<InstagramUser> instagramUserList)
        {
            if (listBox.InvokeRequired)
            {
                listBox.Invoke(new MethodInvoker(delegate { listBox.Items.Clear(); }));
            }
            else
            {
                listBox.Items.Clear();
            }

            var resultsList = instagramUserList.OrderByDescending(u => u.NumberLikes).ToList();
            labelActiveFollowers.Text = "Count: " + resultsList.Count.ToString();

            foreach (var instagramUser in resultsList)
            {
                if (listBox.InvokeRequired)
                {
                    listBox.Invoke(new MethodInvoker(delegate { listBox.Items.Add($"Profile = {instagramUser.UserName},  likes = {instagramUser.NumberLikes}, like set = {instagramUser.LikeSet}"); }));
                }
                else
                {
                    listBox.Items.Add($"Profile = {instagramUser.UserName},  likes = {instagramUser.NumberLikes}, like set = {instagramUser.LikeSet}");
                }
            }
        }

        private async void StartButton_Click(object sender, EventArgs e)
        {
            try
            {
                ButtonControl(true);

                await Task.Run(() => SetLikes(_token));
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                ButtonControl(true);
            }
        }

        private async void SetLikes(CancellationToken token)
        {
            File.Delete(Directory.GetCurrentDirectory() + $"/{_fileName}");
            if (LogListBox.InvokeRequired)
            {
                LogListBox.Invoke(new MethodInvoker(delegate { LogListBox.Items.Clear(); }));
            }
            else
            {
                LogListBox.Items.Clear();
            }

            GetTextLog($"Начало");

            if (token.IsCancellationRequested)
            {
                return;
            }

            var resultsList = _usersList.OrderByDescending(u => u.NumberLikes).ToList();

            foreach (var instagramUser in resultsList)
            {
                if (instagramUser.LikeSet)
                {
                    GetTextLog($"Пользователю = {instagramUser.UserName} уже был поставлен лайк");
                    continue;
                }

                if (_numberLikesDay >= 100)
                {
                    GetTextLog("Достигнут лимит лайков на день");
                    GetTextLog($"Конец");

                    return;
                }

                Thread.Sleep(_rand.Next(5000, 25000));

                var userMediaList = await _instagramClient.GetUserMedia(instagramUser.UserName, 1);
                var instaMediaForInstaUser = userMediaList?.Value;

                if (instaMediaForInstaUser.Any() && instaMediaForInstaUser.Count >= 2)
                {
                    foreach (var currentMedia in instaMediaForInstaUser.ToList().Take(2))
                    {
                        Thread.Sleep(_rand.Next(30000, 60000));

                        var likeMedia = _instagramClient.LikeMedia(currentMedia.InstaIdentifier).Result.Value;

                        if (likeMedia)
                        {
                            GetTextLog($"Запись: https://www.instagram.com/p/{currentMedia.Code} Пользователь = {instagramUser.UserName}");

                            instagramUser.LikeSet = true;
                            _saveUsersList = false;

                            GetItemListBox(ActiveFollowersUserslistBox, _usersList);
                        }
                    }
                }
                else
                {
                    instagramUser.LikeSet = true;
                    _saveUsersList = false;

                    GetItemListBox(ActiveFollowersUserslistBox, _usersList);
                    GetTextLog($"У пользователя {instagramUser.UserName} нет публикаций");
                }

                _numberLikesDay++;
                SetNumberLikesDayLabel();
            }

            GetTextLog($"Конец");
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

            SetTextFile(_fileName, text);
        }

        private void ButtonControl(bool flag)
        {
            if (StartButton.InvokeRequired)
            {
                StartButton.Invoke(new MethodInvoker(delegate { StartButton.Enabled = flag; }));
            }
            else
            {
                StartButton.Enabled = flag;
            }

            if (LoadActiveFollowersButton.InvokeRequired)
            {
                LoadActiveFollowersButton.Invoke(new MethodInvoker(delegate { LoadActiveFollowersButton.Enabled = flag; }));
            }
            else
            {
                LoadActiveFollowersButton.Enabled = flag;
            }
        }

        private void SetTextFile(string fileName, string text)
        {
            using (var file = new StreamWriter(Directory.GetCurrentDirectory() + $"/{fileName}", true))
            {
                file.WriteLine(DateTime.Now.ToString("yyyy-MM-dd") + ": " + text);
            }
        }

        private void GetTextFile(string fileName)
        {
            if(File.Exists(Directory.GetCurrentDirectory() + $"/{fileName}"))
            {
                var lines = File.ReadAllLines(Directory.GetCurrentDirectory() + $"/{fileName}");

                if(!lines.Any())
                {
                    SetTextFile(fileName, "0");
                    _numberLikesDay = 0;

                    return;
                }

                char[] charsToTrim = { ' ' };

                foreach (var line in lines)
                {
                    var arrayLine = line.Trim(charsToTrim).Split(':');

                    if (arrayLine[0] == DateTime.Now.ToString("yyyy-MM-dd"))
                    {
                        var numberLikes = short.Parse(arrayLine[1]);
                        if(numberLikes > _numberLikesDay)
                        {
                            _numberLikesDay = numberLikes;
                            _currentLikesDay = numberLikes;
                        }
                    }
                }
            }
            else
            {
                SetTextFile(fileName, "0");
                _numberLikesDay = 0;
            }
        }

        private void BotForLikes_FormClosing(object sender, FormClosingEventArgs e)
        {
            _cts.Cancel();

            if (_currentLikesDay != _numberLikesDay)
            {
                SetTextFile(_numberLikesDayFileName, _numberLikesDay.ToString());
            }

            if(!_saveUsersList)
            {
                var result = MessageBox.Show(
                    "The list of users has been updated. Update the list in the file?", 
                    "Updating data",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    SaveActiveFollowersButton_Click(new object(), new EventArgs());
                }
            }
        }

        private void SetNumberLikesDayLabel()
        {
            if (StartButton.InvokeRequired)
            {
                StartButton.Invoke(new MethodInvoker(delegate { labelNumberLikePlaced.Text = "Number of likes placed:" + _numberLikesDay; }));
            }
            else
            {
                labelNumberLikePlaced.Text = "Number of likes placed:" + _numberLikesDay;
            }
        }


        private InstagramClient _instagramClient;

        private List<InstagramUser> _usersList;

        private readonly Random _rand;

        private readonly string _fileName = "LogFile.txt";

        private readonly string _numberLikesDayFileName = "NumberLikesDay.txt";

        private int _numberLikesDay = 0;

        private int _currentLikesDay = 0;

        private bool _saveUsersList = true;

        private CancellationTokenSource _cts;

        private CancellationToken _token;
    }
}
