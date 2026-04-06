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
    public partial class XuLyChuoi : Form
    {
        public XuLyChuoi()
        {
            InitializeComponent();
        }

        private void buttonCompareLower_Click(object sender, EventArgs e)
        {
            int kq = string.Compare(textBox1.Text, textBox2.Text);

            if (kq == 0)
                labelKQ.Text = "Hai chuỗi giống nhau";
            else if (kq > 0)
                labelKQ.Text = "Chuỗi 1 > Chuỗi 2";
            else
                labelKQ.Text = "Chuỗi 1 < Chuỗi 2";
        }

        private void buttonCOMPAREUpper_Click(object sender, EventArgs e)
        {
            int kq = string.Compare(textBox1.Text, textBox2.Text, true);

            if (kq == 0)
                labelKQ.Text = "Hai chuỗi giống nhau (không phân biệt)";
            else if (kq > 0)
                labelKQ.Text = "Chuỗi 1 > Chuỗi 2";
            else
                labelKQ.Text = "Chuỗi 1 < Chuỗi 2";
        }

        private void buttonConcat_Click(object sender, EventArgs e)
        {
            labelKQ.Text = textBox1.Text + " " + textBox2.Text;
        }

        private void buttonIndexOf_Click(object sender, EventArgs e)
        {
            string s1 = textBox1.Text;
            string s2 = textBox2.Text;

            int pos = s1.IndexOf(s2);

            if (pos >= 0)
            {
                string newStr = s1.Replace(s2, "CHỖ NÀY");
                labelKQ.Text = $"Vị trí: {pos}\nChuỗi mới: {newStr}";
            }
            else
            {
                labelKQ.Text = "Không tìm thấy!";
            }
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            string s1 = textBox1.Text.Trim();
            string s2 = textBox2.Text;

            string[] words = s1.Split(' ');

            if (words.Length < 2)
            {
                labelKQ.Text = "Chuỗi phải có ít nhất 2 từ!";
                return;
            }

            string afterFirst = words[0] + " " + s2 + " " + string.Join(" ", words, 1, words.Length - 1);

            string beforeLast = string.Join(" ", words, 0, words.Length - 1) + " " + s2 + " " + words[words.Length - 1];

            labelKQ.Text = "Sau từ đầu:\n" + afterFirst + "\n\nTrước từ cuối:\n" + beforeLast;
        }

        private void buttonSubstring_Click(object sender, EventArgs e)
        {
            string target = "TRÌNH XỬ LÝ";
            int pos = labelTieuDe.Text.IndexOf(target);

            if (pos >= 0)
            {
                labelTieuDe.Text = labelTieuDe.Text.Remove(pos, target.Length);
                labelKQ.Text = "Đã xóa chuỗi khỏi tiêu đề!";
            }
            else
            {
                labelKQ.Text = "Không tìm thấy trong tiêu đề!";
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            labelKQ.Text = "";
            textBox1.Focus();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
