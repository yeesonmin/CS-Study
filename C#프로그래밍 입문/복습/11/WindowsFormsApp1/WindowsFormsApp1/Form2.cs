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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

       

        private void treeView1_Click(object sender, EventArgs e)
        {
            
            
            
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            listView1.Clear();
            foreach (TreeNode n in treeView1.SelectedNode.Nodes)
            {
                listView1.Items.Add(n.Text,n.ImageIndex);
        
                    
            }
        }
    }
}
