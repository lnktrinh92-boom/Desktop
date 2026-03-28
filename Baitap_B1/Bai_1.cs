using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Baitap_B1
{
    public partial class Bai_1 : Form
    {
        public Bai_1()
        {
            InitializeComponent();
        }

        private void textNum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Chỉ được nhập số");
            }
        }

        private void textNum2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Chỉ được nhập số");
            }
        }

        private void radioButton_Cộng_CheckedChanged(object sender, EventArgs e)
        {
                labelResult.Text = textNum1.Text + " + " + textNum2.Text +
                   " = " + (int.Parse(textNum1.Text) + int.Parse(textNum2.Text)).ToString(); 
        }

        private void radioButton_Trừ_CheckedChanged(object sender, EventArgs e)
        {
            labelResult.Text = textNum1.Text + " - " + textNum2.Text +
                   " = " + (int.Parse(textNum1.Text) - int.Parse(textNum2.Text)).ToString();
        }

        private void radioButton_Nhân_CheckedChanged(object sender, EventArgs e)
        {
            labelResult.Text = textNum1.Text + " * " + textNum2.Text +
                   " = " + (int.Parse(textNum1.Text) * int.Parse(textNum2.Text)).ToString();
        }

        private void radioButton_Chia_CheckedChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(textNum1.Text, out double Num1) ||
                !double.TryParse(textNum2.Text, out double Num2))
            {
                return;
            }
            if (Num2 == 0)
            {
                MessageBox.Show("Không thể chia cho 0", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            labelResult.Text = textNum1.Text + " / " + textNum2.Text +
                " = " + (int.Parse(textNum1.Text) / int.Parse(textNum2.Text)).ToString();
        }
    }
}
