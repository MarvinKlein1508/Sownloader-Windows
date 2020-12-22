using System;
using System.Windows.Input;

using Microsoft.Extensions.Options;

using Sownloader.Contracts.Services;
using Sownloader.Contracts.ViewModels;
using Sownloader.Helpers;
using Sownloader.Models;
using Sownloader.Views;

namespace Sownloader.ViewModels
{
    // TODO WTS: Change the URL for your privacy policy in the appsettings.json file, currently set to https://YourPrivacyUrlGoesHere
    public class SettingsViewModel : Observable, INavigationAware
    {
        private readonly AppConfig _appConfig;
        private readonly IThemeSelectorService _themeSelectorService;
        private readonly ISystemService _systemService;
        private readonly IApplicationInfoService _applicationInfoService;
        private readonly IBitrateSelectorServices _bitrateSelectorService;
        private readonly IDefaultPageService _defaultPageService;
        private readonly INavigationService _navigationService;
        private AppTheme _theme;
        private string _versionDescription;

        private ICommand? _setThemeCommand;
        private ICommand? _setBitrateCommand;
        private ICommand? _privacyStatementCommand;
        private ICommand? _helpCommand;
        private ICommand? _navigateToInfoCommand;
        private ICommand? _newsCommand;
        


        public AppTheme Theme
        {
            get { return _theme; }
            set { Set(ref _theme, value); }
        }

        public string VersionDescription
        {
            get { return _versionDescription; }
            set { Set(ref _versionDescription, value); }
        }

        private string _bitrate;

        public string Bitrate
        {
            get { return _bitrate; }
            set { Set(ref _bitrate, value); }
        }

        private string _defaultPage;

        public string DefaultPage
        {
            get { return _defaultPage; }
            set
            {
                Set(ref _defaultPage, value);
                _defaultPageService.SetDefaultPage(value);
            }
        }



        public ICommand SetThemeCommand => _setThemeCommand ?? (_setThemeCommand = new RelayCommand<string>(OnSetTheme));
        public ICommand SetBitrateCommand => _setBitrateCommand ?? (_setBitrateCommand = new RelayCommand<string>(OnSetBitrate));
        public ICommand PrivacyStatementCommand => _privacyStatementCommand ?? (_privacyStatementCommand = new RelayCommand(OnPrivacyStatement));
        public ICommand HelpCommand => _helpCommand ?? (_helpCommand = new RelayCommand(OnHelp));
        public ICommand NewsCommand => _newsCommand ?? (_newsCommand = new RelayCommand(OnNews));
        public ICommand NavigateToInfoCommand => _navigateToInfoCommand ?? (_navigateToInfoCommand = new RelayCommand(NavigateToInfo));
        public SettingsViewModel(IOptions<AppConfig> appConfig, IThemeSelectorService themeSelectorService, ISystemService systemService, IApplicationInfoService applicationInfoService, IBitrateSelectorServices bitrateSelectorService, IDefaultPageService defaultPageService, INavigationService navigationService)
        {
            _appConfig = appConfig.Value;
            _themeSelectorService = themeSelectorService;
            _systemService = systemService;
            _applicationInfoService = applicationInfoService;
            _bitrateSelectorService = bitrateSelectorService;
            _defaultPageService = defaultPageService;
            _navigationService = navigationService;
        }

        public void OnNavigatedTo(object parameter)
        {
            VersionDescription = $"Sownloader - {_applicationInfoService.GetVersion()}";
            Theme = _themeSelectorService.GetCurrentTheme();
            Bitrate = _bitrateSelectorService.GetCurrentBitrate();
            DefaultPage = _defaultPageService.GetDefaultPage().AbsoluteUri;
        }

        public void OnNavigatedFrom()
        {
        }

        private void OnSetTheme(string themeName)
        {
            var theme = (AppTheme)Enum.Parse(typeof(AppTheme), themeName);
            _themeSelectorService.SetTheme(theme);
        }

        private void OnSetBitrate(string bitrate)
        {
            _bitrateSelectorService.SetBitrate(bitrate);
        }

        private void NavigateToInfo()
        {
            _navigationService.NavigateTo(typeof(SettingsInfoViewModel).FullName);
        }
        private void OnPrivacyStatement()
            => _systemService.OpenInWebBrowser(_appConfig.PrivacyStatement);

        private void OnHelp()
            => _systemService.OpenInWebBrowser(_appConfig.HelpLink);
        private void OnNews()
            => _systemService.OpenInWebBrowser(_appConfig.NewsLink);
    }
}
