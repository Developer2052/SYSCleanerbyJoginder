using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;

namespace Common
{
    public class AllEventLog
    {
        static int sizeKB = 0;


        public static string GetEventLogsSize()
        {
           

            int SizeOfEventLogFiles = 0;
            try
            {


                var sss = EventLog.GetEventLogs(System.Environment.MachineName);

              
                if (EventLog.SourceExists("Setup"))
                {
                }
                foreach (var item in EventLog.GetEventLogs(System.Environment.MachineName).Where(x => x.Log != "Security").Select(x => x))
                {
                    if (item.Entries.Count > (int)CommonConstantProperty.IsDefaultValue.Zero)
                    {
                        foreach (EventLogEntry entry in item.Entries)
                        {
                           
                            byte[] bt = entry.Data;
                            if (bt.Count() > 0)
                            {
                                SizeOfEventLogFiles += bt.Count();

                            }
                        }
                    }
                }
                return CommonFunction.GetFileSize(SizeOfEventLogFiles);
            }
            catch (Exception EX)
            {
                throw EX;
            }
        }
        public static CommonProperty.IsDefaultValue DeleteEventsLog()
        {
            int SizeOfEventLogFiles = 0;
            try
            {

                foreach (var item in EventLog.GetEventLogs(System.Environment.MachineName).Where(x => x.Log != "Security").Select(x => x))
                {
                    if (item.Entries.Count > (int)CommonConstantProperty.IsDefaultValue.Zero)
                    {
                        item.Clear();
                       
                    }
                }
               return CommonProperty.IsDefaultValue.One;
            }
            catch (Exception EX)
            {
              return  CommonProperty.IsDefaultValue.Zero;
                
            }
        }
    }
}
