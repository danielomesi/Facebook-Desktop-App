using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AITextGenerator
{
    public static class AITextGenerator
    {
        private const string k_ApiKey = "GOZIBGQfIhJUzd0uNj0tErRGal1W8e0X";
        private const string k_RequestUri = "https://api.ai21.com/studio/v1/paraphrase";

        public static async Task<List<string>> ParaphraseTextAsync(string i_Text)
        {
            bool isSuccess;
            List<string> suggestionsList = new List<string>();
            Uri requestUri = new Uri(k_RequestUri);

            string requestBody = $"{{\"style\":\"general\", \"text\":\"{i_Text}\"}}";

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, requestUri);
            request.Headers.Add("Authorization", "Bearer " + k_ApiKey);
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

                return suggestionsList;
            }
        }
    }
}