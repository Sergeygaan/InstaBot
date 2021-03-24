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

        private void OpenMediaButton_Click(object sender, System.EventArgs e)
        {
            if (AffixedLikesListView.SelectedIndices.Count > 0)
            {
                var subItemText = AffixedLikesListView.SelectedItems[0].SubItems[1].Text;

                if(!string.IsNullOrEmpty(subItemText))
                {
                    try
                    {
                        System.Diagnostics.Process.Start("chrome", subItemText + "--new-window --start-fullscreen");
                    }
                    catch
                    {
                        try
                        {
                            System.Diagnostics.Process.Start("firefox", "-new-window" + subItemText);
                        }
                        catch (Exception exception)
                        {
                            MessageBox.Show(exception.Message);
                        }
                    }
                }
            }
        }

        private List<AffixedLikesUser> affixedLikesUsersList;
    }
}
