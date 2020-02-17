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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_KeyDown(object sender, KeyEventArgs e)
        {
            
            
            if(e.Shift == true && e.KeyCode == Keys.F1)
            {
                MessageBox.Show("F1 + Shift", "누른 키", MessageBoxButtons.OK);
            }else if (e.Control == true && e.KeyCode == Keys.F1)
            {
                MessageBox.Show("F1 + Control", "누른 키", MessageBoxButtons.OK);
            }
            else if (e.Alt == true && e.KeyCode == Keys.F1)
            {
                MessageBox.Show("F1 + Alt", "누른 키", MessageBoxButtons.OK);
            }
            else if (e.KeyCode == Keys.F1)
            {
                MessageBox.Show("F1", "누른 키", MessageBoxButtons.OK);
            }


        }
    }
}
