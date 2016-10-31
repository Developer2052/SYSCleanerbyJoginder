using System;
using System.Drawing;
using System.Windows.Forms;
using Common;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace syscleaner
{
    public partial class StartUpPrograjm : Form
    {
        public StartUpPrograjm()
        {
            InitializeComponent();

            ProcessBar.BackColor = Color.FromArgb(40, 129, 187);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            StartUpProgram Obj = new StartUpProgram();
            var temp = Obj.GetStartUpProgramOnUsingRegistry();
        }
        private void StartUpPrograjm_Load(object sender, EventArgs e)
        {
            ProcessBar.Increment(0);
            GetStartupList();
            ProcessBar.Increment(100);

        }
        void GetStartupList()
        {
            StartUpProgram ObjClass = new StartUpProgram();
            var Temp = ObjClass.GetStartUpProgramOnUsingRegistry();
            Dictionary<string, string> ObjDictionary = new Dictionary<string, string>();
            foreach (var item in Temp)
            {
                ObjDictionary.Add(item.Key, item.Value);

            }

            GridStartupProgram.DataSource = CommonFunction.ConvertDictionaryToTable(ObjDictionary);

            DataGridViewLinkColumn link = new DataGridViewLinkColumn();
            link.UseColumnTextForLinkValue = true;
            //Enter your link button column header text
            link.HeaderText = "Click to View Details";
            //set the property name for link column
            link.DataPropertyName = "lnkColumn";
            //set default active color for link
            link.ActiveLinkColor = Color.White;
            link.LinkBehavior = LinkBehavior.SystemDefault;
            //set default link color 
            link.LinkColor = Color.Blue;
            //set default link text
            link.Text = "View Details";

            //set visited color means if user click that link what color would be change
            link.VisitedLinkColor = Color.YellowGreen;
            //Add this link column to datagrid view
            GridStartupProgram.Columns.Add(link);
        }
        private void GridStartupProgram_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            StartUpProgram startupProgram = new StartUpProgram();
            startupProgram.SetValues();

            string sk = GridStartupProgram.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
