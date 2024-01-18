using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public static class FormManager
    {
        public static List<string> FetchLikedPagesNames(User i_User)
        {
            List<string> namesList = new List<string>();

            foreach (Page page in i_User.LikedPages.ToList())
            {
                namesList.Add(page.Name);
            }

            return namesList;
        }

        public static string FetchPagePhoto(Page i_Page)
        {
            return i_Page.PictureNormalURL;
        }

        public static Post FetchPostByIndex(User i_User, int i_Index)
        {
            Post post = null;

            if (i_Index < i_User.Posts.Count)
            {
                post = i_User.Posts[i_Index]; ;
            }

            return post;
        }



}
}
