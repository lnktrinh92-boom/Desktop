using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi_2
{
    public partial class FormDinhDang : Form
    {
        public FormDinhDang()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBoxResult.Text = textBoxTen.Text;
        }

        private void radioButtonRed_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonRed.Checked && checkBoxRealTime.Checked)
            {
                textBoxResult.ForeColor = Color.Red;
            }    
        }

        private void radioButtonGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonGreen.Checked && checkBoxRealTime.Checked)
            {
                textBoxResult.ForeColor = Color.Green;
            }
        }

        private void radioButtonBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBlue.Checked && checkBoxRealTime.Checked)
            {
                textBoxResult.ForeColor = Color.Blue;
            }
        }

        private void radioButtonBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBlack.Checked && checkBoxRealTime.Checked)
            {
                textBoxResult.ForeColor = Color.Black;
            }
        }

        private void checkBoxBold_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBoxBold.Checked && checkBoxRealTime.Checked)
            {
                textBoxResult.Font = new Font(textBoxResult.Font, FontStyle.Bold);
            }
            else
            {
                textBoxResult.Font = new Font(textBoxResult.Font, FontStyle.Regular);
            }
        }

        private void checkBoxItalic_CheckStateChanged_1(object sender, EventArgs e)
        {
            if (checkBoxItalic.Checked && checkBoxRealTime.Checked)
            {
                textBoxResult.Font = new Font(textBoxResult.Font, FontStyle.Italic);
            }
            else
            {
                textBoxResult.Font = new Font(textBoxResult.Font, FontStyle.Regular);
            }
        }

        private void checkBoxUnderline_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBoxUnderline.Checked && checkBoxRealTime.Checked)
            {
                textBoxResult.Font = new Font(textBoxResult.Font, FontStyle.Underline);
            }
            else
            {
                textBoxResult.Font = new Font(textBoxResult.Font, FontStyle.Regular);
            }
        }

        private void buttonThoat_MouseClick(object sender, MouseEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FormDinhDang_Load(object sender, EventArgs e)
        {
            checkBoxRealTime.Checked = false;
        }

        private void buttonApplyAll_MouseClick(object sender, MouseEventArgs e)
        {
            //Xử lý radio -> Có thể dùng Switch Case
            if (radioButtonRed.Checked)
                textBoxResult.ForeColor = Color.Red;
            if (radioButtonGreen.Checked)
                textBoxResult.ForeColor = Color.Green;
            if (radioButtonBlue.Checked)
                textBoxResult.ForeColor = Color.Blue;
            if (radioButtonBlack.Checked)
                textBoxResult.ForeColor = Color.Black;

            //Xử lý checkBox
            if (checkBoxBold.Checked && checkBoxItalic.Checked && checkBoxUnderline.Checked)
            {
                textBoxResult.Font = new Font(textBoxResult.Font, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline); 
            }
            else if (checkBoxBold.Checked && checkBoxItalic.Checked)
            {
                textBoxResult.Font = new Font(textBoxResult.Font, FontStyle.Bold | FontStyle.Italic);
            }
            else if (checkBoxItalic.Checked && checkBoxUnderline.Checked)
            {
                textBoxResult.Font = new Font(textBoxResult.Font, FontStyle.Italic | FontStyle.Underline);
            }
            else if (checkBoxBold.Checked && checkBoxUnderline.Checked)
            {
                textBoxResult.Font = new Font(textBoxResult.Font, FontStyle.Bold | FontStyle.Underline);
            }
            else if (checkBoxBold.Checked)
            {
                textBoxResult.Font = new Font(textBoxResult.Font, FontStyle.Bold);
            }
            else if (checkBoxItalic.Checked)
            {
                textBoxResult.Font = new Font(textBoxResult.Font, FontStyle.Italic);
            }
            else if (checkBoxUnderline.Checked)
            {
                textBoxResult.Font = new Font(textBoxResult.Font, FontStyle.Underline);
            }
                
        }

        private void textBoxResult_Click(object sender, EventArgs e)
        {
            textBoxTen.Focus();
        }
    }
}
