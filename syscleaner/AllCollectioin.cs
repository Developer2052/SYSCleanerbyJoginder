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

        List<BindApplicationAndWindowsUsingGridview> ObjbindApplicationAndWindows = null;
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
            lblCleaningCompleteTimeSlot.Text = "Cleaning Complete(" + CommonFunction.ConvertTimeSpanToMinutsAndString(DifferenceTimeHold) + ")";
            _pnlDeatilsComplete.Visible = true;
        }

        private void BindChkWindowsList()
        {

            SelectedTabPage = TabName.Windows.ToString();
            if (TreeWindows.Nodes.Count == CommonFunction.Zero())
            {
                BuildTreeWindows(_Windows.ListOfWindwosProgram(), TreeWindows, true);


            }
        }




        private void BtnWindows_Click(object sender, EventArgs e)
        {
            BindChkWindowsList();


        }
        #region BindTreeview Application and Windows
        public void BuildTreeWindows(List<_Windows> list, TreeView trv, Boolean expandAll)
        {
            trv.Nodes.Clear();
            TreeNode tnLib = new TreeNode();
            trv.BeginUpdate();
            foreach (var row in list)
            {
                if (row.Value == null)
                {
                    if (row.Key == "InterNet Explorer")
                    {
                        tnLib = trv.Nodes.Add(row.Key, row.Key, 0, 0);
                    }
                    if (row.Key == "Windows")
                    {
                        tnLib = trv.Nodes.Add(row.Key, row.Key, 1, 1);
                    }
                    if (row.Key == "System")
                    {
                        tnLib = trv.Nodes.Add(row.Key, row.Key, 2, 2);
                    }
                    if (row.Key == "Advanced")
                    {
                        tnLib = trv.Nodes.Add(row.Key, row.Key, 3, 3);

                    }
                }
                else
                {
                    tnLib.Nodes.Add(row.Value, row.Value, 7, 7);
                }

            }
            if (expandAll)
            {
                // Expand the TreeView
                trv.ExpandAll();
            }
            trv.EndUpdate();


        }
        public void BuildTreeApplication(List<_Applications> list, TreeView trv, Boolean expandAll)
        {
            trv.Nodes.Clear();
            TreeNode tnLib = null;

            trv.BeginUpdate();


            foreach (var row in list)
            {

                if (row.Value == null)
                {
                    if (row.Key == "Opera")
                    {
                        tnLib = trv.Nodes.Add(row.Key, row.Key, 0, 0);
                    }
                    if (row.Key == "Safari")
                    {
                        tnLib = trv.Nodes.Add(row.Key, row.Key, 1, 1);
                    }
                    if (row.Key == "Google Chrome")
                    {
                        tnLib = trv.Nodes.Add(row.Key, row.Key, 2, 2);
                    }
                    if (row.Key == "Utilities")
                    {
                        tnLib = trv.Nodes.Add(row.Key, row.Key, 3, 3);

                    }
                }
                else
                {
                    tnLib.Nodes.Add(row.Value, row.Value, 5, 5);
                }

            }
            if (expandAll)
            {
                // Expand the TreeView
                trv.ExpandAll();
            }
            trv.EndUpdate();
        } 
        #endregion
        private void BindApplicationList()
        {


            if (TreeApplication.Nodes.Count == CommonFunction.Zero())
            {
                BuildTreeApplication(_Applications.GetApplication(), TreeApplication, true);
            }




        }
        private void BindGridView()
        {
            GrdviewCollection.DataSource = ObjbindApplicationAndWindows;
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
            AddBorderLine(sender, e);
            GrdviewCollection.Show();


        }

        private void _PictureBoxStartup_Click(object sender, EventArgs e)
        {
            AddBorderLine(sender, e);
            GrdviewCollection.Hide();
            DataGridView _Datagridview = new DataGridView();
            _pnlHome.Controls.Add(_Datagridview);
        }


        private void BindProcessBar()
        {
            int CountofSelectedFile = 10;
            if (CountofSelectedFile > 0)
            {
                _AllCollectionProgressBar.Increment(100 / CountofSelectedFile);

            }
        }
        private void AddBorderLine(object sender, EventArgs e)
        {
            PictureBox btn = sender as PictureBox;
            if (btn != null)
            {
                foreach (PictureBox item in _pnlIconContainer.Controls)
                {
                    if (item != null)
                    {
                        item.BorderStyle = BorderStyle.None;
                    }

                }



                btn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            }
        }


        private void Cursor(TreeNodeCollection treeNodeCollection)
        {
            foreach (TreeNode CheckValue in treeNodeCollection)
            {
                if(CheckValue.Nodes.Count>0)
                {
                    Cursor(CheckValue.Nodes);

                }

                if (CheckValue.Checked)
                {
                    BindProcessBar();
                    IsSelectedWidowsApplicationValues = true;
                    foreach (var CollectionOfItem in _Windows.ListOfWindwosProgram())
                    {
                        if (!string.IsNullOrEmpty(CollectionOfItem.Value))
                            if (string.Equals(CheckValue.Text, CollectionOfItem.Value))
                            {
                                // Get the path of windows Based on condition, GetPathBaseONcodition function return Zero or One. If path are find return One or else return Zero...

                                //Joginder singh Dated : 21/11/2016
                                string GetPath = CommonFunction.GetPathBaseOnCondition(CheckValue.Text);
                                if (GetPath.Length.ToString() != CommonProperty.IsDefaultValue.Zero.ToString())
                                {
                                    sizeoffile = string.Empty;
                                    TempValuesFile.Clear();
                                    // this function get the details of we can delete are these file and also count the size of file. 
                                    CommonFunction.DeleteFileGetTheDirecotry(GetPath, true, ref  TempValuesFile, ref sizeoffile);
                                    listOfFiles.AddRange(TempValuesFile);
                                    ObjbindApplicationAndWindows.Add(new BindApplicationAndWindowsUsingGridview
                                    {
                                        CountOfFile = TempValuesFile.Count.ToString() + "Files",
                                        SizeOfFile = CommonFunction.GetFileSize(Convert.ToInt64(sizeoffile)),
                                        NameOfItems = CheckValue.Text
                                    });

                                    listSizeOfFile.Add(Convert.ToInt64(sizeoffile));
                                }
                            }
                    }
                }
            }
        }

        
            List<string> TempValuesFile = new List<string>();

            List<long> listSizeOfFile = new List<long>();
         
        private void btnScan_Click(object sender, EventArgs e)
        {   // Add a Border Line.....
            AddBorderLine(sender, e);
            ObjbindApplicationAndWindows = new List<BindApplicationAndWindowsUsingGridview>();

            // PicLoadingAndComplete.Image=Image.FromFile(new FileInfo(@"\syscleaner\Image\FINAL-LOADING-2.gif").FullName);
            string startingTime = DateTime.Now.ToLongTimeString();

            sizeoffile = string.Empty;

            IsSelectedWidowsApplicationValues = false;

            if (SelectedTabPage == TabName.Windows.ToString())
            {

                Cursor(TreeWindows.Nodes);

                #region Execute after the complete all thing..
                // Develop By JSB,23/11/2016
                CountOfFile = listOfFiles.Count;

                /// Count of File size display on Top Header Display....
                /// 
                foreach (var item in listSizeOfFile)
                {
                    sizeOfiles += item;
                }
                if (sizeOfiles > 0)
                    sizeoffile = CommonFunction.GetFileSize(sizeOfiles);
                /// Display Time Which...... display on Header....for scanning and display Values....
                #region Time Subtract.....
                string endtime = DateTime.Now.ToLongTimeString();
                DifferenceTimeHold = DateTime.Parse(endtime).Subtract(DateTime.Parse(startingTime));
                #endregion

                BindFileCountAndTime();


                BindGridView();
                // PicLoadingAndComplete.Image = Image.FromFile(new FileInfo("CleanerComplete.PNG").FullName);

                #endregion
            }
        }
        private void btnClean_Click(object sender, EventArgs e)
        {

        }
    }
}
