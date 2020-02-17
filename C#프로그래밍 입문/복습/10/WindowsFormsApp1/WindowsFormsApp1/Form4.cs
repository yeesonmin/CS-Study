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
        Point previousPoint;
        bool isDrag;
       

        private void Form4_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point currentPoint = new Point(e.X, e.Y);
                Pen p;

                if (radioButton1.Checked == true)
                {
                    p = new Pen(Color.Black, 5);

                }
                else if (radioButton2.Checked == true)
                {
                    p = new Pen(Color.Red, 5);

                }
                else if (radioButton3.Checked == true)
                {
                    p = new Pen(Color.Violet, 5);

                }
                else
                {
                    p = new Pen(Color.Green, 5);
                }
                Graphics g = this.CreateGraphics();
                g.DrawLine(p, previousPoint, currentPoint);
                previousPoint = currentPoint;
            }

        }

        public Form4()
        {
            InitializeComponent();
        }

      
        private void Form4_MouseDown(object sender, MouseEventArgs e)
        {
            previousPoint = new Point(e.X, e.Y);
        }
    }
}
