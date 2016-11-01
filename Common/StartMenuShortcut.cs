using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Common
{
   public class StartMenuShortcut
    {
        public static void GetPathOfShortcut()
        {
            DirectoryInfo di = new DirectoryInfo(System.Environment.GetFolderPath(Environment.SpecialFolder.StartMenu));
        }
    }
}
