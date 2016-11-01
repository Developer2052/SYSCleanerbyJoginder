using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Data;
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
        static List<string> DeleteListTempFile = null;
        static string TempFilePath = string.Empty;
        public static void DeleteFileGetTheDirecotry(string filePath, bool isScanOnlyForSpaceCount, out List<string> deleteFileRecords, out string sizeOfFile)
        {
            try
            {
                TempFilePath = filePath;
                DeleteListTempFile = new List<string>();
                CommonInformation.TempraroyFileSpaceCount = new long();
                DirectoryInfo TempDirectoryInfo = new DirectoryInfo(filePath);
                // Check In Direcotory Files is there
                if (IsFileAvailable(TempDirectoryInfo))
                {
                    DeleteFiles(TempDirectoryInfo, isScanOnlyForSpaceCount);
                }
                if (IsDirectoryAvailable(TempDirectoryInfo))
                {
                    foreach (DirectoryInfo dir in TempDirectoryInfo.GetDirectories())
                    {
                        if (IsFileAvailable(dir))
                        {
                            DeleteFiles(dir, isScanOnlyForSpaceCount);
                        }
                        if (IsDirectoryAvailable(dir))
                        {
                            IsDeleteFile(dir, isScanOnlyForSpaceCount);
                        }
                        if (Directory.Exists(dir.FullName))
                        {
                            if ((!IsFileAvailable(dir)) && (!IsDirectoryAvailable(dir)))
                            {
                                if (!isScanOnlyForSpaceCount)
                                    dir.Delete(true);
                            }
                        }
                    }
                }
                deleteFileRecords = DeleteListTempFile;
                sizeOfFile = GetFileSize(CommonInformation.TempraroyFileSpaceCount);
            }
            catch (Exception)
            {
                throw;
            }
        }
        private static void IsDeleteFile(DirectoryInfo directoryInfo, bool isScanOnlyForSpaceCount)
        {
            try
            {
                if (Directory.Exists(directoryInfo.FullName))
                {
                    if (IsDirectoryAvailable(directoryInfo))
                    {
                        foreach (DirectoryInfo innerDirectoryInfo in directoryInfo.GetDirectories())
                        {
                            if (IsFileAvailable(innerDirectoryInfo))
                            {
                                DeleteFiles(innerDirectoryInfo, isScanOnlyForSpaceCount);
                            }
                            if (IsDirectoryAvailable(innerDirectoryInfo))
                            {
                                IsDeleteFile(innerDirectoryInfo, isScanOnlyForSpaceCount);
                            }
                            if ((!IsFileAvailable(innerDirectoryInfo)) && (!IsDirectoryAvailable(innerDirectoryInfo)))
                            {
                                if (Directory.Exists(innerDirectoryInfo.FullName))
                                {
                                    if (TempFilePath != innerDirectoryInfo.FullName)
                                    {
                                        innerDirectoryInfo.Delete();
                                        IsDeleteFile(innerDirectoryInfo.Parent, isScanOnlyForSpaceCount);
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        if ((!IsFileAvailable(directoryInfo)) && (!IsDirectoryAvailable(directoryInfo)))
                        {
                            if (Directory.Exists(directoryInfo.FullName))
                            {
                                if (TempFilePath != directoryInfo.FullName)
                                {
                                    directoryInfo.Delete();
                                    IsDeleteFile(directoryInfo.Parent, isScanOnlyForSpaceCount);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        private static void DeleteFiles(DirectoryInfo directoryInfo, bool isScanOnlyForSpaceCount)
        {
            try
            {
                // Check Direcotry exists here... JSB 26-10-2016
                if (Directory.Exists(directoryInfo.FullName))
                {
                    /// In this IF condition we are checked here, in Direcotory have no files or sub direcotory or Folder 
                    if ((!IsFileAvailable(directoryInfo)) && (!IsDirectoryAvailable(directoryInfo)))
                    {
                        if (!isScanOnlyForSpaceCount)
                            directoryInfo.Delete();
                    }
                    else
                    {
                        foreach (FileInfo file in directoryInfo.GetFiles())
                        {
                            if (CommonFunction.IsFileLocked(file) == CommonProperty.IsDelete)
                            {
                                // check User want scan or delete file..
                                if (!isScanOnlyForSpaceCount)
                                {
                                    if (File.Exists(file.FullName))
                                    {
                                        DeleteListTempFile.Add(file.Name);
                                        CommonInformation.TempraroyFileSpaceCount += file.Length;
                                        file.Delete();
                                    }
                                }
                                else
                                {
                                    DeleteListTempFile.Add(file.Name);
                                    CommonInformation.TempraroyFileSpaceCount += file.Length;
                                }
                            }
                        }
                        if ((!IsFileAvailable(directoryInfo)) && (!IsDirectoryAvailable(directoryInfo)))
                        {
                            if (Directory.Exists(directoryInfo.FullName))
                            {
                                directoryInfo.Delete();
                                IsDeleteFile(directoryInfo.Parent, isScanOnlyForSpaceCount);
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        private static bool IsFileAvailable(DirectoryInfo direcotoryInfo)
        {
            if (Directory.Exists(direcotoryInfo.FullName))
            {
                if (direcotoryInfo.GetFiles().Length != (int)CommonConstantProperty.IsDefaultValue.Zero)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
        private static bool IsDirectoryAvailable(DirectoryInfo direcotoryInfo)
        {
            if (Directory.Exists(direcotoryInfo.FullName))
            {
                if (direcotoryInfo.GetDirectories().Length != (int)CommonConstantProperty.IsDefaultValue.Zero)
                    return true;
                else
                    return false;
            }
            else
                return false;
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
        // Returns the human-readable file size for an arbitrary, 64-bit file size 
        // The default format is "0.### XB", e.g. "4.2 KB" or "1.434 GB"
        public static string GetFileSize(long i)
        {
            // Get absolute value
            long absolute_i = (i < 0 ? -i : i);
            // Determine the suffix and readable value
            string suffix;
            double readable;
            if (absolute_i >= 0x1000000000000000) // Exabyte
            {
                suffix = "EB";
                readable = (i >> 50);
            }
            else if (absolute_i >= 0x4000000000000) // Petabyte
            {
                suffix = "PB";
                readable = (i >> 40);
            }
            else if (absolute_i >= 0x10000000000) // Terabyte
            {
                suffix = "TB";
                readable = (i >> 30);
            }
            else if (absolute_i >= 0x40000000) // Gigabyte
            {
                suffix = "GB";
                readable = (i >> 20);
            }
            else if (absolute_i >= 0x100000) // Megabyte
            {
                suffix = "MB";
                readable = (i >> 10);
            }
            else if (absolute_i >= 0x400) // Kilobyte
            {
                suffix = "KB";
                readable = i;
            }
            else
            {
                return i.ToString("0 B"); // Byte
            }
            // Divide by 1024 to get fractional value
            readable = (readable / 1024);
            // Return formatted number with suffix
            return readable.ToString("0.### ") + suffix;
        }
        public static int Zero()
        {
            return (int)CommonProperty.IsDefaultValue.Zero;
        }
        static DataTable Temptable = null;
        private static void ReturnDataTableWithColumns(List<ColumnsForDataTable> ObjListofColumn)
        {
            if (ObjListofColumn == null)
                throw new ArgumentNullException("No Allowed list of Columns");
            if (Temptable != null)
                foreach (ColumnsForDataTable item in ObjListofColumn)
                {
                    Temptable.Columns.Add(item.ColumnsName);
                }
        }

        public static DataTable ConvertDictionaryToTable(Dictionary<string, string> ObjDictionary)
        {
            return ConvertDictionaryToDataTable(ObjDictionary);
        }

        private static DataTable ConvertDictionaryToDataTable(Dictionary<string, string> ObjDictionary)
        {
            DataTable ReturnDataTable = new DataTable("CreateTempTable");
            if (ObjDictionary == null)
            {
                throw new ArgumentNullException("No allowed of Parameters");

            }

            if (ObjDictionary.Count > Zero())
            {
                Temptable = new DataTable();
                List<ColumnsForDataTable> listColumnsForTable = new List<ColumnsForDataTable>();
                listColumnsForTable.Add(new ColumnsForDataTable { ColumnsName = "ProgramName" });
                listColumnsForTable.Add(new ColumnsForDataTable { ColumnsName = "ProgramPath" });
                ReturnDataTableWithColumns(listColumnsForTable);
                foreach (var item in ObjDictionary)
                {
                    Temptable.Rows.Add(new Object[]{
                item.Key,
                item.Value
           });
                }
            }
            return Temptable;
        }
    }
}
