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
        bool IsSelectedWidowsApplicationValues = false;
        string SelectedTabPage = string.Empty;

        public AllCollectioin()
        {
           
            InitializeComponent();
            //PicFooter.BackColor = Color.FromArgb(40, 129, 187);
            //_AllCollectionProgressBar.Increment(50);
            ////this.BtnApplication.BackColor = Color.FromArgb(40, 129, 200);
            ////this.BtnWindows.BackColor = Color.FromArgb(40, 129, 150);
            ////progressBar1.Increment(50);
            //Size tt = _pnlIconContainer.Size;
            //_TopPanel.BackColor = Color.FromArgb(40, 129, 187);
            //string ss = AllPath.IECookies;
            //BindChkWindowsList();


            // string mm=  Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.SystemX86), "calc.exe");

            //// Create a new DirectoryInfo object.
            //DirectoryInfo dInfo = new DirectoryInfo(mm);

            //// Get a DirectorySecurity object that represents the 
            //// current security settings.
            //DirectorySecurity dSecurity = dInfo.GetAccessControl();

            BindChkWindowsList();
            string test = AllPath.IISLog();

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

        private void PicClosed_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TabWindowsAndApplication_SelectedIndexChanged(object sender, EventArgs e)
        {
            var temp = sender as TabControl;
            TabPage tabPage = temp.SelectedTab;
            if (tabPage.Text ==TabName.Application.ToString())
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

            dataGridView1.Show();


        }

        private void _PictureBoxStartup_Click(object sender, EventArgs e)
        {
            dataGridView1.Hide();
            DataGridView _Datagridview = new DataGridView();
            _pnlHome.Controls.Add(_Datagridview);


        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            List<string> NameOfValues=new List<string>();
            string sizeoffile=string.Empty;
            IsSelectedWidowsApplicationValues = false;

            if (SelectedTabPage == TabName.Windows.ToString())
            {
                foreach (string CheckValue in ChkWindowsList.CheckedItems)
                {
                    IsSelectedWidowsApplicationValues = true;
                    foreach (var CollectionOfItem in _Windows.ListOfWindwosProgram())
                    {
                        if (!string.IsNullOrEmpty(CollectionOfItem.Value))
                            if (string.Equals(CheckValue, CollectionOfItem.Value))
                            {
                                // Get the path of windows Based on condition..... Joginder singh 
                                string GetPath=CommonFunction.GetPathBaseOnCondition(CheckValue); 
                                if(GetPath!=CommonProperty.IsDefaultValue.Zero.ToString()){
                                    CommonFunction.DeleteFileGetTheDirecotry(GetPath, false, ref  NameOfValues, ref sizeoffile);
                                }

                            }

                    }
                }
            }

        }

        private void btnClean_Click(object sender, EventArgs e)
        {

        }
    }
}
