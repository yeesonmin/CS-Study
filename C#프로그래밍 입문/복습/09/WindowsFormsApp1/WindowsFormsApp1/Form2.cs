using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Filter = "텍스트파일(*.txt)|*.txt|모든파일(*.*)|*.*";
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Multiselect = false;
            openFileDialog1.ShowDialog();

            FileStream fs  = new FileStream(openFileDialog1.FileName,FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            while(sr.Peek() >= 0)
            {
                textBox1.Text += sr.ReadLine();
                textBox1.Text += "\r\n";
            }
            sr.Close();

            
            
        }
    }
}
