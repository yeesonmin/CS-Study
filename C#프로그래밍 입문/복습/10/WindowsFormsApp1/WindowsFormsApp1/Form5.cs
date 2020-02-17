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
    public partial class Form5 : Form
    {
        const int xNum = 5, yNum = 4;
        int x, y;
        bool[,] click = new bool[xNum, yNum];

        private void Form5_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void Form5_Paint(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(Color.Black);
            Graphics g = this.CreateGraphics();
            x = ClientSize.Width / xNum;
            y = ClientSize.Height / yNum;

            for (int i = 0; i < xNum; i++)
            {
                for (int j = 0; j < yNum; j++)
                {
                    g.DrawRectangle(p, x * i, y * j, x, y);
                    if(click[i,j])
                    {
                        g.DrawEllipse(p, x * i, y * j, x, y);
                    }
                }

            }
        }

        private void Form5_MouseDown(object sender, MouseEventArgs e)
        {
            int x = e.X / (ClientSize.Width / xNum);
            int y = e.Y / (ClientSize.Height / yNum);

            if(x < xNum && y < yNum)
            {
                click[x, y] ^= true;
                Invalidate(new Rectangle((ClientSize.Width / xNum) * x, (ClientSize.Height / yNum) * y, ClientSize.Width / xNum, ClientSize.Height / yNum));
            }
            
        }

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

            OnResize(EventArgs.Empty);
        }
    }
}
