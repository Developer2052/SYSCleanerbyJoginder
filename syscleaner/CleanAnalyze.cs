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
        public CleanAnalyze()
        {
            InitializeComponent();
           this.tip  = new CustomToolTip();

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
          
            this.tip.SetToolTip(panel4, "this is a test : 400"+Environment.NewLine+ "have : 500 ");
           
        }
    }
}
