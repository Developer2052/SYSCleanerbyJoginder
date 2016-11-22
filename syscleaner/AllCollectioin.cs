using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Common;
using System.IO;
using System.Security.AccessControl;

namespace syscleaner
{
    public partial class AllCollectioin : Form
    {
        #region Global Veriable
		
        bool IsSelectedWidowsApplicationValues = false;
        string SelectedTabPage = string.Empty;
        long sizeOfiles = 0;
        string sizeoffile;
        int CountOfFile;
        TimeSpan DifferenceTimeHold;
        List<string> listOfFiles = new List<string>(); 
	#endregion
        public AllCollectioin()
        {

            InitializeComponent();
            lblHeaderName.Text = "Sys Cleaner Software @ " + DateTime.Now.Year;
            PicFooter.BackColor = Color.FromArgb(40, 129, 187);
            _TopPanel.BackColor = Color.FromArgb(40, 129, 187);
             BindChkWindowsList();
            _pnlDeatilsComplete.Visible = false;
           

        }
        private void BindFileCountAndTime()
        {
            lblSizeOfFile.Text = "scan found " + CountOfFile.ToString() + " file " + sizeoffile + " Total";
            lblCleaningCompleteTimeSlot.Text = "Cleaning Complete(" + CommonFunction.ConvertTimeSpanToMinutsAndString(DifferenceTimeHold)+ ")";
            _pnlDeatilsComplete.Visible = true;
        }

        private void BindChkWindowsList()
        {
            SelectedTabPage = TabName.Windows.ToString();
            if (ChkWindowsList.Items.Count == CommonFunction.Zero())
            {
                foreach (_Windows item in _Windows.ListOfWindwosProgram())
                {
                    if (item.Value != null)
                    {
                        ChkWindowsList.Items.Add(item.Value);
                    }
                }
                ChkWindowsList.Dock = DockStyle.Fill;

            }
        }

        private void BtnWindows_Click(object sender, EventArgs e)
        {
            BindChkWindowsList();


        }



        private void BindApplicationList()
        {
            //this.pnlWIndows.Visible = false;

            if (ChkApplicationlist.Items.Count == CommonFunction.Zero())
            {
                foreach (var item in _Applications.GetApplication())
                {
                    if (item.Value != null)
                    {
                        ChkApplicationlist.Items.Add(item.Value);
                    }
                }
            }
            ChkApplicationlist.Dock = DockStyle.Fill;



        }
        private void BindGridView()
        {
            GrdviewCollection.DataSource = listOfFiles.Select(x => new { Value = x }).ToList(); ;
        }

        private void PicClosed_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TabWindowsAndApplication_SelectedIndexChanged(object sender, EventArgs e)
        {
            var temp = sender as TabControl;
            TabPage tabPage = temp.SelectedTab;
            if (tabPage.Text == TabName.Application.ToString())
            {
                SelectedTabPage = TabName.Application.ToString();
                BindApplicationList();
            }
            else
            {
                SelectedTabPage = TabName.Windows.ToString();
                BindChkWindowsList();

            }
        }

        private void _PictureCleaner_Click(object sender, EventArgs e)
        {

            GrdviewCollection.Show();


        }

        private void _PictureBoxStartup_Click(object sender, EventArgs e)
        {
            GrdviewCollection.Hide();
            DataGridView _Datagridview = new DataGridView();
            _pnlHome.Controls.Add(_Datagridview);


        }


        private void BindProcessBar()
        {
            int CountofSelectedFile = ChkWindowsList.CheckedItems.Count;
            if (CountofSelectedFile > 0)
            {
                _AllCollectionProgressBar.Increment(100 / CountofSelectedFile);

            }
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            string startingTime = DateTime.Now.ToLongTimeString();
            
            List<string> TempValuesFile = new List<string>();

            List<long> listSizeOfFile = new List<long>();
            sizeoffile = string.Empty;

            IsSelectedWidowsApplicationValues = false;

            if (SelectedTabPage == TabName.Windows.ToString())
            {
                foreach (string CheckValue in ChkWindowsList.CheckedItems)
                {
                    BindProcessBar();
                    IsSelectedWidowsApplicationValues = true;
                    foreach (var CollectionOfItem in _Windows.ListOfWindwosProgram())
                    {
                        if (!string.IsNullOrEmpty(CollectionOfItem.Value))
                            if (string.Equals(CheckValue, CollectionOfItem.Value))
                            {
                                // Get the path of windows Based on condition, GetPathBaseONcodition function return Zero or One. If path are find return One or else return Zero...

                                //Joginder singh Dated : 21/11/2016
                                string GetPath = CommonFunction.GetPathBaseOnCondition(CheckValue);
                                if (GetPath != CommonProperty.IsDefaultValue.Zero.ToString())
                                {
                                    sizeoffile = string.Empty;
                                    TempValuesFile.Clear();
                                    // this function get the details of we can delete are these file and also count the size of file. 
                                    CommonFunction.DeleteFileGetTheDirecotry(GetPath, true, ref  TempValuesFile, ref sizeoffile);
                                    listOfFiles.AddRange(TempValuesFile);
                                    listSizeOfFile.Add(Convert.ToInt64(sizeoffile));
                                }
                            }
                    }
                }
                CountOfFile = listOfFiles.Count;
                foreach (var item in listSizeOfFile)
                {
                    sizeOfiles = +item;
                }
                if (sizeOfiles > 0)
                    sizeoffile = CommonFunction.GetFileSize(sizeOfiles);
               string endtime = DateTime.Now.ToLongTimeString();
               DifferenceTimeHold = DateTime.Parse(endtime).Subtract(DateTime.Parse(startingTime)); 
                BindFileCountAndTime();
                BindGridView();

            }
        }
        private void btnClean_Click(object sender, EventArgs e)
        {

        }
    }
}
