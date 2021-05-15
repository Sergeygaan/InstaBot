using System;
using System.Windows.Forms;

namespace Extensions
{
    public static class Browser
    {
        public static void Open(string subItemText)
        {
            if (!string.IsNullOrEmpty(subItemText))
            {
                try
                {
                    System.Diagnostics.Process.Start("chrome", subItemText + " --new-window --start-fullscreen");
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
}
