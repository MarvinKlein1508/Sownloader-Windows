using System.Windows.Controls;

using Sownloader.ViewModels;

namespace Sownloader.Views
{
    public partial class SettingsPage : Page
    {
        private readonly SettingsViewModel _viewModel;

        public SettingsPage(SettingsViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
            _viewModel = viewModel;
        }

        private void Hyperlink_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            
        }
    }
}
