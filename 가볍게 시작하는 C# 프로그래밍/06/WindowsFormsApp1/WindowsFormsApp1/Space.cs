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
    public partial class Space : Form
    {
        Star[] stars;
        public Graphics g;
        public int countStar = 50;

        public Space()
        {
            InitializeComponent();
            StartStar();
            timer1.Start();
        }

        void StartStar()
        {
            g = this.CreateGraphics();
            stars = new Star[countStar];

            for(int n = 0; n<stars.Length;n++)
            {
                stars[n] = new Star(this, n);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for(int n = 0; n< stars.Length;n++)
            {
                stars[n].Move();
            }
        }
    }
}
