using Extensions;
using InstaSharper.Classes;
using InstaSharper.Classes.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
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

            _activeFollowersUsersList = new List<InstagramUser>();
            _activeNotFollowersUsersList = new List<InstagramUser>();
            _notActiveFollowersUsersList = new List<InstagramUser>();
            _notActiveBotFollowersUsersList = new List<InstagramUser>();

        }

        private async void ButtonStartAnalysis_Click(object sender, System.EventArgs e)
        {
            _mediaLikerList.Clear();
            _userFollowersList.Clear();
            _activeFollowersUsersList.Clear();
            _activeNotFollowersUsersList.Clear();
            _notActiveFollowersUsersList.Clear();
            _notActiveBotFollowersUsersList.Clear();

            var result = await GetDataInstagram();

            if (result)
            {
                await Task.Run(() => UserAnalysis());
            }
            else
            {
                // ошибка
            }
        }

        private async Task<bool> GetDataInstagram()
        {
            var userFollowers = await _instagramClient.GetUserFollowers("gaansia");
            _userFollowersList.AddRange(userFollowers.Value);

            var userMediaList = await _instagramClient.GetUserMedia("gaansia", (int)numericImage.Value / 18);

            foreach (var media in userMediaList.Value)
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

            return _userFollowersList.Count != 0 && _mediaLikerList.Count != 0;
        }

        private void UserAnalysis()
        {
            foreach(var mediaLiker in _mediaLikerList)
            {
                foreach (var instaLikers in mediaLiker.InstaLikersList)
                {
                    var user = _userFollowersList.Find(item => item.UserName == instaLikers.UserName);

                    if(user != null)
                    {
                        _activeFollowersUsersList.Add(new InstagramUser
                        {
                            UserName = user.UserName,
                            ProfilePicture = user.ProfilePicture,
                        });
                        // добавляем в список  активных
                    }
                    else
                    {
                        _activeNotFollowersUsersList.Add(new InstagramUser
                        {
                            UserName = instaLikers.UserName,
                            ProfilePicture = instaLikers.ProfilePicture,
                        });
                        // список активных не подписчиков
                    }

                    // взять список всех и удалить из него список активных подписанных


                    // выделить ботов( по критериям) 
                }
            }

            var g = _activeFollowersUsersList.CountingDuplicates();
            var g1 = _activeNotFollowersUsersList.CountingDuplicates();
        }

        private List<MediaLiker> _mediaLikerList;
        private List<InstaUserShort> _userFollowersList;

        private List<InstagramUser> _activeFollowersUsersList;
        private List<InstagramUser> _activeNotFollowersUsersList;

        private List<InstagramUser> _notActiveFollowersUsersList;
        private List<InstagramUser> _notActiveBotFollowersUsersList;

        private InstagramClient _instagramClient;
    }
}
