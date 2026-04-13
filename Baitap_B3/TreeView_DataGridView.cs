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
    public partial class TreeView_DataGridView : Form
    {
        SqlConnection cnn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        string connectstring = "Data Source=SEIWA\\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True";

        public TreeView_DataGridView()
        {
            InitializeComponent();
        }

        void LoadTreeView()
        {
            using (SqlConnection conn = new SqlConnection(connectstring))
            {
                string query = "SELECT MaLoai, TenLoai FROM LoaiSanPham";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                treeViewLoai.Nodes.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    TreeNode node = new TreeNode(row["TenLoai"].ToString());
                    node.Tag = row["MaLoai"].ToString();
                    treeViewLoai.Nodes.Add(node);
                }
            }
        }

        void LoadSanPham(string maLoai)
        {
            using (SqlConnection conn = new SqlConnection(connectstring))
            {
                string query = @"SELECT 
                                    MaSP,
                                    TenSP,
                                    DVTinh,
                                    DonGia
                                 FROM SanPham
                                 WHERE MaLoai = @maLoai";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@maLoai", maLoai);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewSP.DataSource = dt;
            }
        }

        private void TreeView_DataGridView_Load(object sender, EventArgs e)
        {
            LoadTreeView();
        }

        private void treeViewLoai_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string maLoai = e.Node.Tag.ToString();
            LoadSanPham(maLoai);
        }
    }
}
