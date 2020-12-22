using Sownloader.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sownloader.Services
{
    public class DefaultPageService : IDefaultPageService
    {
        public DefaultPageService()
        {
        }

        public void InitializeDefaultPage()
        {
            var defaultPage = GetDefaultPage();
            SetDefaultPage(defaultPage.AbsoluteUri);
        }

        public void SetDefaultPage(string defaultPage)
        {
            App.Current.Properties["DefaultPage"] = defaultPage.ToString();
        }

        public Uri GetDefaultPage()
        {
            if (App.Current.Properties.Contains("DefaultPage"))
            {
                var defaultPage = App.Current.Properties["DefaultPage"].ToString();

                try
                {
                    Uri url = new Uri(defaultPage);
                    return url;
                }
                catch (Exception)
                {
                    SetDefaultPage("https://smule.com");
                }
            }

            return new Uri("https://smule.com");
        }

    }
}
