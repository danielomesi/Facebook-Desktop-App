using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public class ActiveUserManager
    {
        private readonly User r_LoggedInUser;
        public int m_StatusPostsListSize { get; set; }
        public int m_PhotoPostsListSize {  get; set; }

        public ActiveUserManager(User i_LoggedInUser)
        {
            r_LoggedInUser = i_LoggedInUser;
            m_StatusPostsListSize = getSizeOfListOfSpecificPostsType(Post.eType.status);
            m_PhotoPostsListSize = getSizeOfListOfSpecificPostsType(Post.eType.photo);
        }

        public string GetNameOfUser()
        {
            return r_LoggedInUser.UserName;
        }

        private int getSizeOfListOfSpecificPostsType(Post.eType i_PostType)
        {
            int specificPostsTypeCounter = 0;

            foreach (Post post in r_LoggedInUser.Posts)
            {
                if (post.Type == i_PostType)
                {
                    specificPostsTypeCounter++;
                }
            }

            return specificPostsTypeCounter;
        }

        public List<string> FetchLikedPagesNames()
        {
            List<string> namesList = new List<string>();

            foreach (Page page in r_LoggedInUser.LikedPages)
            {
                namesList.Add(page.Name);
            }

            return namesList;
        }

        public static string FetchPagePhoto(Page i_Page)
        {
            return i_Page.PictureNormalURL;
        }

        public Post FetchPostByIndex(Post.eType i_PostType, int i_Index)
        {
            Post postRes = null;
            int specificPostsRunner = 0;

            foreach (Post post in r_LoggedInUser.Posts)
            {
                if (post.Type == i_PostType)
                {
                    if (specificPostsRunner == i_Index)
                    {
                        postRes = post;
                    }

                    specificPostsRunner++;
                }
            }

            return postRes;
        }
}
}
