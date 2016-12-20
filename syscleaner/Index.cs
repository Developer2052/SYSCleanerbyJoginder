using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace syscleaner
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        Thread CallAllocationPageProcess = null;
        Thread BindImageOnControlProcess = null;

        AllCollectioin obj = null;

        private void CallAllocationPage()
        {
            obj = new AllCollectioin();

            obj.BindChkWindowsList();
            obj.BindApplicationList();

            obj.SetText(this, lblPercentCount, "5%", true);
            obj.Cursor(obj.TreeWindows.Nodes, true);
            obj.GetSizeAndCountOfFile();
            //set the values using special function because we have am using thread...
           
            obj.SetText(this, lblPercentCount, "s", false);
            obj.SetText(this, lblSizeOfFile, obj.sizeoffile, true);
            obj.SetText(this, LblCountsOfFile, obj.CountOfFile.ToString(), true);
            obj.SetText(this, pnlSizeAndCountFile, "s", true);
            
            if (CallAllocationPageProcess.ThreadState != ThreadState.Running || CallAllocationPageProcess.ThreadState != ThreadState.WaitSleepJoin)
            {
                BindImageOnControlProcess.Abort();
                PicLoading.Image = Image.FromFile(@"F:\syscleaner\syscleaner\Image\CompleteDoubleCircleLoding.gif");
                obj.SetText(this, lblPercentCount, "", false);
                CallAllocationPageProcess.Abort();
                
            }
            
        }
        private void BindImageOnControl()
        {
            int Percent = 10;
            PicLoading.Image = Image.FromFile(@"F:\syscleaner\syscleaner\Image\Double Circle Loading.gif");
            while (CallAllocationPageProcess.IsAlive)
            {
                Thread.Sleep(5000);
                if (Percent < 90)
                {
                    Percent += 5;
                    obj.SetText(this, lblPercentCount, Percent.ToString()+"%",true);
                   
                }
            
            }
        }

        private void btnScan_Click(object sender, EventArgs e)
        {

            CallAllocationPageProcess = new Thread(new ThreadStart(CallAllocationPage));
            BindImageOnControlProcess = new Thread(new ThreadStart(BindImageOnControl));
            if (CallAllocationPageProcess.ThreadState != ThreadState.Running || CallAllocationPageProcess.ThreadState != ThreadState.WaitSleepJoin)
            {
                CallAllocationPageProcess.Start();
                BindImageOnControlProcess.Start();

            }
           
           
         
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            AllCollectioin ObjCollection = new AllCollectioin();
            ObjCollection.Show();
            this.Hide();
        }
    }
}
