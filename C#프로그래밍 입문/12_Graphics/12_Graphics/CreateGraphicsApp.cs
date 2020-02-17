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
    public partial class CreateGraphicsApp : Form
    {
        int w, h; //판 크기
        const int xNum = 25, yNum = 25; //칸의 수
        int xW, yH; //칸 크기
        public CreateGraphicsApp()
        {
            InitializeComponent();
        }

        private void CreateGraphicsApp_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            Random r = new Random();
            Color c = Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));
            //g.FillRectangle(new SolidBrush(c), ClientRectangle);
            SolidBrush b = new SolidBrush(Color.Black);
            g.FillRectangle(b, new Rectangle(3 * 10, 1 * 10, 10, 10));
        }
    }
}
