using Sownloader.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Sownloader.Views
{
    /// <summary>
    /// Interaktionslogik für SettingsPageInfo.xaml
    /// </summary>
    public partial class SettingsInfoPage : Page
    {
        public SettingsInfoPage(SettingsInfoViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
