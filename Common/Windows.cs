using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
  public  class _Windows
    {
        public string Key { get; set; }
        public string Value { get; set; }
         List<_Windows> WindowsProgramList { get; set; }
        public static List<_Windows> ListOfWindwosProgram()
         {
             return ListOfWindowsPrograms();

         }

        private static List<_Windows> ListOfWindowsPrograms()
        {
            List<_Windows> ListOfApplication = new List<_Windows>();
            ListOfApplication.Add(new _Windows { Key = "InterNet Explorer", Value = null });
            ListOfApplication.Add(new _Windows { Key = "InterNet Explorer", Value = "Temporary Internet Files" });
            ListOfApplication.Add(new _Windows { Key = "InterNet Explorer", Value = "History" });
            ListOfApplication.Add(new _Windows { Key = "InterNet Explorer", Value = "Cookies" });
            ListOfApplication.Add(new _Windows { Key = "InterNet Explorer", Value = "Recently Typed URLs" });
            ListOfApplication.Add(new _Windows { Key = "InterNet Explorer", Value = "Index.dat files" });
            ListOfApplication.Add(new _Windows { Key = "InterNet Explorer", Value = "Last Download Location" });
            ListOfApplication.Add(new _Windows { Key = "InterNet Explorer", Value = "Autocomplete Form History" });
            ListOfApplication.Add(new _Windows { Key = "InterNet Explorer", Value = "Saved Passwords" });
            ListOfApplication.Add(new _Windows { Key = "Windows", Value = null });
            ListOfApplication.Add(new _Windows { Key = "Windows", Value = "Recent Documents" });
            ListOfApplication.Add(new _Windows { Key = "Windows", Value = "Run( in Start Menu)" });
            ListOfApplication.Add(new _Windows { Key = "Windows", Value = "Other Explorer MRUs" });
            ListOfApplication.Add(new _Windows { Key = "Windows", Value = "Thumbnail Cache" });
            ListOfApplication.Add(new _Windows { Key = "Windows", Value = "Taskbar Jump Lists" });
            ListOfApplication.Add(new _Windows { Key = "Windows", Value = "Netwrok Password" });
            ListOfApplication.Add(new _Windows { Key = "System", Value = null });
            ListOfApplication.Add(new _Windows { Key = "System", Value = "Empty Recycle Bin" });
            ListOfApplication.Add(new _Windows { Key = "System", Value = "Temporary Files" });
            ListOfApplication.Add(new _Windows { Key = "System", Value = "Clipboard" });
            ListOfApplication.Add(new _Windows { Key = "System", Value = "Memory Dumps" });
            ListOfApplication.Add(new _Windows { Key = "System", Value = "ChkDisk Files Fragments" });
            ListOfApplication.Add(new _Windows { Key = "System", Value = "Windows Log Files" });
            ListOfApplication.Add(new _Windows { Key = "System", Value = "Windows Error Reporting" });
            ListOfApplication.Add(new _Windows { Key = "System", Value = "DNS Chache" });
            ListOfApplication.Add(new _Windows { Key = "System", Value = "Font Chache" });
            ListOfApplication.Add(new _Windows { Key = "System", Value = "Start Menu Shortcuts" });
            ListOfApplication.Add(new _Windows { Key = "System", Value = "Desktop Shortcuts" });
            ListOfApplication.Add(new _Windows { Key = "Advanced", Value = null });
            ListOfApplication.Add(new _Windows { Key = "Advanced", Value = "Windows Event Logs" });
            ListOfApplication.Add(new _Windows { Key = "Advanced", Value = "Old Prefatch data" });
            ListOfApplication.Add(new _Windows { Key = "Advanced", Value = "Menu Order Cache" });
            ListOfApplication.Add(new _Windows { Key = "Advanced", Value = "Try Notification cache" });
            ListOfApplication.Add(new _Windows { Key = "Advanced", Value = "Windows Size/ Location Cache" });
            ListOfApplication.Add(new _Windows { Key = "Advanced", Value = "Environment Path" });
            ListOfApplication.Add(new _Windows { Key = "Advanced", Value = "User Assist History" });
            ListOfApplication.Add(new _Windows { Key = "Advanced", Value = "Custom Files and Folders" });
            ListOfApplication.Add(new _Windows { Key = "Advanced", Value = "Wipe free Sapce" });
            return ListOfApplication;
        }

    }
}
