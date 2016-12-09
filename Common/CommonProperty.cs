using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Management;
namespace Common
{

    public class BindApplicationAndWindowsUsingGridview
    {
       public string NameOfItems { get; set; }
       public string SizeOfFile { get; set; }
       public string CountOfFile { get; set; }
    }

    /// <summary>
    /// this class contains Common Property for used further used
    /// </summary>
    /// 
    
    public class CommonProperty : CommonConstantProperty
    {
        public static int EmptyReceyleBin = (int)IsDefaultValue.Zero;
        public const bool IsDelete = true;
    }
   public class ColumnsForDataTable:CommonResults
    {
        public string ColumnsName { get; set; }
      
    }
    public class CommonResults:AllPath
    {
        public static bool IsEmptyRecycle = false;
    }
    public enum Extension
    {
        Dat,
        Lnk

    }
    public enum TabName
    {
        Application,
        Windows
    }
    public class CommonConstantProperty:ColumnsForDataTable
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
}
