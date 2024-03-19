using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class ActiveUserManager
    {
        private readonly User r_LoggedInUser;
        public int m_StatusPostsListSize;
        public int m_PhotoPostsListSize;
        public List<string> m_AiSuggestionsForStatuses;

        public ActiveUserManager(User i_LoggedInUser)
        {
            r_LoggedInUser = i_LoggedInUser;
            m_StatusPostsListSize = getListSizeOfSpecificPostsType(Post.eType.status);
            m_PhotoPostsListSize = getListSizeOfSpecificPostsType(Post.eType.photo);
            m_AiSuggestionsForStatuses = null;
        }


        private int getListSizeOfSpecificPostsType(Post.eType i_PostType)
        {
            PostsFilter postsFilter = new PostsFilter(new PostFilterTypeStrategy());
            List<Post> filteredPosts = postsFilter.Filter(r_LoggedInUser.Posts.ToList<Post>(), i_PostType);

            return filteredPosts.Count;
        }

        public List<string> FetchNamesOfObjectList<T>(List<T> i_ListOfElementsThatHaveNameProperty)
        {
            List<string> namesList = new List<string>();
            PropertyInfo nameProperty = typeof(T).GetProperty("Name");

            if (nameProperty != null)
            {
                for (int i = 0; i < i_ListOfElementsThatHaveNameProperty.Count; i++)
                {
                    namesList.Add(nameProperty.GetValue(i_ListOfElementsThatHaveNameProperty[i]) as string);
                }
            }
            
            return namesList;
        }

        public static string FetchPagePhoto(Page i_Page)
        {
            return i_Page.PictureNormalURL;
        }

        public Post FetchPostByIndex(Post.eType i_PostType, int i_Index)
        {
            PostsFilter postsFilter = new PostsFilter(new PostFilterTypeStrategy());
            List<Post> filteredPosts = postsFilter.Filter(r_LoggedInUser.Posts.ToList<Post>(), i_PostType);

            return filteredPosts[i_Index];
        }
    }
}