using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Common
{
    class ActionContainers
    {
        private void GetTemporaryFileDetails()
        {
            string TempraryFolderPath = Path.GetTempPath();
            if (Directory.Exists(TempraryFolderPath))
            {
                CommonFunction.DeleteFileGetTheDirecotry(TempraryFolderPath,true);
            }

        }
    }
}
