using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public class MemoryDumps
    {
        public static List<string> GetRecords()
        {
            List<string> Extension = new List<string> { ".dmp" };
            return Extension;
           
        }
    }
}