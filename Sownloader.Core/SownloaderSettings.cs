using System.Xml.Serialization;

namespace Sownloader.Core
{
    public class SownloaderSettings : ICloneable
    {
        public bool KeepInForeground { get; set; }
        public string Bitrate { get; set; } = "320k";
        public string DefaultSavePath { get; set; } = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
        public string DefaultPage { get; set; } = "https://smule.com";

        public string SkipVersion { get; set; } = "1.0.0";

        public void Save(string savePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(SownloaderSettings));

            if (File.Exists(savePath))
            {
                File.Delete(savePath);
            }

            using FileStream stream = new FileStream(savePath, FileMode.CreateNew, FileAccess.Write);
            serializer.Serialize(stream, this);
        }

        public static SownloaderSettings Read(string savePath)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(SownloaderSettings));
                using FileStream stream = new FileStream(savePath, FileMode.Open, FileAccess.Read);
                object? settings = serializer.Deserialize(stream);
                if (settings is null)
                {
                    return new SownloaderSettings();
                }

                return (SownloaderSettings)settings;
            }
            catch (Exception)
            {

                return new SownloaderSettings();
            }

        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
