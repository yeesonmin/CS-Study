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
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                fontDialog1.ShowApply = true;
            }
            else
            {
                fontDialog1.ShowApply = false;
            }
            if(checkBox2.Checked == true)
            {
                fontDialog1.ShowColor = true;
            }else
            {
                fontDialog1.ShowColor = false;
            }
            fontDialog1.ShowDialog();
        }
    }
}
