using System;
using System.Windows.Controls;
using Microsoft.Web.WebView2.Wpf;
using Sownloader.ViewModels;

namespace Sownloader.Views
{
    public partial class MainPage : Page
    {
        private readonly MainViewModel _viewModel;

        public MainPage(MainViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
            _viewModel = viewModel;
            _viewModel.Initialize(webView);
        }

        private void OnNavigationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
        { 
            _viewModel.OnNavigationCompleted(e);
        }

        private void UrlTextBox_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if(e.Key == System.Windows.Input.Key.Enter)
            {
                string url = UrlTextBox.Text;
                if(!url.StartsWith("https://") && !url.StartsWith("http://"))
                {
                    url = $"https://{url}";
                }

                if(Uri.TryCreate(url, UriKind.Absolute, out Uri? uri) && uri is not null)
                {
                    webView.Source = uri;
                }
            }
        }
    }
}
