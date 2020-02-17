using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_Form
{
    public partial class KeyEventAPp : Form
    {
        public KeyEventAPp()
        {
            InitializeComponent();
        }
        public int xPt, yPt;
       // public static readonly int Move = 10;
        public int Move = 10;

        private void button1_KeyUp(object sender, KeyEventArgs e)
        {
            this.xPt = this.button1.Location.X;
            this.yPt = this.button1.Location.Y;
            switch (e.KeyCode)
            {
                case Keys.Left:
                    xPt -= Move;
                    break;
                case Keys.Right:
                    xPt += Move;
                    break;
                case Keys.Up:
                    yPt -= Move;
                    break;
                case Keys.Down:
                    yPt += Move;
                    break;
            }
            this.button1.Text = e.KeyCode.ToString();
            this.button1.Location = new Point(xPt, yPt);
        }
    }
}
