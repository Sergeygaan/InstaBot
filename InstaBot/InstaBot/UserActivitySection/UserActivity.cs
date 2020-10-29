using InstaSharper.Classes.Models;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TestDataService;
using TestDataService.Data.UserActivitySection;

namespace InstaBot.UserActivitySection
{
    public partial class UserActivity : Form
    {
        public UserActivity(InstagramClient instagramClient)
        {
            InitializeComponent();

            _instagramClient = instagramClient;
            _mediaLikerList = new List<MediaLiker>();
            _userFollowersList = new List<InstaUserShort>();
        }

        private async void ButtonStartAnalysis_Click(object sender, System.EventArgs e)
        {
            var userFollowers = await _instagramClient.GetUserFollowers("gaansia");
            _userFollowersList.AddRange(userFollowers.Value);

            var userMediaList = await _instagramClient.GetUserMedia("gaansia", (int)numericImage.Value / 18);

            foreach(var media in userMediaList.Value)
            {
                var mediaLikers = await _instagramClient.GetMediaLikers(media.InstaIdentifier);

                var mediaLiker = new MediaLiker
                {
                    InstaIdentifier = media.InstaIdentifier,
                    InstaLikersList = mediaLikers.Value
                };

                if (media.Images != null && media.Images.Any())
                {
                    mediaLiker.URI = media.Images.First().URI;
                }
                else if (media.Carousel != null && media.Carousel.Any())
                {
                    mediaLiker.URI = media.Carousel.First().Images.First().URI;
                }

                _mediaLikerList.Add(mediaLiker);
            }
        }

        private List<MediaLiker> _mediaLikerList;
        private List<InstaUserShort> _userFollowersList;

        private InstagramClient _instagramClient;
    }
}
