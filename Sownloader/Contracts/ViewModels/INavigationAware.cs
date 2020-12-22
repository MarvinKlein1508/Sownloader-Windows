namespace Sownloader.Contracts.ViewModels
{
    public interface INavigationAware
    {
        void OnNavigatedTo(object parameter);

        void OnNavigatedFrom();
    }
}
