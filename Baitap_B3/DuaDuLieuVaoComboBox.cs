using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baitap_B3
{
    public partial class DuaDuLieuVaoComboBox : Form
    {
        SqlConnection cnn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        string connectstring = "Data Source=SEIWA\\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True";

        public DuaDuLieuVaoComboBox()
        {
            InitializeComponent();
        }

        void LoadSanPham()
        {
            using (SqlConnection conn = new SqlConnection(connectstring))
            {
                string query = "SELECT TenSP FROM SanPham";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                comboBoxSP.DataSource = dt;
                comboBoxSP.DisplayMember = "TenSP";
            }
        }

        private void DuaDuLieuVaoComboBox_Load(object sender, EventArgs e)
        {
            LoadSanPham();
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
