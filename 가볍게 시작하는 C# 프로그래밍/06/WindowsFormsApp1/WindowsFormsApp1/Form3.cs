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
            Graphics g = CreateGraphics();
            //Pen p;
            Brush b;
            Random r = new Random();

            //p = new Pen(Color.FromArgb(255, r.Next(255), r.Next(255), r.Next(255)));
            b = new SolidBrush(Color.FromArgb(255, r.Next(255), r.Next(255), r.Next(255)));

            // g.DrawRectangle(p, r.Next(this.Width), r.Next(this.Height), 30, 30);
            g.FillRectangle(b, r.Next(this.Width), r.Next(this.Height), 30, 30);
            g.Dispose();

        }
    }
}
