using System;
using System.Collections.Generic;
using System.IO;
using System.Management;
using System.Text;


namespace Common
{
    /// <summary>
    /// this class contains Common Property for used further used
    /// </summary>
    public class CommonProperty : CommonConstantProperty
    {
        public static int EmptyReceyleBin = (int)IsDefaultValue.Zero;
        public const bool IsDelete = true;
    }

    public class CommonResults
    {
        public static bool IsEmptyRecycle = false;
    }


    public class CommonConstantProperty
    {
        public enum IsDefaultValue
        {
            Zero,
            One,
            Two,
            Three

        }
        public enum VersionType
        {
            Test,
            Beta,
            Final
        }



    }

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

        public static bool DeleteFileGetTheDirecotry(string filePath)
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
        /// <summary>
        /// Get Size of RAM 
        /// </summary>
        /// <param name="SizeOf"></param>
        /// <returns></returns>
        /// 

        public static string GetSizeOfRAM()
        {
            string Query = "SELECT Capacity FROM Win32_PhysicalMemory";
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(Query);

            UInt64 Capacity = 0;
            foreach (ManagementObject WniPART in searcher.Get())
            {
                Capacity += Convert.ToUInt64(WniPART.Properties["Capacity"].Value);
            }
            return GetSizeOfRAM(Capacity).ToString();
        }
        private static UInt64 RAMSize = 0;
        public static UInt64 GetSizeOfRAM(UInt64 sizeOfRam)
        {
            if (sizeOfRam > (int)CommonConstantProperty.IsDefaultValue.Zero)
            {
                if (sizeOfRam > 1024)
                {
                    RAMSize = sizeOfRam / 1024;
                    GetSizeOfRAM(RAMSize);

                }
            }

            return RAMSize;

        }


        private static string Processor()
        {
            string NameOfProcessorName = string.Empty;
            ManagementObjectSearcher mos =
            new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor");
            foreach (ManagementObject mo in mos.Get())
            {
                NameOfProcessorName = Convert.ToString(mo["Name"]);
            }
            return NameOfProcessorName;
        }

        public static string GetProcessorName()
        {
            return Processor();
        }
    }
}
