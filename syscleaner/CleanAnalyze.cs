using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Common;

namespace syscleaner
{
    public partial class CleanAnalyze : Form
    {


        /// <summary>
        /// Scan All folder information about this...
        /// Outer Panel must be define ID... pnl_left_outer_1
        /// Inner Panel must be define ID .... pnl_left_inner_1
        /// </summary>
        public CleanAnalyze()
        {
            InitializeComponent();

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
