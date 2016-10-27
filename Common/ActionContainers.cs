using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Common
{
  public  class ActionContainers
    {
        public void GetTemporaryFileDetails()
        {
            string TempraryFolderPath = Path.GetTempPath();
            if (Directory.Exists(TempraryFolderPath))
            {
                List<string> ListOfFileName = new List<string>();
                string FileOfSize = string.Empty;
                CommonFunction.DeleteFileGetTheDirecotry(TempraryFolderPath, false, out ListOfFileName, out FileOfSize);
            }

        }
    }
}
