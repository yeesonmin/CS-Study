using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_Control
{
    public partial class ListBoxApp : Form
    {
        public ListBoxApp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text !="")
            {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Text = "";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex > -1)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }
    }
}
