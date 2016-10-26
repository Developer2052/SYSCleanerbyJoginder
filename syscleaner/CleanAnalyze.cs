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
        private CustomToolTip tip;

        /// <summary>
        /// Scan All folder information about this...
        /// Outer Panel must be define ID... pnl_left_outer_1
        /// Inner Panel must be define ID .... pnl_left_inner_1
        /// </summary>
        public CleanAnalyze()
        {
            InitializeComponent();
            this.tip = new CustomToolTip();

            //this.lblPercentCount.ForeColor = Color.FromArgb(40, 129, 187);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void CleanAnalyze_Load(object sender, EventArgs e)
        {
            CommonFunction.exectAmountOfData(CommonFunction.SizeOfRam());

            this.tip.SetToolTip(pnl_Left_Outer_1, "this is a test : 400" + Environment.NewLine + "have : 500 ");

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            PictureBox ObjPictureBox = (PictureBox)sender;
            string [] ControlId =CommonFunction.GetControlId(ObjPictureBox.Name);
            int ID = 0;
            string startingPnl=string.Empty;
            string Outers = string.Empty;
            string LeftOrRightPanel = string.Empty;
            if (ControlId.Length == 4)
            {
                 ID = Convert.ToInt32(ControlId[3]);
                 Outers = ControlId[2];
                 LeftOrRightPanel = ControlId[1];
                startingPnl=ControlId[0];
            }


             
            foreach (var Controls in this.PnlContainer.Controls)
            {
                Type ControlsType = Controls.GetType();
                if(ControlsType.FullName.Contains("Panel"))
                {
                    Panel ObjPanel = (Panel)Controls;
                    if (ObjPanel.Name.ToLower() == ("pnl_"+LeftOrRightPanel+"_Inner"+"_"+ID).ToLower())
                    {
                        ObjPanel.Visible = true;

                    }

                }


            }
        }
    }
}
