using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi_1
{
    public partial class Form_B1 : Form
    {
        public Form_B1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            txtHoTen.Text = "Vui lòng nhập họ tên";
        }

        private void btnAdd_MouseClick(object sender, MouseEventArgs e)
        {
            //lbListHoTen.Items.Clear();
            string newName = txtHoTen.Text.Trim();
            if (lbListHoTen.Items.Contains(newName))
            {
                MessageBox.Show("Tên đã tồn tại trong danh sách!");
                return;
            }
            lbListHoTen.Items.Add(txtHoTen.Text);
        }

        private void Form_B1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Do you really want to close?", "Demo Form",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }
    }
}
