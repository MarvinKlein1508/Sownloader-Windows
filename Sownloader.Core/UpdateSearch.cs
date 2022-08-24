using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Sownloader.Core
{
    public class UpdateSearch
    {
        //const string versionURL = "https://www.sownloader.com/version.txt";

        //FileHandler.Logfile lgFile = new FileHandler.Logfile();
        //FileHandler.INIClass iniFile = new FileHandler.INIClass();

        //private bool showWindow;
        //private string latestVersionAvailable = "";

        //public event EventHandler UpdateSearchFinished;

        ///// <summary>
        ///// Konstruktor
        ///// </summary>
        //public UpdateSearch(bool showWindow = false)
        //{
        //    this.UpdateSearchFinished += UpdateSearch_UpdateSearchFinished;
        //    this.showWindow = showWindow;
        //}

        //#region "Events"
        //protected virtual void OnUpdateSearchFinished(object sender, EventArgs e)
        //{
        //    EventHandler handler = UpdateSearchFinished;
        //    if (handler != null)
        //    {
        //        handler(this, e);
        //    }
        //}
        //private void UpdateSearch_UpdateSearchFinished(object sender, EventArgs e)
        //{
        //    lgFile.WriteLog("Update version information was succussful:" + this.latestVersionAvailable, FileHandler.Logfile.LOGLEVEL.INFORMATION);
        //    iniFile.UpdateVersionInformation(this.latestVersionAvailable);
        //    this.IsUpdateAvailable();
        //}
        //#endregion
        //#region Update-Suche
        ///// <summary>
        ///// Die Methode holt sich die aktuellste Version aus der Datenbank
        ///// </summary>
        //public void SearchForUpdate()
        //{
        //    try
        //    {
        //        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        //        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(new Uri("https://sownloader.com/functions/getLatestVersion.php"));
        //        request.Credentials = CredentialCache.DefaultCredentials;
        //        request.UserAgent = "Sownloader/" + Application.ProductVersion;
        //        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        //        Stream dataStream = response.GetResponseStream();
        //        StreamReader reader = new StreamReader(dataStream);
        //        latestVersionAvailable = reader.ReadToEnd();
        //        reader.Close();
        //        dataStream.Close();
        //        response.Close();
        //    }
        //    catch (WebException wex)
        //    {
        //        lgFile.WriteLog(wex.Message, FileHandler.Logfile.LOGLEVEL.ERROR);
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }


        //    OnUpdateSearchFinished(this, new EventArgs());
        //}

        ///// <summary>
        ///// Die Methode ruft die installierte Version von Sownloader ab
        ///// </summary>
        ///// <returns>Installed Version</returns>
        //private Version InstalledVersion()
        //{
        //    return new Version(Application.ProductVersion);
        //}
        ///// <summary>
        ///// Die Methode formatiert den heruntergeladenen Versionstring
        ///// </summary>
        ///// <returns>Neueste Version</returns>
        //private Version LatestVersion()
        //{
        //    int major, minor, build;
        //    string[] ltVersion = latestVersionAvailable.Split('.');
        //    if (ltVersion.Length > 1)
        //    {
        //        major = Convert.ToInt32(ltVersion[0]);
        //        minor = Convert.ToInt32(ltVersion[1]);
        //        build = Convert.ToInt32(ltVersion[2]);
        //        return new Version(major, minor, build);
        //    }
        //    else
        //        return new Version(Application.ProductVersion);

        //}
        ///// <summary>
        ///// Die Methode ruft die aktuelle Version ab, welche bei automatischer Updatesuche nicht angezeigt werden soll
        ///// </summary>
        ///// <returns>Skip version</returns>
        //private Version SkipVersion()
        //{
        //    int smajor, sminor, sbuild;
        //    string[] skipVersion = iniFile.SKIPVERSION.Split('.');
        //    smajor = Convert.ToInt32(skipVersion[0]);
        //    sminor = Convert.ToInt32(skipVersion[1]);
        //    sbuild = Convert.ToInt32(skipVersion[2]);
        //    return new Version(smajor, sminor, sbuild);
        //}
        ///// <summary>
        ///// Die Methode prüft, ob eine neuere Version verfügbar ist
        ///// </summary>
        ///// <param name="ShowInfo"></param>
        //private void IsUpdateAvailable()
        //{
        //    if (InstalledVersion() < LatestVersion() && LatestVersion() != SkipVersion() || InstalledVersion() < LatestVersion() && this.showWindow)
        //    {
        //        UpdateWindow updatewindow = new UpdateWindow(latestVersionAvailable);
        //        updatewindow.ShowDialog();
        //    }
        //    else if (this.showWindow)
        //        MessageBox.Show("You are running the latest version of Sownloader", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


        //}

        //#endregion
    }
}
