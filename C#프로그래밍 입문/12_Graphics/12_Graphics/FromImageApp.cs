using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_Graphics
{
    public partial class FromImageApp : Form
    {
        public FromImageApp()
        {
            InitializeComponent();
        }

        private void FromImageApp_Paint(object sender, PaintEventArgs e)
        {
            Size s = ClientRectangle.Size;
            Image img = new Bitmap(s.Width, s.Height);
            Graphics bg = Graphics.FromImage(img);
            Random r = new Random();
            Color c = Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));
            bg.FillRectangle(new SolidBrush(c), ClientRectangle);

            Graphics fg = e.Graphics;
            fg.DrawImage(img, 0, 0);
        }
    }
}
