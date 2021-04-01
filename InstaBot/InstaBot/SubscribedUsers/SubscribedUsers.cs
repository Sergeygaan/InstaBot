using InstaSharper.Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestDataService;
using TestDataService.Data.UserActivitySection;

namespace InstaBot
{
    public partial class SubscribedUsers : Form
    {
        public SubscribedUsers(InstagramClient instagramClient)
        {
            InitializeComponent();

            _instagramClient = instagramClient;

            _mediaLikerList = new List<MediaLiker>();
            _userFollowersList = new List<InstaUserShort>();

            _userFollowersLoadList = new List<InstagramUser>();
            _subscribedUsersList = new List<InstagramUser>();
            _likedUsersList = new List<InstagramUser>();

            ListOfUsersToCheck.InitializationFollowersList(_userFollowersLoadList, "ListOfUsersToCheck");
            ListOfSubscribedUsers.InitializationFollowersList(_subscribedUsersList, "ListOfSubscribedUsers");
            ListOfLikedUsers.InitializationFollowersList(_likedUsersList, "ListOfLikedUsers");
        }

        private async void ButtonStartAnalysis_Click(object sender, EventArgs e)
        {
            if (UserName.Text == string.Empty)
            {
                MessageBox.Show("'User' parameter not set");
                return;
            }

            if(!_userFollowersLoadList.Any())
            {
                MessageBox.Show("the list is empty 'List of users to check'");
                return;
            }

            ButtonControl(false);

            try
            {
                _mediaLikerList.Clear();
                _userFollowersList.Clear();
                _likedUsersList.Clear();
                _subscribedUsersList.Clear();
                ListOfSubscribedUsers.Clear();
                ListOfLikedUsers.Clear();

                var result = await GetDataInstagram();

                if (result)
                {
                    await UserAnalysis();

                    ListOfSubscribedUsers.DisplayOnTheScreenUserList(_subscribedUsersList);
                    ListOfLikedUsers.DisplayOnTheScreenUserList(_likedUsersList);
                }
                else
                {
                    // ошибка
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                ButtonControl(true);
            }
        }

        private async Task<bool> GetDataInstagram()
        {
            // var user = await _instagramClient.GetUserByName(UserName.Text);
            // var story = await _instagramClient.GetUserStoryAsync(user.Value.Pk);
            var userMediaList = await _instagramClient.GetUserMedia(UserName.Text, (int)numericImage.Value / 18);

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

            var userFollowers = await _instagramClient.GetUserFollowers(UserName.Text);
            _userFollowersList.AddRange(userFollowers.Value);

            return _userFollowersList.Count != 0 && _mediaLikerList.Count != 0;
        }

        private async Task<bool> UserAnalysis()
        {
            foreach (var userLoad in _userFollowersLoadList)
            {
                if (userLoad.UserName == UserName.Text)
                {
                    continue;
                }

                var userFollower = _userFollowersList.Find(item => item.UserName == userLoad.UserName);

                var countLikes = _mediaLikerList
                      .Select(likes => likes.InstaLikersList
                      .FindAll(item => item.UserName == userLoad.UserName))
                      .ToList()
                      .FindAll(_ => _.Any())
                      .Count();

                if (userFollower != null)
                {
                    _subscribedUsersList.Add(new InstagramUser
                    {
                        UserName = userLoad.UserName,
                        NumberLikes = countLikes,
                        LikeSet = userLoad.LikeSet
                    });
                }
                else
                {
                    if (countLikes > 0)
                    {
                        _likedUsersList.Add(new InstagramUser
                        {
                            UserName = userLoad.UserName,
                            NumberLikes = countLikes,
                            LikeSet = userLoad.LikeSet
                        });
                    }
                }
            }

            //foreach (var mediaLiker in _mediaLikerList)
            //{
            //    foreach (var instaLikers in mediaLiker.InstaLikersList)
            //    {
            //        if (instaLikers.UserName == UserName.Text)
            //        {
            //            continue;
            //        }

            //        if (instaLikers.UserName == "ne_cactus")
            //        {
            //            var a = 1;
            //        }

            //        var userFollowersLoad = _userFollowersLoadList.Find(item => item.UserName == instaLikers.UserName);

            //        if(userFollowersLoad == null)
            //        {
            //            continue;
            //        }

            //        var userFollower = _userFollowersList.Find(item => item.UserName == userFollowersLoad.UserName);

            //        if (userFollowersLoad != null && userFollower != null)
            //        {
            //            var activeFollowersUser = _subscribedUsersList.Find(_ => _.UserName == userFollowersLoad.UserName);
            //            if (activeFollowersUser == null)
            //            {
            //                _subscribedUsersList.Add(new InstagramUser
            //                {
            //                    UserName = userFollowersLoad.UserName,
            //                    NumberLikes = 1,
            //                    LikeSet = userFollowersLoad.LikeSet
            //                });
            //            }
            //            else
            //            {
            //                activeFollowersUser.NumberLikes += 1;
            //            }
            //        }

            //        if (userFollowersLoad != null && userFollower == null)
            //        {
            //            if (instaLikers.UserName != UserName.Text)
            //            {
            //                var activeNotFollowersUser = _likedUsersList.Find(_ => _.UserName == instaLikers.UserName);
            //                if (activeNotFollowersUser == null)
            //                {
            //                    _likedUsersList.Add(new InstagramUser
            //                    {
            //                        UserName = userFollowersLoad.UserName,
            //                        NumberLikes = 1,
            //                        LikeSet = userFollowersLoad.LikeSet
            //                    });
            //                }
            //                else
            //                {
            //                    activeNotFollowersUser.NumberLikes += 1;
            //                }
            //            }

            //            for (var index = 0; index < _userFollowersList.Count; index++)
            //            {
            //                if (_userFollowersList[index].UserName == "an.mehendy")
            //                {
            //                    var a = 1;
            //                }
            //            }
            //        }
            //    }
            //}

            return true;
        }

        private void ButtonControl(bool flag)
        {
            if (buttonStartAnalysis.InvokeRequired)
            {
                buttonStartAnalysis.Invoke(new MethodInvoker(delegate { buttonStartAnalysis.Enabled = flag; }));
            }
            else
            {
                buttonStartAnalysis.Enabled = flag;
            }
        }

        private List<MediaLiker> _mediaLikerList;
        private List<InstaUserShort> _userFollowersList;
        private List<InstagramUser> _userFollowersLoadList;

        private List<InstagramUser> _subscribedUsersList;
        private List<InstagramUser> _likedUsersList;

        private InstagramClient _instagramClient;
    }
}
