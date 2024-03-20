using System.Collections.Generic;

namespace AITextGenerator
{
    public class ParaphraseResponse
    {
        private string m_Id;
        private List<Suggestion> m_Suggestions;

        public string Id
        {
            get { return m_Id; }
            set { m_Id = value; }
        }

        public List<Suggestion> Suggestions
        {
            get { return m_Suggestions; }
            set { m_Suggestions = value; }
        }
    }
}