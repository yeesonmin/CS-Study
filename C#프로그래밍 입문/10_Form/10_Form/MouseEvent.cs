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
    public partial class MouseEvent : Form
    {
        public MouseEvent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            UpdateEventLabel("MouseDown", e.X, e.Y, e);
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void UpdateEventLabel(string msg, int x, int y, MouseEventArgs e)
        {
            string message = string.Format("{0} x:{1}, y:{2}", msg, x, y);
            string eventMsg = DateTime.Now.ToShortTimeString();
            eventMsg = eventMsg + "" + message;
            listBox1.Items.Add(eventMsg);
            string mouseInfo;
            if(e !=null)
            {
                mouseInfo = string.Format("Clicks : {0}, Delta : {1}, Button : {2}", e.Clicks, e.Delta, e.Button.ToString());
            }else
            {
                mouseInfo = string.Format("Clicks : {0}", msg);
            }
            label1.Text = mouseInfo;
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            UpdateEventLabel("MouseDoubleClick", e.X, e.Y, e);
        }
    }
}
