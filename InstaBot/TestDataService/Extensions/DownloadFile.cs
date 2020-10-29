using System.Drawing;
using System.Net;

namespace Extensions
{
    public static class DownloadFile
    {
        public static Bitmap DownloadImage(string requestUriString)
        {
            var request = WebRequest.Create(requestUriString);
            var response = request.GetResponse();
            var responseStream = response.GetResponseStream();

            return new Bitmap(responseStream);
        }
    }
}
