using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Sownloader.Core.Models
{

    public class Performance
    {
        public object rec_id { get; set; }
        public object poi { get; set; }
        public string key { get; set; }
        public string performance_key { get; set; }
        public object join_link { get; set; }
        public string type { get; set; }
        public string title { get; set; }
        public string artist { get; set; }
        public string message { get; set; }
        public DateTime created_at { get; set; }
        public object expire_at { get; set; }
        public bool seed { get; set; }
        public bool closed { get; set; }
        public string ensemble_type { get; set; }
        public int child_count { get; set; }
        public string app_uid { get; set; }
        public string arr_type { get; set; }
        public string arr_key { get; set; }
        public object song_id { get; set; }
        public int? song_length { get; set; }
        public string perf_status { get; set; }
        public object artist_twitter { get; set; }
        public Orig_Track_City orig_track_city { get; set; }
        public string? media_url { get; set; }
        public string? video_media_url { get; set; }
        public string? video_media_mp4_url { get; set; }
        public string cover_url { get; set; }
        public string web_url { get; set; }
        public string song_info_url { get; set; }
        public Stats stats { get; set; }
        public string performed_by { get; set; }
        public string performed_by_url { get; set; }
        public Owner owner { get; set; }
        public object[] other_performers { get; set; }
        public object duet { get; set; }
        public object other { get; set; }
        public bool featured { get; set; }
        public object rm { get; set; }
        public bool _private { get; set; }
        public bool lyric_video { get; set; }
        public string lyrics { get; set; }

        public async Task<Performance?> RenderPerformance(IHttpClientFactory clientFactory, PerformanceType performanceType, Action<int> triesCallback)
        {
            //https://www.smule.com/p/2416676_112255176/render
            string renderUrl = $"https://smule.com/p/{performance_key}/render";
            var request = new HttpRequestMessage(HttpMethod.Post, renderUrl);
            var client = clientFactory.CreateClient();

            HttpResponseMessage response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                // Rendering is done on server side and might take some time
                string performanceDataUrl = $"https://smule.com/p/{performance_key}/json";

                // We are trying to get the rendered performance 5 times
                for (int i = 0; i < 5; i++)
                {
                    triesCallback(i + 1);
                    await Task.Delay(TimeSpan.FromSeconds(3));
                    request = new HttpRequestMessage(HttpMethod.Get, performanceDataUrl);
                    response = await client.SendAsync(request);
                    if (response.IsSuccessStatusCode)
                    {
                        var performance = await response.Content.ReadFromJsonAsync<Performance>();
                        switch (performanceType)
                        {
                            case PerformanceType.Audio:
                                if(performance is not null && performance.media_url is not null)
                                {
                                    return performance;
                                }
                                break;
                            case PerformanceType.Video:
                                if (performance is not null && performance.video_media_mp4_url is not null)
                                {
                                    return performance;
                                }
                                break;
                            default:
                                throw new ArgumentOutOfRangeException(nameof(performanceType));
                        }        
                    }
                }
            }

            // We could fetch a valid performance
            return null;
        }
    }

    public enum PerformanceType
    {
        Audio,
        Video
    }
    public class Orig_Track_City
    {
        public string city { get; set; }
        public string country { get; set; }
    }

    public class Stats
    {
        public int total_performers { get; set; }
        public string truncated_other_performers { get; set; }
        public int total_listens { get; set; }
        public string truncated_listens { get; set; }
        public int total_loves { get; set; }
        public string truncated_loves { get; set; }
        public int total_comments { get; set; }
        public string truncated_comments { get; set; }
        public int total_commenters { get; set; }
        public int total_gifts { get; set; }
        public string truncated_gifts { get; set; }
    }

    public class Owner
    {
        public int account_id { get; set; }
        public string handle { get; set; }
        public string pic_url { get; set; }
        public float lat { get; set; }
        public float lon { get; set; }
        public string url { get; set; }
        public bool is_vip { get; set; }
        public bool is_verified { get; set; }
        public string verified_type { get; set; }
    }
}
