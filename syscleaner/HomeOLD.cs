using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;

using System.Text;

using Common;
using System.Windows.Forms;
using System.Management;

namespace syscleaner
{
    public partial class HomeOLD : Form
    {
        public HomeOLD()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Int32 isEmptyRecycle = CommonDllImport.SHEmptyRecycleBin(IntPtr.Zero, null, CommonDllImport.RecycleFlag.SHERB_NOSOUND | CommonDllImport.RecycleFlag.SHERB_NOCONFIRMATION);
            if (isEmptyRecycle == CommonProperty.EmptyReceyleBin)
            {
                CommonResults.IsEmptyRecycle = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            string path = @"C:\Users\JOGIND~1\AppData\Local\Temp";
            CommonFunction.DeleteFileGetTheDirecotry(path,false);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            foreach (var item in EventLog.GetEventLogs(System.Environment.MachineName))
            {
               if( item.Entries.Count>(int)CommonConstantProperty.IsDefaultValue.Zero)
               {
                   item.Clear();
               }
               
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.History);
            CommonFunction.DeleteFileGetTheDirecotry(path,false);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            UInt32 result = CommonDllImport.DnsFlushResolverCache();

        }
     

        private void Home_Load(object sender, EventArgs e)
        {

            //Get The Mechine Name 
           

            
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            
        }

    }
}

