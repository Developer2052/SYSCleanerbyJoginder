using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
   public class RemotDesktopCache
    {
      public static void GetAndDelete()
       {
          List<string> listofFile=new List<string>();
          string sizeoffile=string.Empty;
          List<string> nameofExtension=new List<string>{".bin"};
          CommonFunction.DeleteFileGetTheDirecotry(AllPath.RemoteDesktopCache, true, ref listofFile, ref sizeoffile,nameofExtension);

       }

    }
}
