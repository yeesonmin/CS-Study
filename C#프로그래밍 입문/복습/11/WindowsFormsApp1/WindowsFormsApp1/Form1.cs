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

       

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection item  = listView1.SelectedItems;
            ListViewItem i = item[0];

            switch(i.Text)
            {
                case "메모장":
                    System.Diagnostics.Process.Start("notepad");
                    break;
                case "계산기":
                    System.Diagnostics.Process.Start("calc");
                    break;
                case "그림판":
                    System.Diagnostics.Process.Start("mspaint");
                    break;
            }
                
           
           

            

        }
    }
}
