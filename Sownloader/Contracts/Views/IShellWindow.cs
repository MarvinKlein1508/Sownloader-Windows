using System.Windows.Controls;

namespace Sownloader.Contracts.Views
{
    public interface IShellWindow
    {
        Frame GetNavigationFrame();

        void ShowWindow();

        void CloseWindow();
    }
}
