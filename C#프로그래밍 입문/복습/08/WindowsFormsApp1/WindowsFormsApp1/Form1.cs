using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label3.TextAlign = ContentAlignment.MiddleLeft;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label3.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label3.TextAlign = ContentAlignment.MiddleRight;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
            label3.Font = new Font(label3.Font.FontFamily, label3.Font.Size, FontStyle.Bold ^ label3.Font.Style);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            label3.Font = new Font(label3.Font.FontFamily, label3.Font.Size, FontStyle.Underline ^ label3.Font.Style);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            label3.Font = new Font(label3.Font.FontFamily, label3.Font.Size, FontStyle.Italic ^ label3.Font.Style);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            label3.Font = new Font(label3.Font.FontFamily, label3.Font.Size, FontStyle.Strikeout ^ label3.Font.Style);
        }
    }
}
