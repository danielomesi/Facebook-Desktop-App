using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;
using Newtonsoft.Json;

namespace BasicFacebookFeatures
{
    public class ActiveUserManager
    {
        private readonly User r_LoggedInUser;
        public int m_StatusPostsListSize { get; set; }
        public int m_PhotoPostsListSize { get; set; }
        public List<string> m_AiSuggestionsForStatuses { get; set; }

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
                    specificPostsTypeCounter++;
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
                    if (specificPostsRunner == i_Index)
                    {
                        postRes = post;
                    }

                    specificPostsRunner++;
                }
            }

            return postRes;
        }

        public List<string> GenerdateFriendsNamesDummyData()
        {
            List<string> friendNames = new List<string>();

            friendNames.Add("George Levy");
            friendNames.Add("Michael Ezra");

            return friendNames;
        }

        public async Task<bool> ParaphraseTextAsync(string i_Text)
        {
            bool isSuccess;
            List<string> suggestionsList = new List<string>();
            Uri requestUri = new Uri("https://api.ai21.com/studio/v1/paraphrase");
            string apiKey = "GOZIBGQfIhJUzd0uNj0tErRGal1W8e0X";


            string requestBody = $"{{\"style\":\"general\", \"text\":\"{i_Text}\"}}";

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, requestUri);
            request.Headers.Add("Authorization", "Bearer " + apiKey);
            request.Headers.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            request.Content = new StringContent(requestBody, Encoding.UTF8, "application/json");

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.SendAsync(request);
                isSuccess = response.IsSuccessStatusCode;
                if (isSuccess)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    ParaphraseResponse paraphraseResponse = JsonConvert.DeserializeObject<ParaphraseResponse>(result);

                    if (paraphraseResponse != null && paraphraseResponse.Suggestions != null)
                    {
                        foreach (Suggestion suggestion in paraphraseResponse.Suggestions)
                        {
                            suggestionsList.Add(suggestion.Text);
                        }
                    }
                }
                m_AiSuggestionsForStatuses = suggestionsList;
                return isSuccess;
            }
        }
    }
}
