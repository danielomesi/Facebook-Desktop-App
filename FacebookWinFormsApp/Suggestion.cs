using static System.Net.Mime.MediaTypeNames;

namespace AITextGenerator
{
    public class Suggestion
    {
        private string m_Text;
        public string Text
        {
            get { return m_Text; }
            set { m_Text = value; }
        }
    }
}