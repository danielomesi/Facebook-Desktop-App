using System.Drawing;

namespace BasicFacebookFeatures
{
    public class AppSettings
    {
        private Point m_LastWindowLocation;
        private Size m_LastWindowSize;
        private bool m_RememberUser;
        private string m_LastAccessToken;

        public Point LastWindowLocation
        {
            get { return m_LastWindowLocation; }
            set { m_LastWindowLocation = value; }
        }

        public Size LastWindowSize
        {
            get { return m_LastWindowSize; }
            set { m_LastWindowSize = value; }
        }

        public bool RememberUser
        {
            get { return m_RememberUser; }
            set { m_RememberUser = value; }
        }

        public string LastAccessToken
        {
            get { return m_LastAccessToken; }
            set { m_LastAccessToken = value; }
        }

        public AppSettings()
        {
            m_LastWindowLocation = new Point(20, 50);
            m_LastWindowSize = new Size(1000, 500);
            m_RememberUser = false;
            m_LastAccessToken = null;
        }
    }
}