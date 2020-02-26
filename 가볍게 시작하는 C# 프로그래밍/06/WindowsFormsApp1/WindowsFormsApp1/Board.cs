using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1
{
    class Board
    {
        Clock clock;

        public Board(Clock p)
        {
            clock = p;
        }
        public void DrawBoard()
        {
           
            Pen p = new Pen(Color.White);
            double x, y, theta;

            for (int i = 0; i < 12; i++)
            {
                theta = (i * 30) * (Math.PI / 180);

                x = (clock.Size.Width / 2) + ((clock.Size.Width / 2) - 60) * Math.Cos(theta);
                y = (clock.Size.Height / 2) + ((clock.Size.Height / 2) - 60) * Math.Sin(theta);


                clock.g.DrawEllipse(p, (float)x -10 , (float)y -10, 20, 20);

            }
        }
    }
}
