using Serilog;
using System.ComponentModel;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

namespace Sownloader.Core
{
    // TODO: Test without network connection
    public class UpdateSearch
    {
        private const string VERSION_URL = "https://sownloader.com/functions/getLatestVersion.php";
        private const string DOWNLOAD_URL = "https://www.sownloader.com/Sownloader.zip";
        private static readonly string ZIP_PATH = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Sownloader.zip");
        private static HttpClient _client = new HttpClient();
        public Version InstalledVersion { get; }
        public Version? LatestVersion { get; private set; }

        private UpdateSearch(Version installedVersion)
        {
            InstalledVersion = installedVersion;
        }

        public static async Task<UpdateSearch> CreateAsync(Version installedVersion)
        {
            UpdateSearch updateSearch = new UpdateSearch(installedVersion);
            await updateSearch.SearchForUpdateAsync();

            return updateSearch;
        }


        /// <summary>
        /// Gets the latest <see cref="Version"/> of Sownloader.
        /// </summary>
        private async Task SearchForUpdateAsync()
        {
            try
            {
                // Sownloader-API is only available for Sownloader. Identified by User-Agent.
                _client.DefaultRequestHeaders.Add("User-Agent", $"Sownloader/{InstalledVersion}");
                string version = await _client.GetStringAsync(VERSION_URL);
                LatestVersion = Version.Parse(version);
            }
            catch (Exception ex)
            {
                Log.Logger.Error("Cannot fetch update information. Error: {ex}", ex);
            }
        }

        public async Task UpdateAsync(Downloader.ProgressChangedHandler? progressChangedHandler)
        {
            // Update download stats for latest version
            // Website does not return anything
            await _client.GetAsync($"https://sownloader.com/functions/updater.php?action=updateDatabase&version={LatestVersion}&code=ee26b0dd4af7e749aa1a8ee3c10ae9923f618980772e473f8819a5d4940e0db27ac185f8a0e1d5f84f88bc887fd67b143732c304cc5fa9ad8e6f57f50028a8ff");

            // Download the ZIP file.
            Downloader downloader = new Downloader();
            if (progressChangedHandler is not null)
            {
                Downloader.ProgressChanged += progressChangedHandler;
            }

            await downloader.DownloadFileAsync(DOWNLOAD_URL, ZIP_PATH);

            if (progressChangedHandler is not null)
            {
                Downloader.ProgressChanged -= progressChangedHandler;
            }


            try
            {
                Process updateProcess = new Process();
                updateProcess.StartInfo.FileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "update.bat");
                updateProcess.StartInfo.Arguments = $"\"{AppDomain.CurrentDomain.BaseDirectory}\" \"{Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Sownloader.zip")}\"";
                updateProcess.Start();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool IsUpdateAvailable() => InstalledVersion < LatestVersion;
        public bool SkipVersion(Version skipVersion) => skipVersion == LatestVersion;
    }
}
