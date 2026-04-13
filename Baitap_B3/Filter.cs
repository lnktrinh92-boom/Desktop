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
    public partial class Filter : Form
    {
        SqlConnection cnn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        string connectstring = "Data Source=SEIWA\\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True";

        public Filter()
        {
            InitializeComponent();
        }

        void LoadLoaiSanPham()
        {
            using (SqlConnection conn = new SqlConnection(connectstring))
            {
                string query = "SELECT MaLoai, TenLoai FROM LoaiSanPham";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                comboBoxFilter.DataSource = dt;
                comboBoxFilter.DisplayMember = "TenLoai";
                comboBoxFilter.ValueMember = "MaLoai";
            }
        }

        void LocSanPham(string maLoai)
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
                                 WHERE MaLoai = @maLoai";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@maLoai", maLoai);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewSP.DataSource = dt;
            }
        }

        private void Filter_Load(object sender, EventArgs e)
        {
            LoadLoaiSanPham();
        }

        private void buttonLoc_Click(object sender, EventArgs e)
        {
            string maLoai = comboBoxFilter.SelectedValue.ToString();
            LocSanPham(maLoai);
        }
    }
}
