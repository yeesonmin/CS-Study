using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_Form
{
    public partial class FocusApp : Form
    {
        public FocusApp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.button1.BackColor = SystemColors.Control;
            this.button2.Focus();
            if(this.button2.Focused)
            {
                this.button2.BackColor = SystemColors.ControlDark;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.button2.BackColor = SystemColors.Control;
            this.button1.Focus();
            if(this.button1.Focused)
            {
                this.button1.BackColor = SystemColors.ControlDark;
            }
        }
    }
}
