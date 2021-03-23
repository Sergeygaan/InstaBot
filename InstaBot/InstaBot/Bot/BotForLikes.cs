﻿using Newtonsoft.Json;
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
using TestDataService.Extensions;

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

            followersList.InitializationFollowersList(_usersList, "ListOfSharedUsers");

            GetTextFile(_numberLikesDayFileName);
            SetNumberLikesDayLabel();
        }

        private async void StartButton_Click(object sender, EventArgs e)
        {
            try
            {
                ButtonControl(false);

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

                if (_numberLikesDay >= 200)
                {
                    GetTextLog("Достигнут лимит лайков на день");
                    GetTextLog($"Конец");

                    return;
                }

                var userMediaList = await _instagramClient.GetUserMedia(instagramUser.UserName, 1);
                var instaMediaForInstaUser = userMediaList?.Value;

                if (instaMediaForInstaUser != null && instaMediaForInstaUser.Any() && instaMediaForInstaUser.Count >= 2)
                {
                    foreach (var currentMedia in instaMediaForInstaUser.ToList().Take(2))
                    {
                        var likeMedia = _instagramClient.LikeMedia(currentMedia.InstaIdentifier).Result.Value;

                        if (likeMedia)
                        {
                            GetTextLog($"Запись: https://www.instagram.com/p/{currentMedia.Code} Пользователь = {instagramUser.UserName}");

                            instagramUser.LikeSet = true;
                            _saveUsersList = false;

                            followersList.DisplayOnTheScreenUserList(_usersList);

                            Thread.Sleep(_rand.Next(90000, 150000));
                        }
                    }
                }
                else
                {
                    instagramUser.LikeSet = true;
                    _saveUsersList = false;

                    followersList.DisplayOnTheScreenUserList(_usersList);
                    GetTextLog($"У пользователя {instagramUser.UserName} нет публикаций");

                    _numberLikesDay--;
                }

                _numberLikesDay++;
                SetNumberLikesDayLabel();

                Thread.Sleep(_rand.Next(5000, 25000));
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

            SaveFileText(_fileName, text);
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
        }

        private void BotForLikes_FormClosing(object sender, FormClosingEventArgs e)
        {
            _cts.Cancel();

            if (_currentLikesDay != _numberLikesDay)
            {
                SaveFileText(_numberLikesDayFileName, _numberLikesDay.ToString());
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
                    followersList.SaveButton_Click(new object(), new EventArgs());
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

        #region File

        private void SaveFileText(string fileName, string text)
        {
            FileHelper.SaveText(fileName, text);
        }

        private void GetTextFile(string fileName)
        {
            _numberLikesDay = FileHelper.LoadText(fileName);
            _currentLikesDay = _numberLikesDay;

            SaveFileText(fileName, _numberLikesDay.ToString());
        }

        #endregion

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
