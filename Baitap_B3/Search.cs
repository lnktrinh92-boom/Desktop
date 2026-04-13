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
    public partial class Search : Form
    {
        SqlConnection cnn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        string connectstring = "Data Source=SEIWA\\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True";

        public Search()
        {
            InitializeComponent();
        }

        void TimKiem(string keyword)
        {
            using (SqlConnection conn = new SqlConnection(connectstring))
            {
                string query = @"SELECT 
                                    MaSP,
                                    TenSP,
                                    DVTinh,
                                    DonGia,
                                    MaLoai
                                 FROM SanPham
                                 WHERE TenSP LIKE @ten";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@ten", "%" + keyword + "%");

                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewSP.DataSource = dt;
            }
        }

        private void buttonTim_Click(object sender, EventArgs e)
        {
            string keyword = textBoxInput.Text.Trim();
            TimKiem(keyword);
        }
    }
}
