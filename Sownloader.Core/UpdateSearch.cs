namespace Sownloader.Core
{
    public static class UpdateSearch
    {
        private const string VERSION_URL = "https://sownloader.com/functions/getLatestVersion.php";
        private static HttpClient _client = new HttpClient();

        
        /// <summary>
        /// Gets the latest <see cref="Version"/> of Sownloader.
        /// </summary>
        /// <param name="currentVersion">This version will be returned when any exception occurs.</param>
        public static async Task<Version> SearchForUpdateAsync(Version currentVersion)
        {
            Version returnVersion = currentVersion;
            try
            {
                // Sownloader-API is only available for Sownloader. Identified by User-Agent.
                _client.DefaultRequestHeaders.Add("User-Agent", $"Sownloader/{currentVersion}");
                string version = await _client.GetStringAsync(VERSION_URL);
                returnVersion = Version.Parse(version);
            }
            catch (Exception ex)
            {
                //TODO: Logging
            }


            return returnVersion;
        }
    }
}
