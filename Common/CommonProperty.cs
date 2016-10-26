using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Management;


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

  
}
