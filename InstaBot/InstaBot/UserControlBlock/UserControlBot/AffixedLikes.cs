using Extensions;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TestDataService.Data.UserActivitySection;

namespace InstaBot
{
    public partial class AffixedLikes : UserControl
    {
        public AffixedLikes()
        {
            InitializeComponent();

            affixedLikesUsersList = new List<AffixedLikesUser>();
            ControlExtensions.DoubleBuffering(AffixedLikesListView, true);
        }

        public void DisplayOnTheScreenUserList(AffixedLikesUser affixedLikesUser)
        {
            affixedLikesUsersList.Add(affixedLikesUser);

            if (AffixedLikesListView.InvokeRequired)
            {
                AffixedLikesListView.Invoke(new MethodInvoker(delegate
                {
                    AffixedLikesListView.Items.Add(new ListViewItem(new string[]
                    {
                        affixedLikesUser?.UserName, affixedLikesUser?.UrlMedia, affixedLikesUser?.Text
                    }));
                }));
            }
            else
            {
                AffixedLikesListView.Items.Add(new ListViewItem(new string[]
                {
                    affixedLikesUser?.UserName, affixedLikesUser?.UrlMedia, affixedLikesUser?.Text
                }));
            }
        }

        public void Clear()
        {
            if (AffixedLikesListView.InvokeRequired)
            {
                AffixedLikesListView.Invoke(new MethodInvoker(delegate { AffixedLikesListView.Items.Clear(); }));
            }
            else
            {
                AffixedLikesListView.Items.Clear();
            }

            AffixedLikesListView.Items.Clear();
            affixedLikesUsersList.Clear();
        }

        public void SetNumberLikesDayLabel(int numberLikesDay)
        {
            if (labelNumberLikePlaced.InvokeRequired)
            {
                labelNumberLikePlaced.Invoke(new MethodInvoker(delegate { labelNumberLikePlaced.Text = "Number of likes placed:" + numberLikesDay; }));
            }
            else
            {
                labelNumberLikePlaced.Text = "Number of likes placed:" + numberLikesDay;
            }
        }

        private void OpenUserButton_Click(object sender, EventArgs e)
        {
            if (AffixedLikesListView.SelectedIndices.Count > 0)
            {
                var subItemText = AffixedLikesListView.SelectedItems[0].SubItems[0].Text;

                if (!string.IsNullOrEmpty(subItemText))
                {
                    Browser.Open("https://www.instagram.com/" + subItemText);
                }
            }
        }

        private void OpenMediaButton_Click(object sender, System.EventArgs e)
        {
            if (AffixedLikesListView.SelectedIndices.Count > 0)
            {
                var subItemText = AffixedLikesListView.SelectedItems[0].SubItems[1].Text;

                Browser.Open(subItemText);
            }
        }

        private List<AffixedLikesUser> affixedLikesUsersList;
    }
}
