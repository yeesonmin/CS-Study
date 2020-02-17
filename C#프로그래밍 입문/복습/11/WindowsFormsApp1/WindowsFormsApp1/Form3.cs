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
    public partial class Form3 : Form
    {
        int r = 0, g = 0, b = 0;
      
        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lbl_R.Text = trackBar1.Value.ToString();
            r = trackBar1.Value;
            g = trackBar2.Value;
            b = trackBar3.Value;
            label1.BackColor = Color.FromArgb(r,g,b);
      

            
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            lbl_G.Text = trackBar2.Value.ToString();
            r = trackBar1.Value;
            g = trackBar2.Value;
            b = trackBar3.Value;
            label1.BackColor = Color.FromArgb(r, g, b);
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            lbl_B.Text = trackBar3.Value.ToString();
            r = trackBar1.Value;
            g = trackBar2.Value;
            b = trackBar3.Value;
            label1.BackColor = Color.FromArgb(r, g, b);
        }
    }
}
