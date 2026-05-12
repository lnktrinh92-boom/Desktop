using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi_8
{
    public partial class Form1 : Form
    {
        QLBHEntities dbQLBH; //có thể dùng biến toàn cục để dùng cho Database
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadSanPham();
            DataBinding();
        }

        private void LoadSanPham()
        {
            using (QLBHEntities db = new QLBHEntities())
            {
                var listSP = (from sp in db.SanPhams
                              select new
                              {
                                  MaSP = sp.MaSP,
                                  TenSP = sp.TenSP,
                                  DVT = sp.DVTinh,
                                  DonGia = sp.DonGia,
                                  MaLoai = sp.MaLoai,
                                  TenLoai = sp.LoaiSanPham.TenLoai,
                              }).ToList();


                dgvSanPham.DataSource = listSP;
            }
        }

        internal void DataBinding()
        {
            txtMaSP.DataBindings.Add(new Binding("Text", dgvSanPham.DataSource, "MaSP", true, DataSourceUpdateMode.Never));
            txtTenSP.DataBindings.Add(new Binding("Text", dgvSanPham.DataSource, "TenSP", true));
        }

        private int InsertSanPham()
        {
            using (QLBHEntities db = new QLBHEntities())
            {

                SanPham sp = new SanPham();
                sp.MaSP = txtMaSP.Text;
                sp.TenSP = txtTenSP.Text;
                sp.DonGia = int.Parse(txtDonGia.Text);
                sp.DVTinh = txtDVT.Text;
                sp.MaLoai = txtMaLoai.Text;

                db.SanPhams.Add(sp);

                try
                {
                    return db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không Insert được", "Insert Error", MessageBoxButtons.OK);
                    return -1;
                }
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int sl = InsertSanPham();
            MessageBox.Show("Đã insert " + sl + " sản phẩm", "Insert", MessageBoxButtons.OK);
            LoadSanPham();
        }

        private void UpdateSanPham()
        {
            SanPham s = dbQLBH.SanPhams.Find(txtMaSP.Text);
            if (s != null)
            {
                s.TenSP = txtTenSP.Text.Trim();
                s.DVTinh = txtDVT.Text.Trim();
                s.DonGia = int.Parse (txtDonGia.Text);
                s.MaLoai = txtMaLoai.Text.Trim();
                try
                {
                    dbQLBH.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kiểm tra lại các giá trị", "Update Error", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Mã SP không được rỗng!!!", "Update Error", MessageBoxButtons.OK);
            }    
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateSanPham();
            LoadSanPham();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dbQLBH = new QLBHEntities();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            dbQLBH.Dispose();
        }

        private void DeleteSanPham()
        {
            SanPham s = dbQLBH.SanPhams.Find(txtMaSP.Text);

            if (s != null)
            {
                DialogResult result = MessageBox.Show(
                    "Bạn có chắc muốn xóa sản phẩm này?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        dbQLBH.SanPhams.Remove(s);

                        dbQLBH.SaveChanges();

                        MessageBox.Show("Xóa thành công!", "Delete", MessageBoxButtons.OK);

                        LoadSanPham();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thể xóa sản phẩm!", "Delete Error", MessageBoxButtons.OK);
                    }
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy sản phẩm!", "Delete Error", MessageBoxButtons.OK);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DeleteSanPham();
        }

        private void SearchSanPham()
        {
            using (QLBHEntities db = new QLBHEntities())
            {
                string tukhoa = txtSearch.Text.Trim();

                var listSP = (from sp in db.SanPhams
                              where sp.MaSP.Contains(tukhoa)
                                 || sp.TenSP.Contains(tukhoa)
                              select new
                              {
                                  MaSP = sp.MaSP,
                                  TenSP = sp.TenSP,
                                  DVT = sp.DVTinh,
                                  DonGia = sp.DonGia,
                                  MaLoai = sp.MaLoai,
                                  TenLoai = sp.LoaiSanPham.TenLoai,
                              }).ToList();

                dgvSanPham.DataSource = listSP;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchSanPham();
        }
    }
}
