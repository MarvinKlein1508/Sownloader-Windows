using Sownloader.Core;
using System.Xml.Serialization;

namespace Sownloader
{
    internal static class Program
    {
        public static readonly string APPDATA_PATH = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Sownloader");
        public static readonly string SOWNLOADER_SETTINGS_PATH = Path.Combine(APPDATA_PATH, "settings.xml");
        public static readonly string UPDATE_PATH = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "update.bat");
        
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Load Sownloader settings
            
            if(!Directory.Exists(APPDATA_PATH))
            {
                Directory.CreateDirectory(APPDATA_PATH);
            }

            if(!Directory.Exists(SownloaderController.COVER_PATH))
            {
                Directory.CreateDirectory(SownloaderController.COVER_PATH);
            }

            SownloaderSettings settings = new SownloaderSettings();

            if(!File.Exists(SOWNLOADER_SETTINGS_PATH))
            {
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
    }
}