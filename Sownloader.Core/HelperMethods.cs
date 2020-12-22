using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Sownloader.Core
{
    public static class HelperMethods
    {
  
        public static string CheckSHA256(string filename)
        {
            using (FileStream stream = File.OpenRead(filename))
            {
                var sha = new SHA256Managed();
                byte[] checksum = sha.ComputeHash(stream);
                return BitConverter.ToString(checksum).Replace("-", String.Empty).ToLower();
            }
        }
        
        public static string GenerateRandomString(int StringLenght)
        {
            string Chars = "abcdefghijklmnopqrstuvwxyz";
            string RandomString = "";
            Random rdm = new Random();

            for (int i = 0; i < StringLenght; i++)
            {
                RandomString += Chars[rdm.Next(Chars.Length)];
            }

            return RandomString;
        }
    }
}
