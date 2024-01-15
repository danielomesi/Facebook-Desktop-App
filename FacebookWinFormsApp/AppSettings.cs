using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BasicFacebookFeatures
{
    public class AppSettings
    {
        public Point LastWindowsLocation { get; set; } //remember to check on it
        public Size LastWindowsSize { get; set; } //remember to check on it
        public bool RememberUs { get; set; }
        public string LastAccessToken { get; set; }

        public AppSettings()
        {
            LastWindowsLocation = new Point(20, 50);
            LastWindowsSize = new Size(1000, 500);
            RememberUs = false;
            LastAccessToken = null;
        }

        public void SaveToFile()
        {
            using (Stream stream = new FileStream(@".\appSettings.xml", FileMode.OpenOrCreate))
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(stream, this);
            }
        }

        public static AppSettings LoadFromFile()
        {
            AppSettings obj = null;

            string filePath = @".\appSettings.xml";

            if (File.Exists(filePath))
            {
                using (Stream stream = new FileStream(filePath, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                    obj = serializer.Deserialize(stream) as AppSettings;
                }

            }

            return obj;
        }
    }
}
