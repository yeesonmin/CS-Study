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
    public partial class MouseWheelApp : Form
    {
        private int num;
        public MouseWheelApp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            num = 0;
            textBox1.Text = num.ToString();

        }

        private void MouseWheelApp_Load(object sender, EventArgs e)
        {
            this.MouseWheel += new MouseEventHandler(this.MouseWheelApp_MouseWheel);
        }

        private void MouseWheelApp_MouseWheel(object sender,MouseEventArgs e)
        {
            textBox1.Text = (e.Delta > 0 ? num++ : num--).ToString();
        }
    }
}
