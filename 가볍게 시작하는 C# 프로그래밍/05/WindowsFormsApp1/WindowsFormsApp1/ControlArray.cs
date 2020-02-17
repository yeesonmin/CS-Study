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
    
    public partial class ControlArray : Form
    {
        Button[] buttons = new Button[12];
        public ControlArray()
        {
            InitializeComponent();
            for(int i = 0; i<buttons.Length; i++)
            {
                buttons[i] = new Button();
                buttons[i].Text = (i+1).ToString();
                buttons[i].Size = new Size(50, 50);
                buttons[i].Location = new Point((i - (i/4)*4)*(buttons[i].Size.Width) + 5,(i/4)*buttons[i].Size.Height+5);

                //버튼이벤트 추가
                buttons[i].Tag = i+1;
                buttons[i].Click += new EventHandler(buttons_Click);
                this.Controls.Add(buttons[i]);
            }
        }

        //버튼이벤트 함수추가
        void buttons_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
          
            label1.Text = button.ToString();
        }
    }
}
