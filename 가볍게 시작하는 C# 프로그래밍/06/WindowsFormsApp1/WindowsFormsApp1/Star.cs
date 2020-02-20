using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1
{
    class Star
    {
        Space frmMain;
        Random r;
        Color color;
        int cx, cy, radius; //radius : 중심 점과 별의 거리
        double theta;
        float size;

        public Star()
        {

        }

        public Star(Space parents, int i)
        {
            frmMain = parents;

            cx = parents.Width / 2;
            cy = parents.Height / 2;

            StartStar(i);
        }

        void StartStar(int i)
        {
            int degree;
            r = new Random(i);
            radius = r.Next(0, GetLongestDistance());
            color = Color.FromArgb(255, r.Next(255), r.Next(255), r.Next(255));

            degree = (360 / frmMain.countStar) * i;
            theta = degree * Math.PI / 180;
        }

        public void Move()
        {
            Draw(new SolidBrush(Color.Black));

            radius += 1 + (radius / 10);
            size = 1 + (radius / 50);

            Draw(new SolidBrush(color));

            if(radius>GetLongestDistance())
            {
                radius = r.Next(GetLongestDistance());
            }

        }

        void Draw(SolidBrush b)
        {
            double x, y;

            x = cx + radius * Math.Cos(theta);
            y = cy + radius * Math.Sin(theta);

            frmMain.g.FillEllipse(b, (float)x - size / 2, (float)y - size / 2, (float)size, (float)size);

        }
        int GetLongestDistance()
        {
            return (int)(Math.Sqrt(Math.Pow(cx,2) + Math.Pow(cy,2)));
        }
    }
}
