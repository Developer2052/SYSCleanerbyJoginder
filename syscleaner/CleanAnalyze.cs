using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Common;
using Shell32;
using System.Runtime.InteropServices;
using System.IO;
namespace syscleaner
{
    public partial class CleanAnalyze : Form
    {
        /// <summary>
        /// Scan All folder information about this...
        /// Outer Panel must be define ID... pnl_left_outer_1
        /// Inner Panel must be define ID .... pnl_left_inner_1
        /// </summary>
        /// 
        int ControlId = 0;

        public CleanAnalyze()
        {
            List<string> listOfRecentFile = new List<string>();
            string sizeoffile = string.Empty;
           
            RecentOpenProgram.GetRecentCountAndSize(ref listOfRecentFile, ref sizeoffile);
            InitializeComponent();
            CleanProgressbar.Increment(100);
            int PanelLocationY = 0;
            int PanelLocationX = 0;
            int TempCount = 0;
            bool isreset = true;
            foreach (var item in GetAllApplicationLists.GetAllApplicationList())
            {
                ControlId++;
                TempCount++;
                if (TempCount > 10)
                {
                    if (isreset)
                    {
                        isreset = false;
                        PanelLocationY = 0;
                    }
                    PanelLocationX = 363;
                    PanelLocationY += 40;
                }
                else
                {
                    PanelLocationX = 6;
                    PanelLocationY += 40;

                }

                bindsControls(ControlId, PanelLocationX, PanelLocationY, item);

            }
        }

        private void bindsControls(int ID, int panelLoctionX, int panelLocationY, string programName)
        {


       string SK=   CommonFunction.GetFileSize(  GetRecycleBinFiles.GetRecycleBinItems().CountOfSize);
       int i = GetRecycleBinFiles.GetRecycleBinItems().CountOfFile;
           
            Panel ObjPanel = new Panel();
            ObjPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ObjPanel.Location = new System.Drawing.Point(panelLoctionX, panelLocationY);
            ObjPanel.Name = "pnl_left_outer_" + ID;
            ObjPanel.Size = new System.Drawing.Size(348, 39);



            PictureBox picturebox = new PictureBox();

            picturebox.Location = new System.Drawing.Point(6, 6);
            picturebox.Name = "picture_" + ID;
            picturebox.Size = new System.Drawing.Size(29, 27);


            Label lblProgramName = new Label();
            lblProgramName.AutoSize = true;
            lblProgramName.Location = new System.Drawing.Point(43, 13);
            lblProgramName.Name = "ProgramName_" + ID;
            lblProgramName.Size = new System.Drawing.Size(94, 17);

            lblProgramName.Text = programName;

            Label lblCountOfFile = new Label();
            lblCountOfFile.AutoSize = true;
            lblCountOfFile.Location = new System.Drawing.Point(165, 13);
            lblCountOfFile.Name = "lblCountOfFile_" + ID;
            lblCountOfFile.Size = new System.Drawing.Size(56, 17);

            lblCountOfFile.Text = "Total Fiile";
            ObjPanel.Controls.Add(lblCountOfFile);


            Label lblAmount = new Label();
            lblAmount.AutoSize = true;
            lblAmount.Location = new System.Drawing.Point(270, 13);
            lblAmount.Name = "ProgramAmount_" + ID;
            lblAmount.Size = new System.Drawing.Size(56, 17);

            lblAmount.Text = "asdfasdf";
            ObjPanel.Visible = true;
            ObjPanel.Controls.Add(lblProgramName);
            ObjPanel.Controls.Add(lblAmount);

            ObjPanel.Controls.Add(picturebox);
            PnlContainer.Controls.Add(ObjPanel);

        }
        private void pictureBox12_Click(object sender, EventArgs e)
        {
        }
        private void pictureBox10_Click(object sender, EventArgs e)
        {
        }
        private void CleanAnalyze_Load(object sender, EventArgs e)
        {
        }
        bool IsButtonClick = false;
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (!IsButtonClick)
            {
                DisplayOrHideDetails((PictureBox)sender, IsButtonClick);
                IsButtonClick = true;
            }
            else
            {
                IsButtonClick = true;
                DisplayOrHideDetails((PictureBox)sender, IsButtonClick);
                IsButtonClick = false;
            }
        }
        private void DisplayOrHideDetails(PictureBox objPictureBox, bool isHide)
        {
            string[] ControlId = CommonFunction.GetControlId(objPictureBox.Name);
            Control ParentControl = objPictureBox.Parent;
            int ID = 0;
            string startingPnl = string.Empty;
            string Outers = string.Empty;
            string LeftOrRightPanel = string.Empty;
            if (ControlId.Length == 4)
            {
                ID = Convert.ToInt32(ControlId[3]);
                Outers = ControlId[2];
                LeftOrRightPanel = ControlId[1];
                startingPnl = ControlId[0];
            }
            foreach (var Controls in this.PnlContainer.Controls)
            {
                Type ControlsType = Controls.GetType();
                if (ControlsType.FullName.Contains("Panel"))
                {
                    Panel ObjPanel = (Panel)Controls;
                    string[] PanelControlId = CommonFunction.GetControlId(ObjPanel.Name.ToLower());
                    if (ObjPanel.Name.ToLower() == ("pnl_" + LeftOrRightPanel + "_Inner" + "_" + ID).ToLower())
                    {
                        if (isHide)
                        {
                            ObjPanel.Visible = false;
                        }
                        else
                        {
                            ObjPanel.Location = new Point(((ParentControl.Location.X) + CommonInformation.GapPannelInnerX), ((ParentControl.Location.Y) + CommonInformation.GapPannelInnerY));
                            ObjPanel.Visible = true;
                        }
                    }
                    if (Convert.ToInt32(PanelControlId[3]) > ID)
                    {
                        if (ObjPanel.Name.ToLower().Contains((LeftOrRightPanel + "_outer").ToLower()))
                        {
                            if (isHide)
                            {
                                var Temp = ObjPanel.Location;
                                ObjPanel.Location = new Point(Temp.X, (Temp.Y - CommonInformation.GapPanelForCeanAnalyzePage));
                            }
                            else
                            {
                                var Temp = ObjPanel.Location;
                                ObjPanel.Location = new Point(Temp.X, (Temp.Y + CommonInformation.GapPanelForCeanAnalyzePage));
                            }
                        }
                    }
                }
            }
        }
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (!IsButtonClick)
            {
                DisplayOrHideDetails((PictureBox)sender, IsButtonClick);
                IsButtonClick = true;
            }
            else
            {
                IsButtonClick = true;
                DisplayOrHideDetails((PictureBox)sender, IsButtonClick);
                IsButtonClick = false;
            }
        }
    }
}
