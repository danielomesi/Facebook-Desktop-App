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

        public void SaveToFile()
        {
            using (Stream stream = new FileStream(@".\appSettings.xml", FileMode.OpenOrCreate))
            {
                stream.SetLength(0);
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(stream, this);
            }
        }

        public static AppSettings LoadFromFile()
        {
            AppSettings appSettings = null;

            string filePath = @".\appSettings.xml";

            if (File.Exists(filePath))
            {
                using (Stream stream = new FileStream(filePath, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                    appSettings = serializer.Deserialize(stream) as AppSettings;
                }
            }

            return appSettings;
        }

        public static bool ClearFile()
        {
            bool isSuccessfullDelete = true;

            string filePath = @".\appSettings.xml";

            if (File.Exists(filePath))
            {
                try
                {
                    File.Delete(filePath);
                    isSuccessfullDelete = true;
                }
                catch (Exception ex)
                {
                    isSuccessfullDelete = false;
                }
            }
            return isSuccessfullDelete;
        }
    }
}