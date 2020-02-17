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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!((char.IsDigit(e.KeyChar)) || e.KeyChar == 45 || e.KeyChar ==Convert.ToChar(Keys.Back) ))
            {
                e.Handled = true;
            }
        }
    }
}