using Common;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Windows.Forms;

namespace syscleaner
{
    public partial class Home : Form
    {
        public Home()
        {

            InitializeComponent();
            LblHomeAbovePageText.Text = "SysCleaner Software @ " + DateTime.Now.Year;
            this.panel2.BackColor = Color.FromArgb(40, 129, 187);
            this.lblPercentCount.ForeColor = Color.FromArgb(40, 129, 187);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            ///Temp File path 
            DirectoryInfo Dir = new DirectoryInfo(System.IO.Path.GetTempPath());



            this.Close();
            Application.Exit();
        }
        private void Home_Load(object sender, EventArgs e)
        {
            try
            {
                CommonInformation.MechineName = Environment.MachineName;
                CommonInformation.SoftwareVersionName = CommonConstantProperty.VersionType.Test.ToString();
                CommonInformation.WindowsBit = System.Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE");
                CommonInformation.SoftwareVersionNo = "1.K1P1";
                var name = (from x in new ManagementObjectSearcher("SELECT Caption FROM Win32_OperatingSystem").Get().Cast<ManagementObject>()
                            select x.GetPropertyValue("Caption")).FirstOrDefault();
                CommonInformation.WindowsVersion = name != null ? name.ToString() : "Unknown";
                //PerformanceCounter ObjPerformanceCounter = new PerformanceCounter("Mono Memory", "Total Physical Memory");

                //var Temp = ObjPerformanceCounter.RawValue;
                              
                if (CommonFunction.IsValidateTextValues(CommonInformation.MechineName))
                    LblNameofWindows.Text = CommonInformation.MechineName;

                if (CommonFunction.IsValidateTextValues(CommonInformation.SoftwareVersionNo))


                    LblSoftwareVersion.Text = CommonInformation.SoftwareVersionNo;

                if (CommonFunction.IsValidateTextValues(CommonInformation.SoftwareVersionName))

                    LblSoftwareVersion.Text += " ( " + CommonInformation.SoftwareVersionName + " ) ";

                if (CommonFunction.IsValidateTextValues(CommonInformation.WindowsVersion))
                    lblWindowsVersion.Text = CommonInformation.WindowsVersion + " ( " + CommonInformation.WindowsBit + " )";

                if(!CommonFunction.IsValidateTextValues(CommonInformation.ProcessorName))
                {
                    LblSizeOfRam.Text = CommonFunction.GetProcessorName();
                }

                string SizeOfRAM = CommonFunction.GetSizeOfRAM();

                if (CommonFunction.IsValidateTextValues(SizeOfRAM))
                {
                    LblSizeOfRam.Text += " "+ SizeOfRAM + ".00 GB";
                }
            }
            catch (Exception)
            {
                
                throw;
            }

        }

        int i = 0;
        private void btnClean_Click(object sender, EventArgs e)
        {
          


        }

        private void btnScan_Click(object sender, EventArgs e)
        {


        }

      

    }
}
