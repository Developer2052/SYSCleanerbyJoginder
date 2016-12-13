using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public class RegistryWorks
    {
        public RegistryKey Key = null;


        public RegistryWorks(string key, string currentUser = "", string localMechine = "")
        {
            if (currentUser != "")
            {
                Key = Registry.CurrentUser.OpenSubKey(key);
            }
            else
                if (localMechine != "")
                {
                    Key = Registry.LocalMachine.OpenSubKey(key);
                }

        }

        public void GetKey()
        {
            if (Key != null)
            {
                foreach (string skName in Key.GetSubKeyNames())
                {
                    using (RegistryKey sk = Key.OpenSubKey(skName))
                    {
                        try
                        {
                            if (sk.GetValue("DisplayName") != null)
                            {
                                // if (!ApplicationList.Exists(e => e.Contains(sk.GetValue("DisplayName").ToString())))
                                //   ApplicationList.Add(sk.GetValue("DisplayName").ToString());
                            }
                        }
                        catch (Exception ex)
                        { }
                    }
                }
            }
        }

        public int SubKeyCount()
        {
            try
            {
                if (Key != null)
                    return Key.SubKeyCount;
                else
                    return 0;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public void Read(ref List<string> GetStringValue)
        {
            List<string> ReturnValues = new List<string>();
            // If the RegistrySubKey doesn't exist -> (null)
            if (Key == null)
            {
                GetStringValue = null;
            }
            else
            {
                try
                {
                    // If the RegistryKey exists I get its value
                    // or null is returned.
                    foreach (string item in Key.GetValueNames())
                    {
                        GetStringValue.Add(item);
                    }
                   
                }
                   
                catch (Exception e)
                {
                    GetStringValue = null;
                }
            }
        }


        public int GetValueCount()
        {
            try
            {
                if (Key != null)
                    return Key.ValueCount;
                else
                    return 0;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

    }
}
