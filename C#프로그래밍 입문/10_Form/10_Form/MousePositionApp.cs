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
    public partial class MousePositionApp : Form
    {
        public MousePositionApp()
        {
            InitializeComponent();
        }

        private void MousePositionApp_MouseEnter(object sender, EventArgs e)
        {
            Point mousePoint = PointToClient(MousePosition);
            MessageBox.Show("마우스 위치 : " + mousePoint.X + " , " + mousePoint.Y);
        }
    }
}
