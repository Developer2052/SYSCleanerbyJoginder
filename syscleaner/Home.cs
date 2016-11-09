using Common;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace syscleaner
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
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
                CommonFunction.GetAllInforationAboutSystem();
                CommonInformation.ListApplicationName = GetAllApplicationLists.GetAllApplicationList();
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void btnClean_Click(object sender, EventArgs e)
        {
            ActionContainers ObjAction = new ActionContainers();
            ObjAction.GetTemporaryFileDetails();
        }
        private void btnScan_Click(object sender, EventArgs e)
        {
            CleanAnalyze ObjCleanAnalyze = new CleanAnalyze();
            ObjCleanAnalyze.Show();
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //StartUpPrograjm pp = new StartUpPrograjm();
            //pp.Show();
        }
    }
}
