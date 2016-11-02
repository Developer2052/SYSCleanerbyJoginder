using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Common
{
    public class AllPath
    {

        //**********************Google Chrome Path***********************//
        public static readonly string GooglePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\AppData\Local\Google\Chrome\User Data\Default\";
        //********************** Mozilla Firefox ***********************//

        public static readonly string MozilaPath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\AppData\Roaming\Mozilla\Firefox\";
        //********************** Opera *********************************//
        public static readonly string Opera1 = Environment.GetEnvironmentVariable("USERPROFILE") + @"\AppData\Local\Opera\Opera";
        public static readonly string Opera2 = Environment.GetEnvironmentVariable("USERPROFILE") + @"\AppData\Roaming\Opera\Opera";
        //*************************** Safari **************************//
        public static readonly string Safari1 = Environment.GetEnvironmentVariable("USERPROFILE") + @"\AppData\Local\Apple Computer\Safari";
        public static readonly string Safari2 = Environment.GetEnvironmentVariable("USERPROFILE") + @"\AppData\Roaming\Apple Computer\Safari";
        // ****************************** Internet Explorer *******************//
        public static readonly string IE1 = Environment.GetEnvironmentVariable("USERPROFILE") + @"\AppData\Local\Microsoft\Intern~1";
        public static readonly string IE2 = Environment.GetEnvironmentVariable("USERPROFILE") + @"\AppData\Local\Microsoft\Windows\History";
        public static readonly string IE3 = Environment.GetEnvironmentVariable("USERPROFILE") + @"\AppData\Local\Microsoft\Windows\Tempor~1";
        public static readonly string IE4 = Environment.GetEnvironmentVariable("USERPROFILE") + @"\AppData\Roaming\Microsoft\Windows\Cookies";
        
        // ********************************* Flash Player *********************//
        public static readonly string Flash = Environment.GetEnvironmentVariable("USERPROFILE") + @"\AppData\Roaming\Macromedia\Flashp~1";

        // ********************************* Current User In Local Mechine *********************//
        public const string CurrentUserInLocalMechine = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
        // ********************************* In Local Mechine ***********************************//

        public const string INLocalMechile = @"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall";

        // ********************************** User Profile Temprary Folder ************************//
        public static readonly string UserProfileTempFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        // *********************************** Short Cut Menu *************************************//
        public static readonly string StartMenuShortCut = System.Environment.GetFolderPath(Environment.SpecialFolder.StartMenu);

        // ************************************* Temprary folder WINDOWSKEY + R press and then type %TEMP%  ************************ //
        public static readonly string TempraryFolder = Path.GetTempPath();

        // ************************************** Internet Cache *********************** ///
        public static readonly string InernetNetCache = System.Environment.GetFolderPath(Environment.SpecialFolder.InternetCache);

        // ************************************* Recent Open program Shortcut ****************** //
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
        string DesktopShortcut = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);






    }
}
