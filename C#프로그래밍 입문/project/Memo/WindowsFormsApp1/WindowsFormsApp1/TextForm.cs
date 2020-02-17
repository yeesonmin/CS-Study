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
    public partial class TextForm : Form
    {
        public bool save;
        public string savePoin;
        int opencount;
        public bool exit;
        public string SendValue { get; set; }
        public TextForm()
        {
            InitializeComponent();
            save = false;
            opencount = MainForm.opencount;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        public void TextForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm mf = (MainForm)MdiParent;
            mf.FileClose(this);
            if (exit == false)
            {
                e.Cancel = true;

            }

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            save = false;
        }
    }
}