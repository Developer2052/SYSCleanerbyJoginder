using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Common
{
   public class GoogleChormeContainer
    {
      
        public static CommonProperty.IsDefaultValue CheckGoogleRuning()
        {
            Process[] chromeInstances = Process.GetProcessesByName("chrome");
            if (chromeInstances.Length > 0)
            {
                return CommonProperty.IsDefaultValue.One;
            }
            else
            {
                return CommonProperty.IsDefaultValue.Zero;
            }
        }
    }
}
