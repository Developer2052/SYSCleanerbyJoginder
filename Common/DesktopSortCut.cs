using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Common
{
    public class DesktopSortCut
    {
       
        public static void GetDesktopFileCount(DirectoryInfo direcotryInfo,bool IsDelete,out int CountOfFile)
        {
            const string extension = ".LNK";
            const string Extension = ".URL";
            int Temp = 0;
            if (CommonFunction.IsFileAvailable(direcotryInfo))
            {
                foreach (FileInfo file in direcotryInfo.GetFiles())
                {
                    if (file.Extension.ToLower() == extension.ToLower() || file.Extension.ToLower() == Extension.ToLower())
                    {
                        Temp += 1;
                        if (IsDelete)
                            file.Delete();
                    }
                    else
                    {
                        Temp += 0;
                    }

                }

            }
            else
                Temp += 0;
            CountOfFile = Temp;
        }
    }
}
