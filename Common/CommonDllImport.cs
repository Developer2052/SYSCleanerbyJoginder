using System;
using System.Collections.Generic;

using System.Runtime.InteropServices;
using System.Text;


namespace Common
{
    /// <summary>
    /// Main Class of DllImport
    /// Develop By :Joginder Singh 
    /// Dated : 17-10-2016
    /// </summary>
    /// 
    public class CommonDllImport
    {
      public enum RecycleFlag : int
        {
            SHERB_NOCONFIRMATION = 0x00000001, // No confirmation, when emptying
            SHERB_NOPROGRESSUI = 0x00000001, // No progress tracking window during the emptying of the recycle bin
            SHERB_NOSOUND = 0x00000004 // No sound when the emptying of the recycle bin is complete
        }

        /// <summary>
        /// Clear the RecycleBin
        /// Develop By Joginder 
        /// 
        /// </summary>
        /// <param name="hwnd"></param>
        /// <param name="pszRootPath"></param>
        /// <param name="dwFlags"></param>
        /// <returns></returns>
        [DllImport("Shell32.dll")]
       public static extern int SHEmptyRecycleBin(IntPtr hwnd, string pszRootPath, RecycleFlag dwFlags);


        /// <summary>
        /// Clear the DSN chache
        /// Develop by Joginder Singh
        /// Dated: 18-10-2016
        /// </summary>
        /// <returns> This is a returns type of Int </returns>
        [DllImport("dnsapi.dll", EntryPoint = "DnsFlushResolverCache")]
        public static extern UInt32 DnsFlushResolverCache();

      

    }
}
