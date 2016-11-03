using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public class MemoryDumps
    {
        public static void GetRecords()
        {
            List<string> Extension = new List<string> { ".dmp" };
            var path = new List<string> { AllPath.MemoryDumps };
            List<string > CountofFile=new List<string>();
            string sizeofFile=string.Empty;
            foreach (string item in path)
            {
                CommonFunction.DeleteFileGetTheDirecotry(item, false, ref CountofFile, ref sizeofFile, Extension);
                
            }
        }
    }
}