using Shell32;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Common
{
    public class GetRecycleBinFiles
    {
        public static double GetSize(FolderItem folderItem)
        {
            //check if it's a folder, if it's not then return it's size
            if (!folderItem.IsFolder)
                return (double)folderItem.Size;

            //create a new Shell32.Folder item
            var folder = (Folder)folderItem.GetFolder;

            double size = 0;

            //since we're here we're dealing with a folder, so now we will loop
            //through everything in it and get it's size, thus calculating the
            //overall size of the folder
            foreach (FolderItem2 f in folder.Items())
                size += GetSize(f);

            //return the size
            return size;

        }

        public static RecycleBinItem GetRecycleBinItems()
        {
            RecycleBinItem ObjRecyleBinItem = new RecycleBinItem();
            try
            {
                //create a new isntance of the Shell32 interface
                Shell shell = new Shell();
                List<RecycleBinItem> list = new List<RecycleBinItem>();

                //create a folder item to our Recycle Bin
                Folder recycleBin = shell.NameSpace(10);

                //now let's loop through all the Items in our Folder object
                //and add them to a generic list
                foreach (FolderItem2 f in recycleBin.Items())
                {
                    ObjRecyleBinItem.CountOfFile++;
                    //list.Add(
                    //        new RecycleBinItem
                    //        {

                    //FileName = f.Name,
                    //FileType = f.Type,
                    ObjRecyleBinItem.CountOfSize += f.Size;
                    //});
                }

                //release
                Marshal.FinalReleaseComObject(shell);

                //return the list
               return ObjRecyleBinItem;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



    }

    public class RecycleBinItem
    {
        public string FileName { get; set; }

        public string FileType { get; set; }

        public string FileSize { get; set; }
        public int CountOfFile { get; set; }
        public long CountOfSize { get; set; }
    }

}
