using Shell32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Common;
namespace Common
{
    public class Recycle_Bin
    {
        public  long SizeOfFiles { get; set; }
        public  void GetPath(ref List<string> TotalFile,ref string SizeOfFile)
        {
            
            Shell shell = new Shell();
            Folder folder = shell.NameSpace(0x000a);
            
           
            foreach (FolderItem2 item in folder.Items())
            {
                TotalFile.Add(item.Name);
                CalculateSize(item);
            }
            SizeOfFile =SizeOfFiles.ToString();
            Marshal.FinalReleaseComObject(shell);
        }
        private void CalculateSize(FolderItem obj)
        {

            if (!obj.IsFolder)
            {
                SizeOfFiles += Convert.ToInt64(obj.Size);
                return;
            }

            Folder recycleBin = (Folder)obj.GetFolder;



            foreach (FolderItem2 item in recycleBin.Items())
                SizeOfFiles +=Convert.ToInt64(item.Size);


        }


    }
}
