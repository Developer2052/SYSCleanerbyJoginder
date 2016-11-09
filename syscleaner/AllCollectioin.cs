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
    public partial class AllCollectioin : Form
    {
        CheckedListBox ListInterNetExplorer;
        CheckedListBox ChkListApplication;


        public AllCollectioin()
        {

            InitializeComponent();
            PicFooter.BackColor = Color.FromArgb(40, 129, 187);
            this.BtnApplication.BackColor = Color.FromArgb(40, 129, 200);
            this.BtnWindows.BackColor = Color.FromArgb(40, 129, 150);
            progressBar1.Increment(50);

            ListInterNetExplorer = new CheckedListBox();
            ChkListApplication = new CheckedListBox();
            BindChkWindowsList();



        }

        private void BindChkWindowsList()
        {

            if (ListInterNetExplorer.Items.Count == CommonFunction.Zero())
            {
                foreach (_Windows item in _Windows.ListOfWindwosProgram())
                {
                    if (item.Value != null)
                    {
                        ListInterNetExplorer.Items.Add(item.Value);
                    }
                }
                ListInterNetExplorer.Dock = DockStyle.Fill;
                Panel _TempLeft = new Panel();
                _TempLeft.Dock = DockStyle.Fill;
                _TempLeft.Controls.Add(ListInterNetExplorer);
               
            }
        }

        private void BtnWindows_Click(object sender, EventArgs e)
        {
            BindChkWindowsList();


        }



        private void BtnApplication_Click(object sender, EventArgs e)
        {
            this.pnlWIndows.Visible = false;
            if (ChkListApplication.Items.Count == CommonFunction.Zero())
            {
                foreach (var item in _Applications.GetApplication())
                {
                    if (item.Value != null)
                    {
                        ListInterNetExplorer.Items.Add(item.Value);
                    }
                }
            }
            ChkListApplication.Dock = DockStyle.Fill;



        }

        private void PicClosed_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

    }
}
