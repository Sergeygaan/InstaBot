using Extensions;
using InstaSharper.API;
using InstaSharper.API.Builder;
using InstaSharper.Classes;
using InstaSharper.Classes.Models;
using System;
using System.Threading.Tasks;

namespace TestDataService
{
    public class InstagramClient : IDisposable
    {
        #region Login

        public async Task<IResult<InstaLoginResult>> Login(string userName, string password)
        {
            if (_instaApi == null)
            {
                CreateInstaApi(userName, password);
            }

            if (!_instaApi.IsUserAuthenticated)
            {
                var login = await  _instaApi.LoginAsync();

                return login;
            }

            return null;
        }

        public async Task<IResult<InstaLoginTwoFactorResult>> TwoFactorLogin(string verificationCode)
        {
            return await _instaApi.TwoFactorLoginAsync(verificationCode);
        }

        public async Task<IResult<InstaChallengeRequireVerifyMethod>> ChallengeRequireVerify()
        {
            return await _instaApi.GetChallengeRequireVerifyMethodAsync();
        }

        public async Task<IResult<bool>> Logout()
        {
            if (_instaApi.IsUserAuthenticated)
            {
                var logon = await _instaApi.LogoutAsync();

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
               .SetRequestDelay(RequestDelay.FromSeconds(1, 2))
               .SetUser(new UserSessionData
               {
                   UserName = userName,
                   Password = password
               })
               .Build();
        }

        #endregion

        #region Users

        public Task<IResult<InstaUserShortList>> GetUserFollowers(string username)
        {
            return _instaApi.GetUserFollowersAsync(username, PaginationParameters.Empty);
        }

        public Task<IResult<InstaMediaList>> GetUserMedia(string user, int? maxPagesToLoad = 1)
        {
            PaginationParameters paginationParameters;
            if (maxPagesToLoad.HasValue)
            {
                paginationParameters = PaginationParameters.MaxPagesToLoad(maxPagesToLoad.Value);
            }
            else
            {
                paginationParameters = PaginationParameters.Empty;
            }

            return _instaApi.GetUserMediaAsync(user, paginationParameters);
        }

        public Task<IResult<InstaLikersList>> GetMediaLikers(string mediaId)
        {
            return _instaApi.GetMediaLikersAsync(mediaId);
        }

        public Task<IResult<InstaUser>> GetUserByName(string username)
        {
            return _instaApi.GetUserAsync(username);
        }

        public Task<IResult<InstaUserInfo>> GetUserInfoById(long pk)
        {
            return _instaApi.GetUserInfoByIdAsync(pk);
        }

        public Task<IResult<InstaStory>> GetUserStoryAsync(long userId)
        {
            return _instaApi.GetUserStoryAsync(userId);
        }

        public Task<IResult<bool>> LikeMedia(string mediaId)
        {
            return _instaApi.LikeMediaAsync(mediaId);
        }

        public Task<IResult<bool>> UnLikeMedia(string mediaId)
        {
            return _instaApi.UnLikeMediaAsync(mediaId);
        }

        #endregion

        public void Dispose()
        {
            Logout();
        }

        public static IInstaApi _instaApi;
    }
}
