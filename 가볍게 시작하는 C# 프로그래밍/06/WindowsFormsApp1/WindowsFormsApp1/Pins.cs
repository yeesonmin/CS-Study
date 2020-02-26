using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1
{
    class Pins
    {
        Clock clock;

        public Pins(Clock parent)
        {
            clock = parent;
        }

        public void GetTime(ref int hour, ref int minute, ref int second)
        {
            hour = DateTime.Now.Hour;
            minute = DateTime.Now.Minute;
            second = DateTime.Now.Second;
        }

        public void DrawPins(int h, int m, int s)
        {
            double x, y, theta;
            int centerx = clock.Width / 2;
            int centery = clock.Height / 2;

            theta = ((h * 30 - 90) + m * 0.5) * (Math.PI / 180);
            x = centerx + (centerx - 180) * Math.Cos(theta);
            y = centery + (centery - 180) * Math.Sin(theta);
            clock.g.DrawLine(new Pen(Color.White,5), centerx, centery, (float)x, (float)y);

            theta = (m * 6 -90) * (Math.PI / 180);
            x = centerx + (centerx - 80) * Math.Cos(theta);
            y = centery + (centery - 80) * Math.Sin(theta);
            clock.g.DrawLine(new Pen(Color.White,3), centerx, centery, (float)x, (float)y);

            theta = (s*6 - 90) * (Math.PI / 180);
            x = centerx + (centerx - 60) * Math.Cos(theta);
            y = centery + (centery - 60) * Math.Sin(theta);
            clock.g.DrawLine(new Pen(Color.Red, 1), centerx, centery, (float)x, (float)y);
        }
        public void Refrash()
        {
            int h = 0, m = 0, s = 0;

            GetTime(ref h, ref m, ref s);
            DrawPins(h, m, s);
        }
    }
}
