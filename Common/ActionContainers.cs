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
            string TempraryFolderPath =@"F:\Testing - Copy";    // Path.GetTempPath();
            string Tees =Environment.GetFolderPath( Environment.SpecialFolder.Cookies);

            string TEst = Environment.GetFolderPath(Environment.SpecialFolder.InternetCache);
            if (Directory.Exists(TEst))
            {
                List<string> ListOfFileName = new List<string>();
                string FileOfSize = string.Empty;
                string St = DateTime.Now.ToLongTimeString();
                CommonFunction.DeleteFileGetTheDirecotry(TEst, false, out ListOfFileName, out FileOfSize);
                string Stt = DateTime.Now.ToLongTimeString();
            }

        }
    }
}
