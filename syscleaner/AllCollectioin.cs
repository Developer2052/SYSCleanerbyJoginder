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
using System.Threading;
using System.Reflection;

namespace syscleaner
{
    public partial class AllCollectioin : Form
    {
        #region Global Veriable

        bool IsSelectedWidowsApplicationValues = false;

        List<BindApplicationAndWindowsUsingGridview> ObjbindApplicationAndWindows = null;
        string SelectedTabPage = string.Empty;
        bool IsIndexCall = false;
        long sizeOfiles = 0;
       public string sizeoffile;
       public int CountOfFile;
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
        #region Control Set Text using Threading
        delegate void SetTextCallback(Form f, Control ctrl, string text,bool visual);
        /// <summary>
        /// Set text property of various controls
        /// </summary>
        /// <param name="form">The calling form</param>
        /// <param name="ctrl"></param>
        /// <param name="text"></param>
        public void SetText(Form form, Control ctrl, string text,bool visual)
        {
            // InvokeRequired required compares the thread ID of the 
            // calling thread to the thread ID of the creating thread. 
            // If these threads are different, it returns true. 
            if (ctrl.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                form.Invoke(d, new object[] { form, ctrl, text,visual });
            }
            else
            {
                ctrl.Visible = visual;
                ctrl.Text = text;
            }
        }
        
        #endregion

        private void BindFileCountAndTime()
        {
            SetText(this,lblSizeOfFile, "scan found " + CountOfFile.ToString() + " file " + sizeoffile + " Total",true);
            SetText(this, lblCleaningCompleteTimeSlot, "Cleaning Complete(" + CommonFunction.ConvertTimeSpanToMinutsAndString(DifferenceTimeHold) + ")",true);

            SetText(this, _pnlDeatilsComplete, "s",true);
           // _pnlDeatilsComplete.Visible = true;
        }

        public void BindChkWindowsList()
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
       
        public void BindApplicationList()
        {
            if (TreeApplication.Nodes.Count == CommonFunction.Zero())
            {
                BuildTreeApplication(_Applications.GetApplication(), TreeApplication, true);
            }
        }


        #region Bind Grid View after the Process Complete Using thread

        private void Bind()
        {

            GrdviewCollection.DataSource = ObjbindApplicationAndWindows;

        }

        private void BindGridView()
        {
            if (GrdviewCollection.InvokeRequired)
            {
                //Invoke only the ui-interaction code
                GrdviewCollection.Invoke(new MethodInvoker(this.Bind));
            }
        } 
        #endregion

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


        #region Set the Values using Thread
        delegate void SetControlValueCallback(Control oControl, string propName, object propValue);
        private void SetControlPropertyValue(Control oControl, string propName, object propValue)
        {
            if (oControl.InvokeRequired)
            {
                SetControlValueCallback d = new SetControlValueCallback(SetControlPropertyValue);
                oControl.Invoke(d, new object[] { oControl, propName, propValue });
            }
            else
            {
                Type t = oControl.GetType();
                PropertyInfo[] props = t.GetProperties();
                foreach (PropertyInfo p in props)
                {
                    if (p.Name.ToUpper() == propName.ToUpper())
                    {
                        p.SetValue(oControl, propValue, null);
                    }
                }
            }
        }
        int IncreementsValues = 0;
        int TempValues = 0;
        private void BindProcessBar()
        {
            int CountofSelectedFile =100/ TotalCountCheckValue;
            TempValues += 1;

            IncreementsValues += CountofSelectedFile;
            if (TotalCountCheckValue == TempValues)
                IncreementsValues = 100;


            if (CountofSelectedFile > 0)
            {
                SetControlPropertyValue(_AllCollectionProgressBar, "value", IncreementsValues);

            }
        } 
        #endregion



       
        public void Cursor(TreeNodeCollection treeNodeCollection,bool isIndexCall=false)
        {
            IsIndexCall = isIndexCall;
            foreach (TreeNode CheckValue in treeNodeCollection)
            {
                if (CheckValue.Nodes.Count > 0)
                {
                    Cursor(CheckValue.Nodes, isIndexCall);

                }
                if(isIndexCall)
                {
                    CheckValue.Checked = true;
                }

                if (CheckValue.Checked)
                {
                     if(!isIndexCall)                
                    BindProcessBar();

                    IsSelectedWidowsApplicationValues = true;
                    foreach (var CollectionOfItem in _Windows.ListOfWindwosProgram())
                    {
                        if (!string.IsNullOrEmpty(CollectionOfItem.Value))
                            if (string.Equals(CheckValue.Text, CollectionOfItem.Value))
                            {
                                // Get the path of windows Based on condition, GetPathBaseONcodition function return Zero or One. If path are find return One or else return Zero...
                                List<string> Extension = new List<string>();

                                //Joginder singh Dated : 21/11/2016
                                string GetPath = CommonFunction.GetPathBaseOnCondition(CheckValue.Text, ref Extension);

                                if (GetPath == "Event")
                                {
                                    TempValuesFile.Clear();
                                    AllEventLog.GetEventLogsSize(ref TempValuesFile, ref sizeoffile);
                                     
                                    BindGridViewAndList(CheckValue.Text);

                                }
                                
                                else

                                if (GetPath.Contains('$'))
                                {
                                    Recycle_Bin OBJ = new Recycle_Bin();
                                    TempValuesFile.Clear();
                                    OBJ.GetPath(ref TempValuesFile, ref sizeoffile);
                                 
                                    BindGridViewAndList(CheckValue.Text);

                                }
                                else

                                    if (GetPath.Contains('-'))
                                    {

                                        sizeoffile = string.Empty;
                                        TempValuesFile.Clear();
                                        RegistryWorks ObjRegistrykey = new RegistryWorks(AllPath.RecentlyTypeURLRegistry.Split('-')[0], "CurrentUser");
                                        ObjRegistrykey.Read(ref  TempValuesFile);
                                        
                                        BindGridViewAndList(CheckValue.Text);

                                    }
                                    else

                                        if (GetPath.Length.ToString() != CommonProperty.IsDefaultValue.Zero.ToString())
                                        {
                                            sizeoffile = string.Empty;
                                            TempValuesFile.Clear();
                                            // this function get the details of we can delete are these file and also count the size of file. 
                                            if (Extension.Count > 0)
                                                CommonFunction.DeleteFileGetTheDirecotry(GetPath, true, ref  TempValuesFile, ref sizeoffile, Extension);
                                            else
                                                CommonFunction.DeleteFileGetTheDirecotry(GetPath, true, ref  TempValuesFile, ref sizeoffile);
                                            
                                            BindGridViewAndList(CheckValue.Text);
                                        }
                            }
                    }
                }
            }
        }


        List<string> TempValuesFile = new List<string>();

        List<long> listSizeOfFile = new List<long>();
        private void ChangeImageOfLoding()
        {
            PicLoadingAndComplete.Image = null;
            PicLoadingAndComplete.Image = Image.FromFile(@"F:\syscleaner\syscleaner\Image\loading02.gif");

        }
        Thread thread,threadProcess;   // Reference create

        int TotalCountCheckValue = 0;
        private void GetCheckCheckedTreeValues(TreeNodeCollection Collection)
        {
            foreach (TreeNode CheckValue in Collection)
                {
                    if (CheckValue.Nodes.Count > 0)
                    {
                        GetCheckCheckedTreeValues(CheckValue.Nodes);

                    }
                    else
                    {
                        if (CheckValue.Checked)
                            TotalCountCheckValue += 1;
                    }
                }
           
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            TotalCountCheckValue = 0;
            IncreementsValues = 0;
            TempValues = 0;
            ThreadStart threadStart = new ThreadStart(ChangeImageOfLoding);
            ThreadStart threadStartProcess = new ThreadStart(BindAndProcess);
            thread = new Thread(threadStart);
            threadProcess = new Thread(threadStartProcess);
            if (thread.ThreadState != ThreadState.Running || thread.ThreadState != ThreadState.WaitSleepJoin)
            {
                thread.Start();
                threadProcess.Start();
               
            }

          
        }
       public void GetSizeAndCountOfFile()
        {
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
        }
        private void BindAndProcess()
        {
            // Add a Border Line.....
            //AddBorderLine(sender, e);
            ObjbindApplicationAndWindows = new List<BindApplicationAndWindowsUsingGridview>();

            // PicLoadingAndComplete.Image=Image.FromFile(new FileInfo(@"\syscleaner\Image\FINAL-LOADING-2.gif").FullName);
            string startingTime = DateTime.Now.ToLongTimeString();

            sizeoffile = string.Empty;

            IsSelectedWidowsApplicationValues = false;

            if (SelectedTabPage == TabName.Windows.ToString())
            {
                GetCheckCheckedTreeValues(TreeWindows.Nodes);
                Cursor(TreeWindows.Nodes);

                #region Execute after the complete all thing..

                GetSizeAndCountOfFile();

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
            PicLoadingAndComplete.Image = Image.FromFile(@"F:\syscleaner\syscleaner\Image\CleanerComplete.PNG");

        
        }
        private void btnClean_Click(object sender, EventArgs e)
        {

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
        private void BindGridViewAndList(string nameOfCheckValues)
        {
            listOfFiles.AddRange(TempValuesFile);
            if (!IsIndexCall)
            {
                ObjbindApplicationAndWindows.Add(new BindApplicationAndWindowsUsingGridview
                {
                    CountOfFile = TempValuesFile.Count.ToString() + " Files",
                    SizeOfFile = CommonFunction.GetFileSize(Convert.ToInt64(sizeoffile == "" ? null : sizeoffile)),
                    NameOfItems = nameOfCheckValues
                });
            }

            listSizeOfFile.Add(Convert.ToInt64(sizeoffile == "" ? null : sizeoffile));
        }

    }
}
