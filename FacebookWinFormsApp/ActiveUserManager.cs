﻿using System.Collections.Generic;
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
            int specificPostsTypeCounter = 0;

            foreach (Post post in r_LoggedInUser.Posts)
            {
                if (post.Type == i_PostType)
                {
                    if (post.Type == Post.eType.status && !string.IsNullOrEmpty(post.Message))
                    {
                        specificPostsTypeCounter++;
                    }
                    else if (post.Type != Post.eType.status)
                    {
                        specificPostsTypeCounter++;
                    }
                }
                
            }

            return specificPostsTypeCounter;
        }

        public List<string> FetchNamesOfObjectList<T>(List<T> i_ListOfElementsThatHaveNameProperty)
        {
            List<string> namesList = new List<string>();

            PropertyInfo nameProperty = typeof(T).GetProperty("Name");

            if(nameProperty != null)
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
            Post postRes = null;
            int specificPostsRunner = 0;

            foreach (Post post in r_LoggedInUser.Posts)
            {
                if (post.Type == i_PostType)
                {
                    if (post.Type == Post.eType.status && !string.IsNullOrEmpty(post.Message))
                    {
                        if (specificPostsRunner == i_Index)
                        {
                            postRes = post;
                        }
                    }
                    if (post.Type != Post.eType.status)
                    {
                        if (specificPostsRunner == i_Index)
                        {
                            postRes = post;
                        }
                    }
                    specificPostsRunner++;
                }
            }

            return postRes;
        }

        public List<string> GenerateFriendsNamesDummyData()
        {
            List<string> friendNames = new List<string>();

            friendNames.Add("George Levy");
            friendNames.Add("Michael Ezra");

            return friendNames;
        }
    }
}