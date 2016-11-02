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


        public static void GetEventLogsSize(ref int countOfLogDelete, ref long sizeOfLogsFile)
        {
            sizeOfLogsFile = 0;
            countOfLogDelete = 0;
            try
            {

                foreach (var item in EventLog.GetEventLogs(System.Environment.MachineName).Where(x => x.Log != "Security").Select(x => x))
                {
                    if (item.Entries.Count > (int)CommonConstantProperty.IsDefaultValue.Zero)
                    {
                        foreach (EventLogEntry entry in item.Entries)
                        {

                            byte[] bt = entry.Data;
                            if (bt.Count() > 0)
                            {
                                countOfLogDelete += 1;
                                sizeOfLogsFile += bt.Count();

                            }
                        }
                    }
                }

            }
            catch (Exception EX)
            {
                throw EX;
            }
        }
        public static void DeleteEventsLog(ref int countOfLogDelete, bool isDeleteLogs)
        {
            countOfLogDelete = 0;
            try
            {

                foreach (var item in EventLog.GetEventLogs(System.Environment.MachineName).Where(x => x.Log != "Security").Select(x => x))
                {
                    if (item.Entries.Count > (int)CommonConstantProperty.IsDefaultValue.Zero)
                    {
                        countOfLogDelete += 1;

                        if (isDeleteLogs)
                            item.Clear();
                    }
                }

            }
            catch (Exception EX)
            {
                throw EX;
            }
        }
    }
}
