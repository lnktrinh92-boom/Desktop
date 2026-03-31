using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi_2
{
    public partial class StackDelete : Form
    {
        public StackDelete()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (listBoxLeft.Items.IndexOf(textInput.Text) < 0 && textInput.Text.Length > 0)
            {
                //listBoxLeft.Items.Add(textInput.Text);
                listBoxLeft.Items.Insert(0, textInput.Text);
            }    
        }

        private void listBoxLeft_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxLeft.SelectedIndex >= 0)
            {
                textInput.Text = listBoxLeft.Items[listBoxLeft.SelectedIndex].ToString();
                //textInput.Text = listBoxLeft.SelectedItem.ToString();
            }    
        }

        private void buttonDeleteLeft_Click(object sender, EventArgs e)
        {
            if (listBoxLeft.SelectedIndex >= 0)
            {
                listBoxLeft.Items.RemoveAt(listBoxLeft.SelectedIndex);
            }    
        }

        private void listBoxRight_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxRight.SelectedIndex >= 0)
            {
                textInput.Text = listBoxRight.Items[listBoxRight.SelectedIndex].ToString();
                //textInput.Text = listBoxRight.SelectedItem.ToString();
            }
        }

        private void buttonDeleteRight_Click(object sender, EventArgs e)
        {
            if (listBoxRight.SelectedIndex >= 0)
            {
                listBoxRight.Items.RemoveAt(listBoxRight.SelectedIndex);
            }
        }

        private void buttonToRight_Click(object sender, EventArgs e)
        {
            if (listBoxLeft.SelectedIndex >= 0)
            {
                listBoxRight.Items.Insert(0, listBoxLeft.SelectedItem);
                listBoxLeft.Items.RemoveAt(listBoxLeft.SelectedIndex);
            }    
        }

        private void buttonToLeft_Click(object sender, EventArgs e)
        {
            if (listBoxRight.SelectedIndex >= 0)
            {
                listBoxLeft.Items.Insert(0, listBoxRight.SelectedItem);
                listBoxRight.Items.RemoveAt(listBoxRight.SelectedIndex);
            }
        }

        private void xoaTrung()
        {
            for (int i = 0; i < listBoxRight.Items.Count; i++)
            {
                if (listBoxRight.Items.IndexOf(listBoxRight.Items[i]) < i
                    && listBoxRight.Items.IndexOf(listBoxRight.Items[i]) > -1)
                {
                    listBoxRight.Items.RemoveAt(i);
                    i--;
                }
            }
        }

        private void buttonAllToRight_Click(object sender, EventArgs e)
        {
            if (listBoxLeft.Items != null)
            {
                listBoxRight.Items.AddRange(listBoxLeft.Items);
                listBoxLeft.Items.Clear();

                xoaTrung();
            }    
        }

        private void buttonAllToLeft_Click(object sender, EventArgs e)
        {
            if (listBoxRight.Items != null)
            {
                listBoxLeft.Items.AddRange(listBoxRight.Items);
                listBoxRight.Items.Clear();
            }
        }
    }
}
