using System;
using System.Drawing;
using System.IO;
using System.Xml.Serialization;

namespace BasicFacebookFeatures
{
    public class AppSettings
    {
        public Point m_LastWindowLocation { get; set; } //remember to check on it
        public Size m_LastWindowSize { get; set; } //remember to check on it
        public bool m_RememberUser { get; set; }
        public string m_LastAccessToken { get; set; }

        public AppSettings()
        {
            m_LastWindowLocation = new Point(20, 50);
            m_LastWindowSize = new Size(1000, 500);
            m_RememberUser = false;
            m_LastAccessToken = null;
        }
    }
}