using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baitap_B1
{
    public partial class Bai_2 : Form
    {
        public Bai_2()
        {
            InitializeComponent();
        }

        private void Bai_2_Load(object sender, EventArgs e)
        {
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "dd/MM/yyyy";
        }

        private void buttonAdd_MouseClick(object sender, MouseEventArgs e)
        {
            if (textContent.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập nội dung");
                return;
            }

            string time = dateTimePicker.Value.ToString("dd/MM/yyyy");
            string content = textContent.Text.Trim();

            content = content.Replace(Environment.NewLine, " | ");

            if (content.Length > 10)
            {
                content = content.Substring(0, 10) + "...";
            }

            listContent.Items.Add(time + ": " + content);

            textContent.Clear();
        }

        private void buttonRemove_MouseClick(object sender, MouseEventArgs e)
        {
            if (listContent.Items.Count == 0)
            {
                MessageBox.Show("Không có dòng nào để xóa");
                return;
            }

            string selectedTime = dateTimePicker.Value.ToString("dd/MM/yyyy");

            for (int i = 0; i < listContent.Items.Count; i++)
            {
                string item = listContent.Items[i].ToString();

                if (item.StartsWith(selectedTime))
                {
                    listContent.Items.RemoveAt(i);
                    return;
                }
            }

            MessageBox.Show("Không tìm thấy nội dung với thời gian đã chọn");
        }
    }
}