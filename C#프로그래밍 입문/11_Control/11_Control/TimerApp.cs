using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_Control
{
    public partial class TimerApp : Form
    {
        public TimerApp()
        {
            InitializeComponent();
        }
        private int index = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            // index %= imageList1.Images.Count;
            if (index == imageList1.Images.Count)
                index = 0;

            label1.Image = imageList1.Images[index++];
        }
    }
}
