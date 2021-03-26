using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TestDataService.Extensions;
using TestDataService.Data.UserActivitySection;
using System.Linq;

namespace InstaBot
{
    public partial class FollowersList : UserControl
    {
        public FollowersList()
        {
            InitializeComponent();
        }

        public void InitializationFollowersList(
            List<InstagramUser> usersList,
            string nameFollowersList)
        {
            _usersList = usersList;
            _nameFollowersList = nameFollowersList;
        }

        public void SaveButton_Click(object sender, EventArgs e)
        {
            FileHelper.SaveJson(_usersList, _nameFollowersList);
        }

        public void LoadButton_Click(object sender, EventArgs e)
        {
            _usersList.Clear();

            var usersList = FileHelper.LoadJson();

            if (usersList != null)
            {
                _usersList.AddRange(usersList);
            }

            DisplayOnTheScreenUserList(_usersList);
        }

        public void DisplayOnTheScreenUserList(List<InstagramUser> usersList)
        {
            Clear();

            var resultsList = usersList.OrderByDescending(u => u.NumberLikes).ToList();
            CountLabel.Text = "Count: " + resultsList.Count.ToString();

            foreach (var instagramUser in resultsList)
            {
                if (UserListView.InvokeRequired)
                {
                    UserListView.Invoke(new MethodInvoker(delegate 
                    {
                        UserListView.Items.Add(new ListViewItem(new string[]
                        {
                            instagramUser.UserName, instagramUser.NumberLikes.ToString(), instagramUser.LikeSet.ToString()
                        }));
                    }));
                }
                else
                {
                    UserListView.Items.Add(new ListViewItem(new string[]
                    {
                        instagramUser.UserName, instagramUser.NumberLikes.ToString(), instagramUser.LikeSet.ToString()
                    }));
                }
            }
        }

        public void Clear()
        {
            if (UserListView.InvokeRequired)
            {
                UserListView.Invoke(new MethodInvoker(delegate 
                {
                    _usersList.Clear();
                    CountLabel.Text = "Count: 0";
                    UserListView.Items.Clear();
                } ));
            }
            else
            {
                CountLabel.Text = "Count: 0";
                UserListView.Items.Clear();
            }
        }

        private List<InstagramUser> _usersList;

        private string _nameFollowersList;
    }
}
