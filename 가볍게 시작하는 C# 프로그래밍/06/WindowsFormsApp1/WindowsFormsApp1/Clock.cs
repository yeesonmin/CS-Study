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
    public partial class Clock : Form
    {
        public Graphics g;
        Board board;
        Pins pins;
        public Clock()
        {
            InitializeComponent();
            Init();
            timer1.Start();
        }

        private void Init()
        {
            g = this.CreateGraphics();
            board = new Board(this);
            pins = new Pins(this);
        }
       

        private void Clock_Paint(object sender, PaintEventArgs e)
        {
            board.DrawBoard();
            pins.Refrash();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}
