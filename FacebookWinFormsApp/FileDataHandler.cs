﻿using System;
using System.Diagnostics;
using System.IO;
using System.Xml.Serialization;

namespace BasicFacebookFeatures
{
    public static class FileDataHandler
    {
        public static void SaveToFile(string i_FilePath, Stopwatch i_Obj, Type i_Type)
        {
            using (Stream stream = new FileStream(i_FilePath, FileMode.OpenOrCreate))
            {
                stream.SetLength(0);
                XmlSerializer serializer = new XmlSerializer(i_Type);
                serializer.Serialize(stream, i_Obj);
            }
        }

        public static object LoadFromFile(string i_FilePath, Type i_Type)
        {
            object obj = null;

            if (File.Exists(i_FilePath))
            {
                using (Stream stream = new FileStream(i_FilePath, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(i_Type);
                    obj = serializer.Deserialize(stream);
                }
            }

            return obj;
        }

        public static bool ClearFile(string i_FilePath)
        {
            bool isSuccessfullDelete = true;

            if (File.Exists(i_FilePath))
            {
                try
                {
                    File.Delete(i_FilePath);
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