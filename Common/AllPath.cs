using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Microsoft.Web.Administration;

namespace Common
{
    public class AllPath
    {

        //**************** 
        public static readonly string RecycleBin = @"C:\$Recycle.Bin";

        //****************Thumb Cache  ****************
        public static readonly string WindowsThumbCache = string.Concat((Environment.GetFolderPath(Environment.SpecialFolder.Windows, Environment.SpecialFolderOption.None)), "\\Prefetch");


        public static readonly string MemoryDumps = Environment.GetEnvironmentVariable("USERPROFILE") + @"\AppData\Local\CrashDumps";

        public static readonly string MemoryDumpsWindows = Environment.GetFolderPath(Environment.SpecialFolder.Windows);

        //********************** Remote Desktop Cache ********************//
        public static readonly string RemoteDesktopCache = Environment.GetEnvironmentVariable("USERPROFILE") + @"\AppData\Local\Microsoft\Terminal Server Client\Cache";

        //**********************Google Chrome Path***********************//
        public static readonly string GooglePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\AppData\Local\Google\Chrome\User Data\Default\";
        public static readonly string GooglePathAllDirectroy = Environment.GetEnvironmentVariable("USERPROFILE") + @"\AppData\Local\Google\Chrome\User Data";
        public static readonly string GooglePathCache = Environment.GetEnvironmentVariable("USERPROFILE") + @"\AppData\Local\Google\Chrome\User Data\Default\Cache";
        


        //********************** Mozilla Firefox ***********************//

        public static readonly string MozilaPathRoaming = Environment.GetEnvironmentVariable("USERPROFILE") + @"\AppData\Roaming\Mozilla\Firefox\Profiles";
        public static readonly string MoziaPathDirecotry = Environment.GetEnvironmentVariable("USERPROFILE") + @"\AppData\Local\Mozilla\Firefox\Profiles";

        //********************** Opera *********************************//
        public static readonly string Opera1 = Environment.GetEnvironmentVariable("USERPROFILE") + @"\AppData\Local\Opera\Opera";
        public static readonly string Opera2 = Environment.GetEnvironmentVariable("USERPROFILE") + @"\AppData\Roaming\Opera\Opera";
        //*************************** Safari **************************//
        public static readonly string Safari1 = Environment.GetEnvironmentVariable("USERPROFILE") + @"\AppData\Local\Apple Computer\Safari";
        public static readonly string Safari2 = Environment.GetEnvironmentVariable("USERPROFILE") + @"\AppData\Roaming\Apple Computer\Safari";
        // ****************************** Internet Explorer *******************//
        // User
        public static readonly string AutoCompletePasswordRegistry = @"Software\Microsoft\Internet Explorer\IntelliForms\Storage1";
    // user
        public static readonly string AutoCompletePasswordSecondRegistry = @"Software\Microsoft\Internet Explorer\IntelliForms\Storage2";
       // User
        public static readonly string RecentlyTypeURLRegistry = @"Software\Microsoft\Internet Explorer\TypedUrls";
        public static readonly string IE1 = Environment.GetEnvironmentVariable("USERPROFILE") + @"\AppData\Local\Microsoft\Intern~1";
        public static readonly string IE2 = Environment.GetEnvironmentVariable("USERPROFILE") + @"\AppData\Local\Microsoft\Windows\History";
        public static readonly string IE3 = Environment.GetEnvironmentVariable("USERPROFILE") + @"\AppData\Local\Microsoft\Windows\Tempor~1";
        public static readonly string IE4 = Environment.GetEnvironmentVariable("USERPROFILE") + @"\AppData\Roaming\Microsoft\Windows\Cookies";

        public static readonly string IECookies = Environment.GetEnvironmentVariable("USERPROFILE") + @"\AppData\Local\Microsoft\Windows\INetCookies";
        public static readonly string InernetNetCache = System.Environment.GetFolderPath(Environment.SpecialFolder.InternetCache);
        public static readonly string InterNetTemparyFile = string.Concat(InernetNetCache, "\\IE");
        public static string IHisotry = Environment.GetEnvironmentVariable("USERPROFILE") + @"\AppData\Local\Microsoft\Intern~1\Recovery\Immersive\Active";
        public static string IEInddexDat = Environment.GetEnvironmentVariable("USERPROFILE") + @"\AppData\Local\Microsoft\Windows\WebCache";
 
        // *************** END here **********************//


        // ********************************* Flash Player *********************//
        public static readonly string FlashPlayerGetDataTempData=Environment.GetEnvironmentVariable("USERPROFILE") +@"\AppData\Roaming\Macromedia\Flash Player\#SharedObjects";
        public static readonly string Flash = Environment.GetEnvironmentVariable("USERPROFILE") + @"\AppData\Roaming\Macromedia\Flashp~1";

        // ********************************* Current User In Local Mechine *********************//
        public const string CurrentUserInLocalMechine = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
        // ********************************* In Local Mechine ***********************************//

        public const string INLocalMechile = @"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall";

        //******************* Office Recently File *****************\\
        public static readonly string OfficeRecentlyFile = Environment.GetEnvironmentVariable("USERPROFILE") + @"\AppData\Roaming\Microsoft\Office\Recent";


        //******************* Windows Media File Recently ************************//
        // User..
        public static readonly string WindowsMediaFileRecently=@"Software\Microsoft\MediaPlayer\Player\RecentFileList";
        // ********************************** User Profile Temprary Folder ************************//
        public static readonly string UserProfileTempFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

        //With Server 2008/Vista and up
        public static readonly string WindowsLogUP = Environment.GetFolderPath(Environment.SpecialFolder.Windows) + @"\system32\winevt\logs";


        // With Windows 2000/Server2003/Windows XP
        public static readonly string WindowsLogDownload = Environment.GetFolderPath(Environment.SpecialFolder.Windows) + @"\System32\Config";
       
       
        // *********************************** Short Cut Menu *************************************//
        public static readonly string StartMenuShortCut = System.Environment.GetFolderPath(Environment.SpecialFolder.StartMenu);

        // ************************************* Temprary folder WINDOWSKEY + R press and then type %TEMP%  ************************ //
        public static readonly string TempraryFolder = Path.GetTempPath();

        public static readonly string OldPrefetch = Environment.GetFolderPath(Environment.SpecialFolder.Windows) + "\\Prefetch";

        //**********************Network shortcut ************//
        public static readonly string NetworkShortcut = Environment.GetEnvironmentVariable("USERPROFILE") + @"\AppData\Roaming\Microsoft\Windows\Network Shortcuts";

        //******** Get the Recently Type File In RUN **********************//
        // Windows/Run Recently
        // Resitry Type: User
        public static readonly string RecentlyRunItemRegistry = @"Software\Microsoft\Windows\CurrentVersion\Explorer\RunMRU";

        // ************************************ Description: ComDlg32 recently opened/saved folders **********************//

        // User
        public static readonly string RecentlyOpenSavedFolderRegistry=@"Software\Microsoft\Windows\CurrentVersion\Explorer\ComDlg32\OpenSavePidlMRU";


        //********************************* Description: Recent Docs ***************//
        //User
        public static readonly string RecentDocs = @"Software\Microsoft\Windows\CurrentVersion\Explorer\RecentDocs";



        // ************************************* Recent Open program Shortcut ****************** //
        //Windows\Windows
        public static readonly string RecentItem = Environment.GetFolderPath(Environment.SpecialFolder.Recent);

        /// <summary>
        /// Windows Temprary Folder Like WINDOWSKEY + R press and then type "temp"
        /// </summary>
        public static readonly string WindowsTemprary = windowsTempFolder();
        public static string windowsTempFolder()
        {
            return Environment.GetEnvironmentVariable("TEMP", EnvironmentVariableTarget.Machine);
        }


        //*********************** Desktop Shortcut File ************************//
        public static readonly string DesktopShortcut = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);


       public static readonly string ThumbCache = Environment.GetFolderPath(Environment.SpecialFolder.Windows) + "\\Explorer";

        //************** IIS LOG FILE *************************//

        public static string IISLog()
        {


            //  ServerManager manager = new ServerManager();
            //  Site mySite = manager.Sites["Default Web Site"];
            //return mySite.LogFile.Directory + "\\W3svc" + mySite.Id.ToString();
            return "have";
        }

    }
}
