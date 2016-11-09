using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public class _Applications
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public List<_Applications> ApplicationList { get; set; }

        public static List<_Applications> GetApplication()
        {
            return ApplicationLists();
        }


        private static List<_Applications> ApplicationLists()
        {
            List<_Applications> ListOfApplication = new List<_Applications>();
            ListOfApplication.Add(new _Applications { Key = "Opera", Value = null });
            ListOfApplication.Add(new _Applications { Key = "Opera", Value = "Internet Cache" });
            ListOfApplication.Add(new _Applications { Key = "Opera", Value = "Internet History" });
            ListOfApplication.Add(new _Applications { Key = "Opera", Value = "Cookies" });
            ListOfApplication.Add(new _Applications { Key = "Opera", Value = "Download History" });
            ListOfApplication.Add(new _Applications { Key = "Opera", Value = "Recently Typed URLs" });
            ListOfApplication.Add(new _Applications { Key = "Opera", Value = "Last Download Location" });
            ListOfApplication.Add(new _Applications { Key = "Opera", Value = "Session" });
            ListOfApplication.Add(new _Applications { Key = "Opera", Value = "Saved Form Information" });
            ListOfApplication.Add(new _Applications { Key = "Opera", Value = "Website Icons" });
            ListOfApplication.Add(new _Applications { Key = "Opera", Value = "Save Passwords" });
            ListOfApplication.Add(new _Applications { Key = "Opera", Value = "Compact Databases" });
            ListOfApplication.Add(new _Applications { Key = "Safari", Value = null });
            ListOfApplication.Add(new _Applications { Key = "Safari", Value = "Internet Cache" });
            ListOfApplication.Add(new _Applications { Key = "Safari", Value = "Internet History" });
            ListOfApplication.Add(new _Applications { Key = "Safari", Value = "Cookies" });
            ListOfApplication.Add(new _Applications { Key = "Safari", Value = "Internet Cache" });
            ListOfApplication.Add(new _Applications { Key = "Google Chrome", Value = null });
            ListOfApplication.Add(new _Applications { Key = "Google Chrome", Value = "Internet Cache" });
            ListOfApplication.Add(new _Applications { Key = "Google Chrome", Value = "Internet History" });
            ListOfApplication.Add(new _Applications { Key = "Google Chrome", Value = "Cookies" });
            ListOfApplication.Add(new _Applications { Key = "Google Chrome", Value = "Download History" });
            ListOfApplication.Add(new _Applications { Key = "Google Chrome", Value = "Recently Typed URLs" });
            ListOfApplication.Add(new _Applications { Key = "Google Chrome", Value = "Last Download Location" });
            ListOfApplication.Add(new _Applications { Key = "Google Chrome", Value = "Session" });
            ListOfApplication.Add(new _Applications { Key = "Google Chrome", Value = "Saved Form Information" });
            ListOfApplication.Add(new _Applications { Key = "Google Chrome", Value = "Website Icons" });
            ListOfApplication.Add(new _Applications { Key = "Google Chrome", Value = "Save Passwords" });
            ListOfApplication.Add(new _Applications { Key = "Google Chrome", Value = "Compact Databases" });
            ListOfApplication.Add(new _Applications { Key = "Utilities", Value = null });
            ListOfApplication.Add(new _Applications { Key = "Utilities", Value = "All Games and Song player" });
            return ListOfApplication;
        }

    }
}
