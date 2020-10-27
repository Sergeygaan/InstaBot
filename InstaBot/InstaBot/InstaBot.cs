using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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
            var login = _instagramClient.Login(txtAccountUsername.Text, txtAccountPassword.Text);
 
            lblAccountLoginStatus.Text = @"Status: Attempting to log in.";
            if (login.Succeeded)
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
            var a = _instagramClient.GetUserMedia();
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

        private InstagramClient _instagramClient;
    }
}
