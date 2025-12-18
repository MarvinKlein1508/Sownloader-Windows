using Microsoft.Extensions.Configuration;
using Serilog;
using Sownloader.Core;

namespace Sownloader
{
    internal static class Program
    {
        public static readonly string APPDATA_PATH = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Sownloader");
        public static readonly string SOWNLOADER_SETTINGS_PATH = Path.Combine(APPDATA_PATH, "settings.xml");
        public static readonly string UPDATE_PATH = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "update.bat");
        public static readonly string LOGFILE = Path.Combine(APPDATA_PATH, "sownloader.log");
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {



            // Load Sownloader settings

            if (!Directory.Exists(APPDATA_PATH))
            {
                Directory.CreateDirectory(APPDATA_PATH);
            }

            // Setup Serilog
            // Needs to be done after APPDATA creation, otherwise the logfile cannot be written
            var builder = new ConfigurationBuilder();
            BuildConfig(builder);

            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(builder.Build())
                .Enrich.FromLogContext()
                .WriteTo.File(LOGFILE, rollingInterval: RollingInterval.Day, retainedFileTimeLimit: TimeSpan.FromDays(14))
                .WriteTo.Console()
                .CreateLogger();

            if (!Directory.Exists(SownloaderController.COVER_PATH))
            {
                Log.Information("Create COVER_PATH: {path}", SownloaderController.COVER_PATH);
                Directory.CreateDirectory(SownloaderController.COVER_PATH);
            }

            SownloaderSettings settings = new SownloaderSettings();

            if (!File.Exists(SOWNLOADER_SETTINGS_PATH))
            {
                Log.Information("No configuration found. Create default configuration.");
                settings.Save(SOWNLOADER_SETTINGS_PATH);
            }
            else
            {
                settings = SownloaderSettings.Read(SOWNLOADER_SETTINGS_PATH);
            }


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new WelcomeForm(settings));
        }

        private static void BuildConfig(IConfigurationBuilder builder)
        {
            builder.SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appSettings.json", optional: false, reloadOnChange: true)
                .AddEnvironmentVariables();
        }
    }
}