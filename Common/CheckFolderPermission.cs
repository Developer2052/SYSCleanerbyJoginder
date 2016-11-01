using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;

namespace Common
{
   public class CheckFolderPermission
    {
        public static bool IsAdmin()
        {
           return IsAdministrator();
        }

        private static bool IsAdministrator()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }
        public bool IsAccess(string path)
        {
            bool IsAccess=false;
         
            string NtAccountName = @"MyDomain\MyUserOrGroup";

            DirectoryInfo di = new DirectoryInfo(path);
            DirectorySecurity acl = di.GetAccessControl(AccessControlSections.All);
            AuthorizationRuleCollection rules = acl.GetAccessRules(true, true, typeof(NTAccount));

            //Go through the rules returned from the DirectorySecurity
            foreach (AuthorizationRule rule in rules)
            {
                //If we find one that matches the identity we are looking for
                if (rule.IdentityReference.Value.Equals(NtAccountName, StringComparison.CurrentCultureIgnoreCase))
                {
                    //Cast to a FileSystemAccessRule to check for access rights
                    if ((((FileSystemAccessRule)rule).FileSystemRights & FileSystemRights.WriteData) > 0)
                    {
                        IsAccess = true;
                    }
                    else
                    {
                        IsAccess = false;
                    }
                }
            }
            return IsAccess;
        }
        
    }
}
