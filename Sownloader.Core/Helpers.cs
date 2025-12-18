using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Sownloader.Core
{
    public static class Helpers
    {
        ///// <summary>
        ///// Generates a SHA256 checksum of s epcified file.
        ///// </summary>
        ///// <param name="filename"></param>
        ///// <returns></returns>
        //public static string CheckSHA256(string filename)
        //{
        //    using FileStream stream = File.OpenRead(filename);
        //    var sha = new SHA256Managed();
        //    byte[] checksum = sha.ComputeHash(stream);
        //    return BitConverter.ToString(checksum).Replace("-", String.Empty).ToLower();
        //}
        /// <summary>
        /// This method generates a random string by pattern Chars.
        /// </summary>
        /// <param name="StringLenght">Length of the random string</param>
        /// <returns>A random string.</returns>
        public static string GenerateRandomString(int StringLenght)
        {
            string Chars = "abcdefghijklmnopqrstuvwxyz";
            string RandomString = "";
            Random rdm = new();

            for (int i = 0; i < StringLenght; i++)
            {
                RandomString += Chars[rdm.Next(Chars.Length)];
            }

            return RandomString;
        }

        public static void OpenUrl(string url)
        {
            try
            {
                Process.Start(url);
            }
            catch
            {
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    url = url.Replace("&", "^&");
                    Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    Process.Start("xdg-open", url);
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    Process.Start("open", url);
                }
                else
                {
                    throw;
                }
            }
        }
    }
}
