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
    public partial class Form_Tong : Form
    {
        public Form_Tong()
        {
            InitializeComponent();
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            labelKetQua.Text = (int.Parse(txtNum1.Text) + int.Parse(txtNum2.Text)).ToString();
        }

        private void Form_Tong_Load(object sender, EventArgs e)
        {
            //labelKetQua.Text = "";
            //labelKetQua.Visible = false;
        }
    }
}
