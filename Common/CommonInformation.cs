using System;
using System.Collections.Generic;

using System.Text;


namespace Common
{
    public class CommonInformation
    {
        public static string MechineName { get; set; }

        #region Version Number formula ///
        // Major Version First Number after place .( DOT) Like 1.
        // A=01- Jan
        // B-02 -Feb
        // C-03 -Mar
        // D-04 -Apr
        // E-05 -May
        // F-06 -Jun
        // G-07 -Jul
        // I-08 -Aug
        // J-09 -Sep
        // K-10 -Oct
        // L-11 -Nov
        // Z-12 -Dec
        // Major Change Number type value. 1,2,3,4
        // Minor Change charType I -Improvements. E -Error,Performance -P
        // Number Count 1 to 10. If number reached 10 then increments of Major Version. This number increments very time when release software. 

        public static string SoftwareVersionNo { get; set; }
        // Testing,Beta and Final.
        public static string SoftwareVersionName { get; set; }
        #endregion
        //Windows Version like window 8, windows seven
        public static string WindowsVersion { get; set; }

        public static string WindowsBit { get; set; }

        public static string SizeOfRam { get; set; }

        public static string ProcessorName { get; set; }

        public static List<string> ListApplicationName { get; set; }


    }
}
