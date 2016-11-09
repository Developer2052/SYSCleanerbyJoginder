using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
  public  class GetAllApplicationLists
    {
        #region Get All Application list Jogi 26-10-2016
      static List<string> ApplicationList = null;
        /// Get All Application List
        /// 
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<string> GetAllApplicationList()
        {
            return GetInstalledApps();
        }
      
        /// <summary>
        /// Get All Install Apps
        /// Worked By JSB
        /// Dated : 25-10-2016
        /// </summary>
        /// <returns></returns>
        private static List<string> GetInstalledApps()
        {
            try
            {
                ApplicationList = new List<string>();
                string displayName = string.Empty;
                string CurrentUserInLocationMechine = AllPath.CurrentUserInLocalMechine;
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(CurrentUserInLocationMechine))
                {
                    GetKey(key);
                }
                //using (RegistryKey key = Registry.LocalMachine.OpenSubKey(CurrentUserInLocalMechile))
                //{
                //    GetKey(key);
                //}
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(AllPath.INLocalMechile))
                {
                    GetKey(key);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ApplicationList;
        }
        private static void GetKey(RegistryKey key)
        {
            foreach (string skName in key.GetSubKeyNames())
            {
                using (RegistryKey sk = key.OpenSubKey(skName))
                {
                    try
                    {
                        if (sk.GetValue("DisplayName") != null)
                        {
                            if (!ApplicationList.Exists(e => e.Contains(sk.GetValue("DisplayName").ToString())))
                                ApplicationList.Add(sk.GetValue("DisplayName").ToString());
                        }
                    }
                    catch (Exception ex)
                    { }
                }
            }
        }
        #endregion
    }
}
