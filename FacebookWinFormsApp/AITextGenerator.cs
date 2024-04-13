using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AITextGenerator
{
    public sealed class AITextGenerator
    {
        private const string k_ApiKey = "77b0a836fdmsh3665de3eeb1e775p189834jsn857679d4ee9d";
        private const string k_RequestUri = "https://paraphrase-genius.p.rapidapi.com/dev/paraphrase/";
        private const string k_ApiHost = "paraphrase-genius.p.rapidapi.com";

        private AITextGenerator()
        {

        }

        public static AITextGenerator Instance
        {
            get { return NestedHolder.instance; }
        }

        private class NestedHolder
        {
            internal static volatile AITextGenerator instance = new AITextGenerator();
        }

        public async Task<List<string>> ParaphraseTextAsync(string i_Text)
        {
            bool isSuccess;
            List<string> suggestionsList = new List<string>();

            // Setting up the request URI
            Uri requestUri = new Uri("https://paraphrase-genius.p.rapidapi.com/dev/paraphrase/");

            // Constructing the request body with the input text
            string requestBody = JsonConvert.SerializeObject(new
            {
                text = i_Text,
                result_type = "multiple"
            });

            using (HttpClient client = new HttpClient())
            {
                // Setting up the request message
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, requestUri);
                request.Headers.Add("X-RapidAPI-Key", "77b0a836fdmsh3665de3eeb1e775p189834jsn857679d4ee9d");
                request.Headers.Add("X-RapidAPI-Host", "paraphrase-genius.p.rapidapi.com");
                request.Content = new StringContent(requestBody, Encoding.UTF8, "application/json");

                // Sending the request and handling the response
                HttpResponseMessage response = await client.SendAsync(request);
                isSuccess = response.IsSuccessStatusCode;

                if (isSuccess)
                {
                    string result = await response.Content.ReadAsStringAsync();

                    // Deserialize the response into a nested list of strings
                    List<List<string>> nestedSuggestions = JsonConvert.DeserializeObject<List<List<string>>>(result);

                    // Iterate through the nested list and add suggestions to the suggestionsList
                    foreach (var suggestions in nestedSuggestions)
                    {
                        foreach (string suggestion in suggestions)
                        {
                            suggestionsList.Add(suggestion);
                        }
                    } 
                }
                return suggestionsList;
            }
        }
    }
}