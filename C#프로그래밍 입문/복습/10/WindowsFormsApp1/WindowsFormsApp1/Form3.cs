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

        protected int x1, x2 = 0;
        protected int y1, y2 = 0;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_MouseDown(object sender, MouseEventArgs e)
        {
           
            x1 = e.X;
            y1 = e.Y;
            
        }

        private void Form3_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                x2 = e.X;
                y2 = e.Y;
                Invalidate();
            }
        }



        private void Form3_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(ForeColor);
            if(x1 < x2)
            {
                if(y1 < y2)
                {
                    g.DrawRectangle(p, x1, y1, x2 - x1, y2 - y1);
                }
                else
                {
                    g.DrawRectangle(p, x1, y2, x2 - x1, y1 - y2);
                }
                
            }else
            {
                if (y1 < y2)
                {
                    g.DrawRectangle(p, x2, y1, x1 - x2, y2 - y1);
                }

                else
                {
                    g.DrawRectangle(p, x2, y2, x1 - x2, y1 - y2);
                }
            }
            
        }
    }
}
