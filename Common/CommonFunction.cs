using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Data;
using System.ComponentModel;
using System.Reflection;
namespace Common
{

    public class CommonFunction
    {
        #region Here we Handle the Exception,based on Error Number
        /// <summary>
        /// This HandleException function handle of All type of Excetpion, If we Ignore the exception return One otherwise Zero
        /// </summary>
        /// <param name="e">Base Exception class  </param>
        /// <returns>Handle exception return One otherwise Zero</returns>
        public static int HandleExption(Exception e)
        {


            string ErrorNumberOfException = System.Runtime.InteropServices.Marshal.GetHRForException(e).ToString();

            return (int)ThrowException(ErrorNumberOfException);
        }
        private static List<string> ErrorNumbers()
        {
            List<string> localErrorNumber = new List<string> { "-2147024864", "-2147024891","-2147024809" };
            return localErrorNumber;


        }
        private static CommonProperty.IsDefaultValue ThrowException(string errorNumber)
        {
            if (!string.IsNullOrEmpty(errorNumber))
            {
                var IsThrowExceptionOrHandleOwn = ErrorNumbers().Where(x => x == errorNumber).Select(s => s).FirstOrDefault();
                if (errorNumber == IsThrowExceptionOrHandleOwn)
                    return CommonProperty.IsDefaultValue.One;
                else
                    return CommonProperty.IsDefaultValue.Zero;
            }
            else
                return CommonProperty.IsDefaultValue.Zero;
        }
        #endregion

        #region Get Path based On Condition In below we are using Switch Condition..... JSB 25/11/2016
        public static string GetPathBaseOnCondition(string nameOfValueSelectCheckboxList)
        {
            return GetPathBasedOnCondtion(nameOfValueSelectCheckboxList);

        }
        private static string GetPathBasedOnCondtion(string values)
        {
            string TempValues = string.Empty;
            switch (values)
            {
                case "Temporary Internet File":
                    TempValues = AllPath.InernetNetCache;
                    break;
                case "History":
                    TempValues = AllPath.IHisotry;
                    break;
                case "Cookies":
                    TempValues = AllPath.IECookies;
                    break;
                case "Recently Typed URLs":
                    TempValues = AllPath.RecentlyTypeURLRegistry;
                    break;
                case "Index.dat files":
                    TempValues = AllPath.IEInddexDat;
                    break;
                case "Last Download Location":
                    //TempValues = AllPath.IECookies;
                    break;
                case "Autocomplete Form History":
                    TempValues = AllPath.AutoCompletePasswordRegistry;
                    break;
                case "Saved Passwords":
                    //TempValues = AllPath.IECookies;
                    break;
                case "Recent Documents":
                    //TempValues = AllPath.IECookies;
                    break;
                case "Run( in Start Menu)":
                    //TempValues = AllPath.IECookies;
                    break;
                case "Other Explorer MRUs":
                    //TempValues = AllPath.IECookies;
                    break;
                case "Thumbnail Cache":
                    //TempValues = AllPath.IECookies;
                    break;
                case "Taskbar Jump Lists":
                    //TempValues = AllPath.IECookies;
                    break;
               
                case "Netwrok Password":
                    //TempValues = AllPath.IECookies;
                    break;
                case "Empty Recycle Bin":
                    //TempValues = AllPath.IECookies;
                    break;
                case "Temporary Files":
                    //TempValues = AllPath.IECookies;
                    break;
                case "Clipboard":
                    //TempValues = AllPath.IECookies;
                    break;
                case "Memory Dumps":
                    //TempValues = AllPath.IECookies;
                    break;
                case "ChkDisk Files Fragments":
                    //TempValues = AllPath.IECookies;
                    break;
                case "Windows Log Files":
                    //TempValues = AllPath.IECookies;
                    break;
                case "Windows Error Reporting":
                    //TempValues = AllPath.IECookies;
                    break;
              
                case "DNS Chache":
                    //TempValues = AllPath.IECookies;
                    break;
                case "Font Chache":
                    //TempValues = AllPath.IECookies;
                    break;
                case "Start Menu Shortcuts":
                    //TempValues = AllPath.IECookies;
                    break;
                case "Desktop Shortcuts":
                    //TempValues = AllPath.IECookies;
                    break;
                case "Windows Event Logs":
                    //TempValues = AllPath.IECookies;
                    break;
                case "Old Prefatch data":
                    //TempValues = AllPath.IECookies;
                    break;
                case "Menu Order Cache":
                    //TempValues = AllPath.IECookies;
                    break;
                case "Try Notification cache":
                    //TempValues = AllPath.IECookies;
                    break;

                case "Windows Size/ Location Cache":
                    //TempValues = AllPath.IECookies;
                    break;
                case "Environment Path":
                    //TempValues = AllPath.IECookies;
                    break;
                case "User Assist History":
                    //TempValues = AllPath.IECookies;
                    break;
                case "Custom Files and Folders":
                    //TempValues = AllPath.IECookies;
                    break;
                case "Wipe free Sapce":
                    //TempValues = AllPath.IECookies;
                    break;
                default:
                    TempValues = CommonProperty.IsDefaultValue.Zero.ToString();
                    break;


            }
            return TempValues;

        } 
        #endregion


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


        public static void DeleteFileGetTheDirecotry(string filePath, bool isScanOnlyForSpaceCount, ref List<string> fileRecords, ref string sizeOfFile, List<string> ExtensionOfFile = null)
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
                    DeleteFiles(TempDirectoryInfo, isScanOnlyForSpaceCount, ExtensionOfFile);
                }
                if (IsDirectoryAvailable(TempDirectoryInfo))
                {
                    foreach (DirectoryInfo dir in TempDirectoryInfo.GetDirectories())
                    {
                        try
                        {
                            if (IsFileAvailable(dir))
                            {
                                DeleteFiles(dir, isScanOnlyForSpaceCount, ExtensionOfFile);
                            }
                            if (IsDirectoryAvailable(dir))
                            {
                                IsDeleteFile(dir, isScanOnlyForSpaceCount, ExtensionOfFile);
                            }
                            if (Directory.Exists(dir.FullName))
                            {
                                if ((!IsFileAvailable(dir)) && (!IsDirectoryAvailable(dir)))
                                {
                                    if (!isScanOnlyForSpaceCount)
                                    {
                                        try
                                        {
                                            dir.Delete(true);
                                        }
                                        catch (Exception e)
                                        {
                                            if (HandleExption(e) == (int)CommonProperty.IsDefaultValue.Zero)
                                                throw;
                                        }
                                    }
                                }
                            }
                        }
                        catch (Exception e)
                        {
                            if (HandleExption(e) == (int)CommonProperty.IsDefaultValue.Zero)
                                throw;
                        }
                    }
                }
                if (fileRecords.Count > (int)CommonProperty.IsDefaultValue.Zero)
                {
                    fileRecords.AddRange(DeleteListTempFile);
                }
                else
                    fileRecords = DeleteListTempFile;
                sizeOfFile = CommonInformation.TempraroyFileSpaceCount.ToString();
            }
            catch (Exception e)
            {
                if (HandleExption(e) == (int)CommonProperty.IsDefaultValue.Zero)
                    throw;
            }
        }
        private static void IsDeleteFile(DirectoryInfo directoryInfo, bool isScanOnlyForSpaceCount, List<string> ExtensionOfFile = null)
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
                                DeleteFiles(innerDirectoryInfo, isScanOnlyForSpaceCount, ExtensionOfFile);
                            }
                            if (IsDirectoryAvailable(innerDirectoryInfo))
                            {
                                IsDeleteFile(innerDirectoryInfo, isScanOnlyForSpaceCount, ExtensionOfFile);
                            }
                            if ((!IsFileAvailable(innerDirectoryInfo)) && (!IsDirectoryAvailable(innerDirectoryInfo)))
                            {
                                if (Directory.Exists(innerDirectoryInfo.FullName))
                                {
                                    if (TempFilePath != innerDirectoryInfo.FullName)
                                    {
                                        innerDirectoryInfo.Delete();
                                        IsDeleteFile(innerDirectoryInfo.Parent, isScanOnlyForSpaceCount, ExtensionOfFile);
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
                                    IsDeleteFile(directoryInfo.Parent, isScanOnlyForSpaceCount, ExtensionOfFile);
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
        private static void DeleteFiles(DirectoryInfo directoryInfo, bool isScanOnlyForSpaceCount, List<string> ExtensionOfFile = null)
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
                                        if (ExtensionOfFile != null)
                                        {
                                            foreach (string FileExtension in ExtensionOfFile)
                                            {
                                                if (file.Extension.ToLower() == FileExtension.ToLower())
                                                {

                                                    try
                                                    {
                                                        DeleteListTempFile.Add(file.Name);
                                                        CommonInformation.TempraroyFileSpaceCount += file.Length;
                                                        file.Delete();
                                                    }
                                                    catch (Exception e)
                                                    {

                                                        if (HandleExption(e) == (int)CommonProperty.IsDefaultValue.Zero)
                                                            throw;
                                                    }
                                                }
                                            }
                                        }
                                        else
                                        {
                                            try
                                            {
                                                DeleteListTempFile.Add(file.Name);
                                                CommonInformation.TempraroyFileSpaceCount += file.Length;
                                                file.Delete();
                                            }
                                            catch (Exception e)
                                            {

                                                if (HandleExption(e) == (int)CommonProperty.IsDefaultValue.Zero)
                                                    throw;
                                            }

                                        }
                                    }
                                }
                                else
                                {
                                    if (ExtensionOfFile != null)
                                    {
                                        foreach (string FileExtension in ExtensionOfFile)
                                        {
                                            if (file.Extension.ToLower() == FileExtension.ToLower())
                                            {

                                                DeleteListTempFile.Add(file.Name);
                                                CommonInformation.TempraroyFileSpaceCount += file.Length;
                                            }

                                        }
                                    }
                                    else
                                    {
                                        DeleteListTempFile.Add(file.Name);
                                        CommonInformation.TempraroyFileSpaceCount += file.Length;
                                    }

                                }
                            }
                        }
                        if ((!IsFileAvailable(directoryInfo)) && (!IsDirectoryAvailable(directoryInfo)))
                        {
                            if (Directory.Exists(directoryInfo.FullName))
                            {
                                try
                                {
                                    directoryInfo.Delete();
                                }
                                catch (Exception e)
                                {

                                    if (HandleExption(e) == (int)CommonProperty.IsDefaultValue.Zero)
                                        throw;
                                }
                                IsDeleteFile(directoryInfo.Parent, isScanOnlyForSpaceCount, ExtensionOfFile);
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
        public static bool IsFileAvailable(DirectoryInfo direcotoryInfo)
        {
            try
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
            catch(Exception e)
            {

                if (HandleExption(e) == (int)CommonProperty.IsDefaultValue.Zero)
                    throw;
                else
                    return false;                
            }
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


        #region Convert amount of Size in KB,MB and so On ..JSB 25/11/2016
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
        #endregion

        /// Get Size of RAM 
        /// 
        /// </summary>
        /// <param name="SizeOf"></param>
        /// <returns></returns>
        /// 
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

        #region Convert list to DataTable

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

        #endregion

        public static string ConvertTimeSpanToMinutsAndString(TimeSpan objTimeSpan)
        {
            string Min = string.Empty;
            if(objTimeSpan.Minutes>0)
            {
                Min = objTimeSpan.Minutes.ToString() + " Min ";

            }
            else
                Min=" 00 Min ";
            if(objTimeSpan.Seconds>0)
            {
                Min += objTimeSpan.Seconds.ToString() + " Sec ";
            }
            else
                Min+="00 Sec ";

            return Min;
        }

    }
}
