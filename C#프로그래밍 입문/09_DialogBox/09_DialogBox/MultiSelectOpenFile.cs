using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_DialogBox
{
    public partial class MultiSelectOpenFile : Form
    {
        public MultiSelectOpenFile()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Filter = "텍스트 파일(*.txt)|*.txt|모든파일(*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.Multiselect = true;
            openFileDialog1.RestoreDirectory = true;
            
            openFileDialog1.ShowDialog();

            foreach(string a in openFileDialog1.FileNames)
            {
                textBox1.Text += a;
                textBox1.Text += "\r\n";
               
            }

        }
    }
}
