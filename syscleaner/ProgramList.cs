using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace syscleaner
{
    public partial class ProgramList : Form
    {
        public ProgramList()
        {
            InitializeComponent();
            this.Load += ProgramList_Load;
        }

        void ProgramList_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                DataColumn column = new DataColumn("ProgramList");
                dt.Columns.Add(column);
                DataRow row = dt.NewRow();
                foreach (string item in CommonFunction.GetAllApplicationList())
                {

                    dt.Rows.Add(new Object[]{
                item
           });
                }

                GridListOfProgram.DataSource = dt;
            }
            catch (Exception)
            {

                throw;
            }

        }

    }
}
