using Sownloader.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Sownloader.Core.Services
{
    public class PerformanceService
    {
        private readonly HttpClient _httpClient;
        private static string[] _validStartPatterns = new string[]
        {
            "https://smule.com/",
            "http://smule.com/",
            "https://www.smule.com/",
            "http://smule.com/",
            "smule.com/",
            "www.smule.com"
        };
        public PerformanceService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<Performance?> GetAsync(string url, CancellationToken cancellationToken = default)
        {

            string api_url = url
                .Replace("https://", string.Empty)
                .Replace("http://", string.Empty)
                .Replace("www.", string.Empty)
                ;

            if (api_url.EndsWith('/'))
            {
                api_url = api_url.Remove(api_url.Length - 1);
            }


            string[] splittedUrl = api_url.Split('/');

            api_url = $"https://smule.com/p/{splittedUrl.Last()}/json";
            //string api_url = $"{url}/json";



            cancellationToken.ThrowIfCancellationRequested();

            //string test = await _httpClient.GetStringAsync(api_url, cancellationToken);
            var performance = await _httpClient.GetFromJsonAsync<Performance>(api_url, cancellationToken);

            return performance;
        }

        public bool IsValidSmuleUrl(string url)
        {
            foreach (var pattern in _validStartPatterns)
            {
                if(url.StartsWith(pattern))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
