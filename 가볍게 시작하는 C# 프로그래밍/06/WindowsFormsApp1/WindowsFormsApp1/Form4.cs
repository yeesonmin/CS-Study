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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            Pen p = new Pen(Color.White);
            double x, y, theta;

            for(int i = 0; i<12; i++)
            {
                theta = (i * 30) * (Math.PI / 180);

                x = (this.Width / 2) + 200 * Math.Cos(theta);
                y = (this.Height / 2) + 200 * Math.Sin(theta);

                //-10은 원 중앙으로 기준
                g.DrawEllipse(p, (float)x - 10, (float)y - 10, 20, 20);
            }

            g.Dispose();

        }
    }
}
