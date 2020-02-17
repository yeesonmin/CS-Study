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
    public partial class TextureBrushApp : Form
    {
        public TextureBrushApp()
        {
            InitializeComponent();
        }

        private void TextureBrush_Load(object sender, EventArgs e)
        {
           
            

        }

        private void TextureBrushApp_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Image img = new Bitmap("frame.png");
            TextureBrush b = new TextureBrush(img);
            g.FillRectangle(b, ClientRectangle);
            img.Dispose();
            b.Dispose();
           
        }
    }
}
