using Sownloader.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sownloader.Services
{
    public class BitrateSelectorServices : IBitrateSelectorServices
    {
        public BitrateSelectorServices()
        {
        }

        public void InitializeBitrate()
        {
            var theme = GetCurrentBitrate();
            SetBitrate(theme);
        }

        public void SetBitrate(string bitrate)
        {
            if (!IsValidBitrate(bitrate))
                throw new ArgumentException("Invalid bitrate", nameof(bitrate));

            App.Current.Properties["Bitrate"] = bitrate.ToString();
        }

        public string GetCurrentBitrate()
        {
            if (App.Current.Properties.Contains("Bitrate"))
            {
                var bitrate = App.Current.Properties["Bitrate"].ToString();
                if (IsValidBitrate(bitrate))
                {
                    return bitrate;
                }
            }

            return "320k";
        }

        public bool IsValidBitrate(string bitrate)
        {
            return bitrate switch
            {
                "8k" or "16k" or "24k" or "32k" or "40k" or "48k" or "64k" or "80k" or "96k" or "112k" or "128k" or "160k" or "192k" or "224k" or "256k" or "320k" => true,
                _ => false
            };
        }
    }
}
