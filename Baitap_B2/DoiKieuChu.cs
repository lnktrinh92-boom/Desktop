using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baitap_B2
{
    public partial class DoiKieuChu : Form
    {
        public DoiKieuChu()
        {
            InitializeComponent();
        }

        private void textBoxResult_Click(object sender, EventArgs e)
        {
            textBoxInput.Focus();
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            string input = textBoxInput.Text;

            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Vui lòng nhập họ tên!");
                return;
            }

            if (radioButtonLower.Checked)
            {
                textBoxResult.Text = input.ToLower();
            }
            else if (radioButtonUpper.Checked)
            {
                textBoxResult.Text = input.ToUpper();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            textBoxInput.Clear();
            textBoxResult.Clear();
            textBoxInput.Focus();
        }
    }
}
