using InstaSharper.Classes;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestDataService;
using InstaBot.ColorProfilesSection;
using InstaBot.UserActivitySection;
using InstaBot.Bot;

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

        private async void BtnAccountLogin_Click(object sender, EventArgs e)
        {
            bool loginFlag = false;

            lblAccountLoginStatus.Text = @"Status: Attempting to log in.";

            var login = await _instagramClient.Login(txtAccountUsername.Text, txtAccountPassword.Text);
            // var login = await _instagramClient.Login(Data.Name1, Data.Password1);

            if(login.Succeeded)
            {
                loginFlag = true;
            }
            else if(login.Value == InstaLoginResult.TwoFactorRequired)
            {
                textBoxTwoFactor.Enabled = true;
                buttonTwoFactor.Enabled = true;
            }
            else if (login.Value == InstaLoginResult.ChallengeRequired)
            {
                var challengeRequireVerify = await _instagramClient.ChallengeRequireVerify();

                if (challengeRequireVerify.Succeeded)
                {
                    loginFlag = true;
                }
            }

            EnableElementLogin(loginFlag);
        }

        private async void ButtonTwoFactor_Click(object sender, EventArgs e)
        {
            bool loginFlag = false;

            var twoFactorLogin = await _instagramClient.TwoFactorLogin(textBoxTwoFactor.Text);

            textBoxTwoFactor.Enabled = false;
            buttonTwoFactor.Enabled = false;

            if (twoFactorLogin.Succeeded)
            {
                loginFlag = true;
            }
            else if (twoFactorLogin.Value == InstaLoginTwoFactorResult.ChallengeRequired)
            {
                var challengeRequireVerify = await _instagramClient.ChallengeRequireVerify();

                if (challengeRequireVerify.Succeeded)
                {
                    loginFlag = true;
                }
            }

            EnableElementLogin(loginFlag);
        }

        private async void BtnAccountLogout_Click(object sender, EventArgs e)
        {
            var logout = await _instagramClient.Logout();
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
                await Task.Delay(5000);
                lblAccountLoginStatus.Text = @"Status: Successfully logged in.";
                lblAccountLoginStatus.ForeColor = Color.Green;
            }

            btnAccountLogin.Enabled = true;
        }

        private void EnableElementLogin(bool loginFlag)
        {
            if (loginFlag)
            {
                lblAccountLoginStatus.Text = @"Status: Logged in.";
                lblAccountLoginStatus.ForeColor = Color.Green;
                // Log($@"Successfully logged in as {txtAccountUsername.Text}.", nameof(LogType.Success));

                btnAccountLogin.Enabled = false;
                btnAccountLogout.Enabled = true;

                // var userFollowers = _instagramClient.GetUserFollowers();
                // var userMedia = _instagramClient.GetUserMedia(Data.Name1);
                //var media = userMedia.Value.First();
                //_instagramClient.UnLikeMedia(media.InstaIdentifier);
                //_instagramClient.LikeMedia(media.InstaIdentifier);
            }
            else
            {
                lblAccountLoginStatus.Text = @"Status: Failed to log in.";
                lblAccountLoginStatus.ForeColor = Color.Red;
                // Log($@"Failed to log in as {txtAccountUsername.Text}. Message: {login.Info.Message}", nameof(LogType.Fail));

                btnAccountLogin.Enabled = true;
                btnAccountLogout.Enabled = false;
            }
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

        #region UserActivity

        private void buttonUserActivity_Click(object sender, EventArgs e)
        {
            using (var userActivity = new UserActivity(_instagramClient))
            {
                userActivity.ShowDialog();
            }
        }

        #endregion

        #region BotForLikes

        private void BotForLikesButton_Click(object sender, EventArgs e)
        {
            using (var botForLikes = new BotForLikes(_instagramClient))
            {
                botForLikes.ShowDialog();
            }
        }

        #endregion

        private InstagramClient _instagramClient;
    }
}
