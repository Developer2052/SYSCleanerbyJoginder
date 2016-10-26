using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;

namespace Common
{
    public class CommonFunction
    {

        #region File Status Check Is locked OR Not
        /// <summary>
        /// Develop By Joginder Singh 
        /// Dated : 17-10-2016
        /// </summary>
        /// <param name="file">FileInfo is a parameters </param> 
        /// <returns></returns>
        public static bool IsFileLocked(FileInfo file)
        {
            FileStream stream = null;

            try
            {
                stream = file.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            }
            catch (IOException)
            {
                //the file is unavailable because it is:
                //still being written to
                //or being processed by another thread
                //or does not exist (has already been processed)
                return false;
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }

            //file is not locked
            return true;
        }
        #endregion

        #region Delete the file after check locked or Not

        public static bool DeleteFileGetTheDirecotry(string filePath, bool isScanOnlyForSpaceCount)
        {
            bool isDeleteFile = false;

            DirectoryInfo di = new DirectoryInfo(filePath);
            IsDeleteFiles(di);
            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                IsDeleteFile(dir);

                if (dir.GetDirectories().Length == (int)CommonConstantProperty.IsDefaultValue.Zero)
                    dir.Delete();

            }

            return isDeleteFile;
        }

        private static void IsDeleteFile(DirectoryInfo directoryInfo)
        {

            if (Directory.Exists(directoryInfo.FullName))
            {
                if (directoryInfo.GetDirectories().Length > (int)CommonConstantProperty.IsDefaultValue.Zero)
                {
                    foreach (DirectoryInfo innerDirectoryInfo in directoryInfo.GetDirectories())
                    {
                        IsDeleteFiles(innerDirectoryInfo);
                        IsDeleteFile(innerDirectoryInfo);
                    }
                }
                else
                {
                    IsDeleteFiles(directoryInfo);

                }
            }
        }

        private static void IsDeleteFiles(DirectoryInfo directoryInfo)
        {
            if (Directory.Exists(directoryInfo.FullName))
            {
                if (directoryInfo.GetFiles().Length == (int)CommonConstantProperty.IsDefaultValue.Zero &&
                    directoryInfo.GetDirectories().Length == (int)CommonConstantProperty.IsDefaultValue.Zero)
                {
                    directoryInfo.Delete();
                }
                else
                {

                    foreach (FileInfo file in directoryInfo.GetFiles())
                    {
                        if (CommonFunction.IsFileLocked(file) == CommonProperty.IsDelete)
                        {
                            file.Delete();
                            if (directoryInfo.GetFiles().Length == (int)CommonConstantProperty.IsDefaultValue.Zero)
                            {
                                directoryInfo.Delete();
                                IsDeleteFiles(directoryInfo.Parent);
                            }
                        }
                    }
                }
            }
        }

        #endregion

        #region Check Validate Text Values

        public static bool IsValidateTextValues(string values)
        {

            if (!string.IsNullOrEmpty(values) && !string.IsNullOrWhiteSpace(values))
            {
                return true;
            }
            else

                return false;
        }

        #endregion





        /// Get Size of RAM 
        /// 
        /// </summary>
        /// <param name="SizeOf"></param>
        /// <returns></returns>
        /// 

        public static void exectAmountOfData(UInt64 AmountValues)
        {
            if (AmountValues > 1024)
            {

                AmountValues = AmountValues / 1024;

                //  }

            }
            else
            {

            }

            CommonInformation.SizeOfRam = AmountValues.ToString();



        }


        public static UInt64 SizeOfRam()
        {
            string Query = "SELECT Capacity FROM Win32_PhysicalMemory";
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(Query);

            UInt64 Capacity = 0;
            foreach (ManagementObject WniPART in searcher.Get())
            {
                Capacity += Convert.ToUInt64(WniPART.Properties["Capacity"].Value);
            }

            return Capacity;
        }


        public static void GetAllInforationAboutSystem()
        {
            CommonInformation.MechineName = Environment.MachineName;
            CommonInformation.SoftwareVersionName = CommonConstantProperty.VersionType.Test.ToString();
            CommonInformation.WindowsBit = System.Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE");
            CommonInformation.SoftwareVersionNo = "1.K1P1";

        }


        #region Get All Application list Jogi 26-10-2016
        /// Get All Application List
        /// 
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<string> GetAllApplicationList()
        {
            return GetInstalledApps();

        }
        static List<string> ApplicationList = null;
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
                const string CurrentUserInLocalMechile = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
                const string INLocalMechile = @"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall";
                string displayName = string.Empty;
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(CurrentUserInLocalMechile))
                {
                    GetKey(key);
                }
                //using (RegistryKey key = Registry.LocalMachine.OpenSubKey(CurrentUserInLocalMechile))
                //{
                //    GetKey(key);
                //}
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(INLocalMechile))
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

        #region Split the Control ID for Hide and Show panel...26-10-2016

        public static string[] GetControlId(string controlId)
        {
            return GetControlIds(controlId);

        }

        private static string[] GetControlIds(string controlId)
        {
            try
            {
                string[] SplitsControlsId = controlId.Split('_');
                if (SplitsControlsId.Length == (int)CommonProperty.IsDefaultValue.Zero)
                {
                    throw new Exception("Please check Valid Control ID");

                }
                return SplitsControlsId;
            }
            catch (Exception)
            {

                throw;
            }



        }
        #endregion


    }
}
