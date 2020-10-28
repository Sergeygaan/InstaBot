using ColorProfileForm;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using TestDataService;

namespace InstaBot
{
    public partial class InstaBot : Form
    {
        public InstaBot()
        {
            InitializeComponent();

            _instagramClient = new InstagramClient();
        }

        #region User

        private void BtnAccountLogin_Click(object sender, EventArgs e)
        {
            // var login = _instagramClient.Login(txtAccountUsername.Text, txtAccountPassword.Text);
            
            lblAccountLoginStatus.Text = @"Status: Attempting to log in.";
            if (login)
            {
                lblAccountLoginStatus.Text = @"Status: Logged in.";
                lblAccountLoginStatus.ForeColor = Color.Green;
                // Log($@"Successfully logged in as {txtAccountUsername.Text}.", nameof(LogType.Success));
            }
            else
            {
                lblAccountLoginStatus.Text = @"Status: Failed to log in.";
                lblAccountLoginStatus.ForeColor = Color.Red;
                // Log($@"Failed to log in as {txtAccountUsername.Text}. Message: {login.Info.Message}", nameof(LogType.Fail));

                btnAccountLogin.Enabled = true;
                return;
            }

            btnAccountLogin.Enabled = false;
            btnAccountLogout.Enabled = true;

            var userFollowers = _instagramClient.GetUserFollowers();
            var userMedia = _instagramClient.GetUserMedia(userFollowers.Value[10].UserName);
            //var media = userMedia.Value.First();
            //_instagramClient.UnLikeMedia(media.InstaIdentifier);
            //_instagramClient.LikeMedia(media.InstaIdentifier);
        }

        private void BtnAccountLogout_Click(object sender, EventArgs e)
        {
            var logout = _instagramClient.Logout();
            btnAccountLogout.Enabled = false;
            if (logout.Succeeded)
            {
                lblAccountLoginStatus.Text = @"Status: Successfully logged out.";
                lblAccountLoginStatus.ForeColor = Color.DodgerBlue;
                // Log($@"Successfully logged out as {txtAccountUsername.Text}.", nameof(LogType.Fail));
                txtAccountUsername.Clear();
                txtAccountPassword.Clear();
            }
            else
            {
                lblAccountLoginStatus.Text = @"Status: Failed to log out.";
                Thread.Sleep(5000);
                lblAccountLoginStatus.Text = @"Status: Successfully logged in.";
                lblAccountLoginStatus.ForeColor = Color.Green;
            }

            btnAccountLogin.Enabled = true;
        }

        #endregion

        #region ColorProfile

        private void ButtonColorProfile_Click(object sender, EventArgs e)
        {
            using (var colorProfile = new ColorProfile(_instagramClient))
            {
                colorProfile.ShowDialog();
            }
        }

        #endregion

        private InstagramClient _instagramClient;
    }
}
