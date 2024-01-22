using System.Collections.Generic;

namespace AITextGenerator
{
    public class ParaphraseResponse
    {
        public string Id { get; set; }
        public List<Suggestion> Suggestions { get; set; }
    }
}