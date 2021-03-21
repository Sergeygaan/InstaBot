using InstaSharper.Classes.Models;
using System;

namespace TestDataService.Data.UserActivitySection
{
    [Serializable]
    public class InstagramUser
    {
        public string UserName { get; set; }

        public InstaUserShort InstaUserShort { get; set; }

        public InstaUserInfo InstaUserInfo { get; set; }

        public int NumberLikes { get; set; }

        public int NumberComments { get; set; }
    }
}
