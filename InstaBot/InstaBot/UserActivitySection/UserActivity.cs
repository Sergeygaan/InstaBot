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
                var result1 = await UserAnalysis();
            }
            else
            {
                // ошибка
            }
        }

        private async Task<bool> GetDataInstagram()
        {
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

            var userFollowers = await _instagramClient.GetUserFollowers("gaansia");
            _userFollowersList.AddRange(userFollowers.Value);

            return _userFollowersList.Count != 0 && _mediaLikerList.Count != 0;
        }

        private async Task<bool> UserAnalysis()
        {
            List<InstagramUser> notActiveFollowersList = new List<InstagramUser>();

            foreach (var mediaLiker in _mediaLikerList)
            {
                foreach (var instaLikers in mediaLiker.InstaLikersList)
                {
                    var user = _userFollowersList.Find(item => item.UserName == instaLikers.UserName);

                    if (user != null)
                    {
                        // добавляем в список  активных
                        var activeFollowersUser = _activeFollowersUsersList.Find(_ => _.UserName == user.UserName);
                        if (activeFollowersUser == null)
                        {
                            _activeFollowersUsersList.Add(new InstagramUser
                            {
                                UserName = user.UserName,
                                InstaUserShort = user,
                                NumberLikes = 1
                            });
                        }
                        else
                        {
                            activeFollowersUser.NumberLikes += 1;
                        }
                    }
                    else
                    {
                        // список активных не подписчиков
                        var activeNotFollowersUser = _activeNotFollowersUsersList.Find(_ => _.UserName == instaLikers.UserName);
                        if (activeNotFollowersUser == null)
                        {
                            _activeNotFollowersUsersList.Add(new InstagramUser
                            {
                                UserName = instaLikers.UserName,
                                InstaUserShort = instaLikers,
                                NumberLikes = 1
                            });
                        }
                        else
                        {
                            activeNotFollowersUser.NumberLikes += 1;
                        }
                    }

                    // взять список всех и удалить из него список активных подписанных


                    // выделить ботов( по критериям) 
                }
            }

            foreach (var userFollower in _userFollowersList)
            {
                var userOnTheList = _activeFollowersUsersList.Find(item => item.UserName == userFollower.UserName);

                if(userOnTheList == null)
                {
                    notActiveFollowersList.Add(new InstagramUser
                    {
                        UserName = userFollower.UserName,
                        InstaUserShort = userFollower
                    });
                }
            }

            foreach (var notActiveFollowers in notActiveFollowersList)
            {
                var user = await _instagramClient.GetUserInfoById(notActiveFollowers.InstaUserShort.Pk);

                var instaUser = user.Value;

                // Проверка  подписок
                if (instaUser.FollowingCount > 1000 || instaUser.MediaCount < 5)
                {
                    _notActiveBotFollowersUsersList.Add(new InstagramUser
                    {
                        UserName = instaUser.Username,
                        InstaUserInfo = instaUser
                    });

                    continue;
                }

                var userMediaList = await _instagramClient.GetUserMedia(instaUser.Username, 1);
                var instaMediaForInstaUser = userMediaList?.Value?.First();

                if (instaMediaForInstaUser != null)
                {
                    // Проверка времени последней публикации
                    if (instaMediaForInstaUser.TakenAt < DateTime.Now.AddDays(180))
                    {
                        _notActiveBotFollowersUsersList.Add(new InstagramUser
                        {
                            UserName = instaUser.Username,
                            InstaUserInfo = instaUser
                        });

                        continue;
                    }
                }

                _notActiveFollowersUsersList.Add(new InstagramUser
                {
                    UserName = instaUser.Username,
                    InstaUserInfo = instaUser
                });
            }
            // await Task.Run(() => CheckBotUser(notActiveFollowersList));

            return true;
        }

        private async void CheckBotUser(List<InstagramUser> notActiveFollowersList)
        {
            foreach (var notActiveFollowers in notActiveFollowersList)
            {
                var user = await _instagramClient.GetUserInfoById(notActiveFollowers.InstaUserShort.Pk);

                var instaUser = user.Value;

                // Проверка  подписок
                if (instaUser.FollowingCount > 1000)
                {
                    _notActiveBotFollowersUsersList.Add(new InstagramUser
                    {
                        UserName = instaUser.Username,
                        InstaUserInfo = instaUser
                    });

                    break;
                }

                var userMediaList = await _instagramClient.GetUserMedia(instaUser.Username, 1);
                var instaMediaForInstaUser = userMediaList?.Value?.First();

                if (instaMediaForInstaUser != null)
                {
                    // Проверка времени последней публикации
                    if (instaMediaForInstaUser.TakenAt < DateTime.Now.AddDays(180))
                    {
                        _notActiveBotFollowersUsersList.Add(new InstagramUser
                        {
                            UserName = instaUser.Username,
                            InstaUserInfo = instaUser
                        });

                        break;
                    }
                }

                _notActiveFollowersUsersList.Add(new InstagramUser
                {
                    UserName = instaUser.Username,
                    InstaUserInfo = instaUser
                });
            }
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
