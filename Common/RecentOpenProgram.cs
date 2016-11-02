using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public class RecentOpenProgram
    {
        public static void GetRecentCountAndSize(ref List<string> listofRecentFile, ref string SizeOfFile)
        {
            List<string> Extension = new List<string>{
            ".lnk"
        };
            
            CommonFunction.DeleteFileGetTheDirecotry(AllPath.RecentItem, true, ref listofRecentFile, ref SizeOfFile,Extension);
        }

    }
}
