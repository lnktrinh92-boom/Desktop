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
    public partial class DuaDuLieuVaoDataGridView : Form
    {
        SqlConnection cnn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        string connectstring = "Data Source=SEIWA\\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True";

        public DuaDuLieuVaoDataGridView()
        {
            InitializeComponent();
        }

        void LoadSanPham()
        {
            using (SqlConnection conn = new SqlConnection(connectstring))
            {
                string query = @"SELECT 
                                    MaSP AS [Mã sản phẩm],
                                    TenSP AS [Tên sản phẩm],
                                    DVTinh AS [Đơn vị tính],
                                    DonGia AS [Đơn giá],
                                    MaLoai AS [Mã loại sản phẩm]
                                 FROM SanPham";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewSP.DataSource = dt;
            }
        }

        private void DuaDuLieuVaoDataGridView_Load(object sender, EventArgs e)
        {
            LoadSanPham();
        }
    }
}
