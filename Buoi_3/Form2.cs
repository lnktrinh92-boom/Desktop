using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi_3
{
    public partial class Form2 : Form
    {
        DataTable table;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            table = new DataTable("SanPham");
            table.Columns.Add(new DataColumn("MaSP", Type.GetType("System.String")));
            table.Columns.Add(new DataColumn("TenSP", Type.GetType("System.String")));
            table.PrimaryKey = new DataColumn[] { table.Columns["MaSP"] };
            dataGridView1.DataSource = table;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            DataRow row = table.NewRow();
            row["MaSP"] = txtMaSP.Text;
            row["TenSP"] = txtTenSP.Text;
            table.Rows.Add(row);
        }
    }
}