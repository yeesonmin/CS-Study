using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_From
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            startDatetime = DateTime.Now;
        }
        DateTime startDatetime;
        public DateTime GetStartDateTime()
        {
            return startDatetime;
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
           
            SetButtonText();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("closed");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("닫을거야?","??",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void SetButtonText()
        {
            button1.Text = "위치 = " +  Location+ "\n" + "left/ringt/width = " + Left + "," + Right + "," +Width+"\n" + "Top/bottom/height = " + Top + "," + Bottom + "," + Height;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Random r = new Random();
            Color c = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
            g.FillRectangle(new SolidBrush(c), e.ClipRectangle);
        }

        private void Form1_Move(object sender, EventArgs e)
        {
            SetButtonText();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            SetButtonText();
        }
    }
}
