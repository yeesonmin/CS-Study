using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Control
{
    public partial class Example1 : UserControl
    {
        Button[] buttons = new Button[3];
        public Example1()
        {
            InitializeComponent();

            for(int i = 0; i<buttons.Length;i++)
            {
                buttons[i] = new Button();
                buttons[i].Text = (i + 1).ToString() + "번째 버튼";
                buttons[i].Size = new Size((int)((this.Width * 0.8) / 3), (int)((this.Height * 0.6) - label1.Height));
                buttons[i].Location = new Point(
                    (((this.Width - (buttons[i].Width * buttons.Length)) / 4) * (i + 1)) + (buttons[i].Width) * i,
                    (this.Height - (label1.Height + label1.Location.Y)) / 2);
                buttons[i].BackColor = Color.White;

                buttons[i].Click += new EventHandler(Example1_Click);
                this.Controls.Add(buttons[i]);
            }
        }

        void Example1_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            label1.Text = button.Text + "눌림.";
        }
        public bool setButtonsText(int index, string text)
        {
            buttons[index].Text = text;
            return true;
        }
    }
}
