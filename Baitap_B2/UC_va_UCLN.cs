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
    public partial class UC_va_UCLN : Form
    {
        public UC_va_UCLN()
        {
            InitializeComponent();
        }

        int GCD(int a, int b)
        {
            while (b != 0)
            {
                int t = a % b;
                a = b;
                b = t;
            }
            return Math.Abs(a);
        }

        List<int> GetDivisors(int n)
        {
            List<int> list = new List<int>();
            n = Math.Abs(n);

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    list.Add(i);
            }
            return list;
        }

        private void UC_va_UCLN_Load(object sender, EventArgs e)
        {
            radioButtonUC.Checked = true;
        }

        private void textBoxNum1_TextChanged(object sender, EventArgs e)
        {
            Run();
        }

        private void textBoxNum2_TextChanged(object sender, EventArgs e)
        {
            Run();
        }

        private void radioButtonUC_CheckedChanged(object sender, EventArgs e)
        {
            Run();
        }

        private void radioButtonUCLN_CheckedChanged(object sender, EventArgs e)
        {
            Run();
        }

        void Run()
        {
            listBox1.Items.Clear();

            if (!int.TryParse(textBoxNum1.Text, out int a)) return;
            if (!int.TryParse(textBoxNum2.Text, out int b)) return;

            int gcd = GCD(a, b);

            if (radioButtonUCLN.Checked)
            {
                listBox1.Items.Add("UCLN = " + gcd);
            }
            else if (radioButtonUC.Checked)
            {
                var list = GetDivisors(gcd);
                foreach (var x in list)
                    listBox1.Items.Add(x);
            }
        }
    }
}
