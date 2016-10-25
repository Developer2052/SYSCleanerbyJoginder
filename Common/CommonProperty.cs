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


        public static void GetAllInforationAboutSystem()
        {
            CommonInformation.MechineName = Environment.MachineName;
            CommonInformation.SoftwareVersionName = CommonConstantProperty.VersionType.Test.ToString();
            CommonInformation.WindowsBit = System.Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE");
            CommonInformation.SoftwareVersionNo = "1.K1P1";

           


             
        }

       
    }
}
