using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_Graphics
{
    public partial class GraphicsPracticeApp : Form
    {
        public GraphicsPracticeApp()
        {
            InitializeComponent();
        }
        

        private void GraphicsPracticeApp_Load(object sender, EventArgs e)
        {
            
        }

        private void GraphicsPracticeApp_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //Point[] pts =
            //{
            //    new Point(ClientRectangle.Width/2,0),
            //    new Point(0, ClientRectangle.Height),
            //    new Point(ClientRectangle.Width,ClientRectangle.Height)
            //};
            //PathGradientBrush b = new PathGradientBrush(pts);
            //g.FillRectangle(b, ClientRectangle);
            //b.Dispose();
            Random r = new Random();
            Color c = Color.FromArgb(r.Next(0,255), r.Next(0, 255), r.Next(0, 255));
            Pen p = new Pen(c);
            Point[] pts = 
            {
                new Point(110,45), new Point(125,91), new Point(180,91),
                new Point(135,123), new Point(152,172), new Point(110,142),
                new Point(66,172), new Point(82,122),new Point(40,91),
                new Point(95,91)
            };
            //Point start = new Point(4, 23);
            //Point end = new Point(23, 4);
            //Rectangle a = new Rectangle(50, 50, 100, 100);
            g.FillPolygon(Brushes.LightYellow,pts);
            p.Dispose();
        }
    }
}
