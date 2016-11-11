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
        public AllCollectioin()
        {

            InitializeComponent();
            PicFooter.BackColor = Color.FromArgb(40, 129, 187);
            _AllCollectionProgressBar.Increment(50);
            //this.BtnApplication.BackColor = Color.FromArgb(40, 129, 200);
            //this.BtnWindows.BackColor = Color.FromArgb(40, 129, 150);
            //progressBar1.Increment(50);
            Size tt = _pnlIconContainer.Size;
            _TopPanel.BackColor = Color.FromArgb(40, 129, 187);
            BindChkWindowsList();



        }

        private void BindChkWindowsList()
        {

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
            TabPage PP = temp.SelectedTab;
            if (PP.Text == "Application")
            {
                BindApplicationList();
            }
            else
            {
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
            foreach (string item in ChkWindowsList.CheckedItems)
            {
                foreach (var CollectionOfItem in _Windows.ListOfWindwosProgram())
                {
                   if( CollectionOfItem.Value.ToLower()==item)
                   {

                   }

                }


            }

        }

        private void btnClean_Click(object sender, EventArgs e)
        {

        }
    }
}
