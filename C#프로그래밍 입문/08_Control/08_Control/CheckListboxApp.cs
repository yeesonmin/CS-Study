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
    public partial class CheckListboxApp : Form
    {
        public CheckListboxApp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = "";
            foreach(object obj in checkedListBox1.CheckedItems)
            {
                a += obj.ToString();
                a += " ";
            }

            MessageBox.Show("선택 : " + a);
        }
    }
}
