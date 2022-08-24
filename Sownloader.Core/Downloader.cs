using Sownloader.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sownloader.Core
{
    public class Downloader
    {
        

        public delegate void ProgressChangedHandler(long? totalFileSize, long totalBytesDownloaded, double? progressPercentage);

        public static event ProgressChangedHandler? ProgressChanged;

        private static HttpClient _client = new HttpClient();
        

        static Downloader()
        {
            _client.Timeout = TimeSpan.FromDays(1);
        }
    

        public async Task DownloadFileAsync(string url, string filename)
        {
            using HttpResponseMessage response = await _client.GetAsync(url, HttpCompletionOption.ResponseHeadersRead);
            await DownloadFromResponse(response, filename);
        }

       

        private async Task DownloadFromResponse(HttpResponseMessage response, string filename)
        {
            response.EnsureSuccessStatusCode();

            long? totalBytes = response.Content.Headers.ContentLength;
            using Stream contentStream = await response.Content.ReadAsStreamAsync();
            await ProcessContentStream(totalBytes, contentStream, filename);
        }

        private async Task ProcessContentStream(long? totalDownloadSize, Stream contentStream, string filename)
        {
            long totalBytesRead = 0;
            long readCount = 0;
            byte[] buffer = new byte[8192];
            bool isMoreToRead = true;

            using var fileStream = new FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.None, 8192, true);

            do
            {
                var bytesRead = await contentStream.ReadAsync(buffer, 0, buffer.Length);
                if (bytesRead == 0)
                {
                    isMoreToRead = false;
                    TriggerProgressChanged(totalDownloadSize, totalBytesRead);
                    continue;
                }

                await fileStream.WriteAsync(buffer, 0, bytesRead);

                totalBytesRead += bytesRead;
                readCount += 1;

                if (readCount % 100 == 0)
                    TriggerProgressChanged(totalDownloadSize, totalBytesRead);
            }
            while (isMoreToRead);
        }

        private void TriggerProgressChanged(long? totalDownloadSize, long totalBytesRead)
        {
            if (ProgressChanged == null)
            {
                return;
            }

            double? progressPercentage = null;
            if (totalDownloadSize.HasValue)
            {
                progressPercentage = Math.Round((double)totalBytesRead / totalDownloadSize.Value * 100, 2);
            }

            ProgressChanged(totalDownloadSize, totalBytesRead, progressPercentage);
        }
    }
}
