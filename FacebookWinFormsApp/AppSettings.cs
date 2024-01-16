using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BasicFacebookFeatures
{
    public class AppSettings
    {
        public Point LastWindowLocation { get; set; } //remember to check on it
        public Size LastWindowSize { get; set; } //remember to check on it
        public bool RememberUser { get; set; }
        public string LastAccessToken { get; set; }

        public AppSettings()
        {
            LastWindowLocation = new Point(20, 50);
            LastWindowSize = new Size(1000, 500);
            RememberUser = false;
            LastAccessToken = null;
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
