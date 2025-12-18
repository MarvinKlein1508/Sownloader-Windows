using Sownloader.Core.Models;
using System.Diagnostics;

namespace Sownloader.Core
{
    public class SownloaderController
    {
        public static readonly string COVER_PATH = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Covers");

        public DownloadPerformance Performance { get; }
        private Downloader _downloader = new Downloader();
        public SownloaderController(DownloadPerformance performance)
        {
            Performance = performance;
        }


        public async Task DownloadAsync()
        {
            string download_url = Performance.GetDownloadUrl();
            string filename = Performance.GetDownloadFilename();
            await _downloader.DownloadFileAsync(download_url, filename);
        }

        public async Task DownloadCoverAsync()
        {
            string download_url = Performance.CoverUrl;
            string filename = Performance.CoverFilename;
            await _downloader.DownloadFileAsync(download_url, filename);
        }
        public Task SetMetaDataAsync()
        {
            // TODO: Max Länge berücksichtigen SafeSubstring()?
            TagLib.File.LocalFileAbstraction AudioFilePath = new TagLib.File.LocalFileAbstraction(Performance.GetDownloadFilename());
            TagLib.File AudioFile = TagLib.File.Create(AudioFilePath);
            AudioFile.Tag.Title = Performance.SongName;
            AudioFile.Tag.Performers = new string[] { Performance.Performance.performed_by };
            AudioFile.Tag.Album = Performance.Performance.app_uid;
            AudioFile.Tag.Year = Convert.ToUInt32(Performance.Performance.created_at.Year);

            if (File.Exists(Performance.CoverFilename))
            {
                AudioFile.Tag.Pictures = new TagLib.Picture[] { new TagLib.Picture(Performance.CoverFilename) };
                AudioFile.Tag.Pictures[0].Type = TagLib.PictureType.FrontCover;
            }
            AudioFile.Save();
            AudioFile.Dispose();

            return Task.CompletedTask;
        }

        public Task ConvertAsync(SownloaderSettings settings)
        {
            using Process FFmpeg = new Process();
            FFmpeg.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            FFmpeg.StartInfo.FileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ffmpeg.exe");
            FFmpeg.StartInfo.UseShellExecute = false;
            FFmpeg.StartInfo.CreateNoWindow = false;

            string codec = "";

            string filename = Performance.GetDownloadFilename();
            // Extract m4a from mp4 video:
            //codec = "-i " + tempFile + " -vn -c:a copy " + tempFile.Substring(0, tempFile.Length - 4) + ".m4a";
            switch (Performance.SaveExtension)
            {
                case ".mp3":
                    codec = $"-i {filename} -f mp3 -b:a {settings.Bitrate} -acodec libmp3lame {Performance.SavePath}";
                    break;
                default:
                    break;
            }

            FFmpeg.StartInfo.Arguments = codec;

            FFmpeg.Start();

            while (!FFmpeg.HasExited)
            {

            }

            FFmpeg.Dispose();
            FFmpeg.Close();

            File.Delete(filename);

            return Task.CompletedTask;
        }
    }
}
