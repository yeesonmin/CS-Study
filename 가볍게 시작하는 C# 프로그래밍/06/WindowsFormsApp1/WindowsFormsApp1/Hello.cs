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
    public partial class Hello : Form
    {
        private const int fontSize = 15;
        private double x = 0, y = 0;
        private double acc = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            reDraw();
            y += acc; //가속도로 떨어짐.
            x++;

            if(y > this.Height) //글자가 바닥에 닿은 경우
            {
                acc *= -1;
                acc *= 0.8;

                if (Math.Abs(acc) < 1)
                    timer1.Stop();
            }
            else
            {
                acc += 0.2;
            }
        }

        private void reDraw()
        {
            Graphics g = CreateGraphics();
            g.DrawString("Hello", new Font("맑은 고딕", fontSize), new SolidBrush(Color.Black), (float)x, (float)y);

        }

        public Hello()
        {
            InitializeComponent();
            timer1.Start();
        }
    }
}
