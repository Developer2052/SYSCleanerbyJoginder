using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Common
{
   public class StartMenuShortcut
    {
        public static string GetPathOfShortcut()
        {
            return (System.Environment.GetFolderPath(Environment.SpecialFolder.StartMenu));
        }
    }
}
