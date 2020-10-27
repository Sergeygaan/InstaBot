using InstaSharper.Classes.Models;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;

namespace Extensions
{
    public static class DownloadFile
    {
        public static List<Bitmap> DownloadImage(InstaMediaList instaMediaList)
        {
            List<Bitmap> instagramImage = new List<Bitmap>();

            foreach (var instaMedia in instaMediaList)
            {
                string requestUriString = null;

                if (instaMedia.Images != null && instaMedia.Images.Any())
                {
                    requestUriString = instaMedia.Images.First().URI;
                }
                else if(instaMedia.Carousel != null && instaMedia.Carousel.Any())
                {
                    requestUriString = instaMedia.Carousel.First().Images.First().URI;
                }

                var request = WebRequest.Create(requestUriString);
                var response = request.GetResponse();
                var responseStream = response.GetResponseStream();

                instagramImage.Add(new Bitmap(responseStream));
            }

            return instagramImage;
        }
    }
}
