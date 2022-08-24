using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sownloader.Core.Models
{
    public class DownloadPerformance
    {
        public string SavePath { get; }
        public string SaveExtension { get; }

        public string SongName => Performance.title;
        public string CoverUrl => Performance.cover_url;
        public string CoverFilename { get; }
        [Browsable(false)]
        public Performance Performance { get; }

        public bool RequiresConverting => SaveExtension.Equals(".mp3", StringComparison.OrdinalIgnoreCase);
        public DownloadPerformance(string savePath, string save_extension, Performance performance)
        {
            SavePath = savePath;
            SaveExtension = save_extension;
            Performance = performance;
            CoverFilename = Path.Combine(SownloaderController.COVER_PATH, $"{Helpers.GenerateRandomString(5)}{Path.GetFileNameWithoutExtension(CoverUrl)}");
        }

        public string? GetDownloadUrl()
        {
            return SaveExtension switch
            {
                ".mp4" or ".MP4" => Performance.GetVideoMediaUrlDecoded(),
                _ => Performance.GetMediaUrlDecoded(),
            };
        }

        public string GetDownloadExtension()
        {
            // MP3 needs to be converted. The original file is either m4a or mp4. MP4 is only set when it's a video
            if (SaveExtension.Equals(".mp3", StringComparison.OrdinalIgnoreCase))
            {
                return ".m4a";
            }

            return SaveExtension;
        }

        public string GetDownloadFilename()
        {
            string directoryName = Path.GetDirectoryName(SavePath);
            string filename = Path.GetFileNameWithoutExtension(SavePath);
            string extension = GetDownloadExtension();
            string path = Path.Combine(directoryName, $"{filename}{extension}");
            return path;
        }

    }
}
