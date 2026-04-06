using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XuLyHoTen;

namespace Baitap_B2
{
    public partial class XuLyHoTen : Form
    {
        public XuLyHoTen()
        {
            InitializeComponent();
        }

        private void textBoxResult_Click(object sender, EventArgs e)
        {
            textBoxInput.Focus();
        }

        private HoTen LayDuLieu()
        {
            return new HoTen(textBoxInput.Text);
        }

        private void buttonGioiThieu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chào mừng đến với chương trình xử lý họ tên của " + textBoxInput.Text);
        }

        private void buttonHoLot_Click(object sender, EventArgs e)
        {
            HoTen ht = LayDuLieu();
            textBoxResult.Text = "Họ lót: " + ht.HoLot();
        }

        private void buttonTen_Click(object sender, EventArgs e)
        {
            HoTen ht = LayDuLieu();
            textBoxResult.Text = "Tên: " + ht.Ten();
        }

        private void buttonDemTu_Click(object sender, EventArgs e)
        {
            HoTen ht = LayDuLieu();
            textBoxResult.Text = "Số từ: " + ht.DemTu();
        }

        private void buttonHoaDauTu_Click(object sender, EventArgs e)
        {
            HoTen ht = LayDuLieu();
            textBoxResult.Text = "Hoa đầu từ: " + ht.HoaDauTu();
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            textBoxInput.Clear();
            textBoxResult.Text = "";
            textBoxInput.Focus();
        }

        private void buttonDung_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
