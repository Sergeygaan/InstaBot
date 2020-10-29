using System;
using System.Collections.Generic;
using System.Linq;
using TestDataService.Data.UserActivitySection;

namespace Extensions
{
    public static class ListExtensions
    {
        public static List<InstagramUserActivity> CountingDuplicates(this List<InstagramUser> itemList)
        {
            var instagramUserActivityList = new List<InstagramUserActivity>();

            foreach (var item in itemList)
            {
                var user = instagramUserActivityList.Find(_ => _.UserName == item.UserName);
                if (user != null)
                {
                    user.NumberLikes += 1;
                }
                else
                {
                    instagramUserActivityList.Add(new InstagramUserActivity
                    {
                        UserName = item.UserName,
                        NumberLikes = 1,
                        InstagramUser = item
                    });
                }

            }

            return instagramUserActivityList;
        }
    }
}
