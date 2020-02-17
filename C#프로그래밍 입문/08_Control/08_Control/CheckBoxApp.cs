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
    public partial class CheckBoxApp : Form
    {
        public CheckBoxApp()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLable(checkBox1.Text, checkBox1.Checked);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLable(checkBox2.Text, checkBox2.Checked);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLable(checkBox4.Text, checkBox4.Checked);
        }

        private void CheckBoxApp_Load(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLable(checkBox3.Text, checkBox3.Checked);
        }

        private void UpdateLable(string s, bool b)
        {
            if(b)
            {
                label1.Text += s;
            }
            else
            {
                string strTemp = label1.Text;
                int i = strTemp.IndexOf(s);
                label1.Text = strTemp.Remove(i, s.Length);
            }
        }
    }
}
