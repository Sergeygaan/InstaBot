using Extensions;
using InstaSharper.API;
using InstaSharper.API.Builder;
using InstaSharper.Classes;
using InstaSharper.Classes.Models;
using System;

namespace TestDataService
{
    public class InstagramClient : IDisposable
    {
        #region Login

        public IResult<InstaLoginResult> Login(string userName, string password)
        {
            if(_instaApi == null)
            {
                CreateInstaApi(userName, password);
            }

            if (!_instaApi.IsUserAuthenticated)
            {
                var login = AwaitHelper.Waiting(() => _instaApi.LoginAsync());

                if (login.Succeeded)
                {
                    _instaApi.IsUserAuthenticated = true;
                }

                return login;
            }

            return null;
        }

        public IResult<bool> Logout()
        {
            if (_instaApi.IsUserAuthenticated)
            {
                var logon = AwaitHelper.Waiting(() => _instaApi.LogoutAsync());

                if (logon.Succeeded)
                {
                    _instaApi.IsUserAuthenticated = false;
                }

                _instaApi = null;

                return logon;
            }

            return null;
        }

        private void CreateInstaApi(string userName, string password)
        {
            _instaApi = InstaApiBuilder.CreateBuilder()
               .SetUser(new UserSessionData
               {
                   UserName = userName,
                   Password = password
               })
               .Build();
        }

        #endregion

        #region Users

        public IResult<InstaUserShortList> GetUserFollowers(int maxPagesToLoad = 1)
        {
            return AwaitHelper.Waiting(() => _instaApi.GetUserFollowersAsync("gaansia", PaginationParameters.MaxPagesToLoad(maxPagesToLoad)));
        }

        public IResult<InstaMediaList> GetUserMedia(string user, int maxPagesToLoad = 1)
        {
            return AwaitHelper.Waiting(() => _instaApi.GetUserMediaAsync(user, PaginationParameters.MaxPagesToLoad(maxPagesToLoad)));
        }

        public IResult<bool> LikeMedia(string mediaId)
        {
            return AwaitHelper.Waiting(() => _instaApi.LikeMediaAsync(mediaId));
        }

        public IResult<bool> UnLikeMedia(string mediaId)
        {
            return AwaitHelper.Waiting(() => _instaApi.UnLikeMediaAsync(mediaId));
        }

        #endregion

        public void Dispose()
        {
            Logout();
        }

        private static IInstaApi _instaApi;
    }
}
