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



}
}
