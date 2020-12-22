using System.Windows.Controls;

using Sownloader.ViewModels;

namespace Sownloader.Views
{
    public partial class MasterDetailPage : Page
    {
        public MasterDetailPage(MasterDetailViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
