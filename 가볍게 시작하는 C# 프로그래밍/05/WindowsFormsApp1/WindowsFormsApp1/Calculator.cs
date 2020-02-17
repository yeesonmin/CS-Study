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
    public partial class Calculator : Form
    {
        Button[] buttons = new Button[16];
        int cal = 0;
        int[] values = new int[2];
        int step = 0;
        
        public Calculator()
        {
            InitializeComponent();
            label1.Text = "0";
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i] = new Button();
                if(i + 1 == 4 || i + 1 == 8 || i + 1 == 12 || i + 1 == 16 || i + 1 == 15 || i + 1 == 14)
                {
                    if(i+1 == 4)
                    {
                        buttons[i].Text = "+";
                        buttons[i].Tag = "+";
                    }
                    else if(i + 1 == 8)
                    {
                        buttons[i].Text = "-";
                        buttons[i].Tag = "-";
                    }
                    else if (i + 1 == 12)
                    {
                        buttons[i].Text = "X";
                        buttons[i].Tag = "*";
                    }
                    else if (i + 1 == 16)
                    {
                        buttons[i].Text = "/";
                        buttons[i].Tag = "/";
                    }
                    else if (i + 1 == 15)
                    {
                        buttons[i].Text = "=";
                        buttons[i].Tag = "=";
                    }
                    else if (i + 1 == 14)
                    {
                        buttons[i].Text = "C";
                        buttons[i].Tag = "C";
                    }

                }
                else
                {
                    if(i+1 >=1 && i+1 <=3)
                    {
                        buttons[i].Text = (i + 1 + 6).ToString();
                        buttons[i].Tag = (i + 1 + 6);
                    }
                    else if(i + 1 >= 5 && i + 1 <= 7)
                    {
                        buttons[i].Text = (i  ).ToString();
                        buttons[i].Tag = (i);
                    }
                    else if (i + 1 >= 9 && i + 1 <= 11)
                    {
                        buttons[i].Text = (i - 7).ToString();
                        buttons[i].Tag = (i - 7);
                    }
                    else
                    {
                        buttons[i].Text = (i - 12).ToString();
                        buttons[i].Tag = (i - 12);
                    }

                }
               
                buttons[i].Size = new Size(60, 60);
                buttons[i].Location = new Point(
                    (i - (i / 4) * 4) * (buttons[i].Size.Width +5) + label1.Location.X
                    ,(i / 4) * (buttons[i].Size.Height + 5) + 8 + label1.Size.Height + label1.Location.Y);

                //버튼이벤트 추가
               
                buttons[i].Click += new EventHandler(buttons_Click);
                this.Controls.Add(buttons[i]);
            }
        }

        void buttons_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string s = button.Tag.ToString();
           
           if(label1.Text == "0")
            {
                label1.Text = s.ToString();
                values[step] = int.Parse(label1.Text);
            }
            else
            {
                switch(s)
                {
                    case "C":
                        label1.Text = "0";
                        cal = 0;
                        step = 0;
                        values[0] = 0;
                        values[1] = 0;
                        break;
                    case "+":
                        label1.Text = "0";
                        step = 1;
                        cal = 1;
                        break;
                    case "-":
                        label1.Text = "0";
                        step = 1;
                        cal = 2;
                        break;
                    case "*":
                        label1.Text = "0";
                        step = 1;
                        cal = 3;
                        break;
                    case "/":
                        label1.Text = "0";
                        step = 1;
                        cal = 4;
                        break;
                    case "=":
                        switch (cal)
                        {
                            case 1:
                                
                                label1.Text = (values[0] + values[1]).ToString();
                                step = 0;
                                values[0] = 0;
                                values[1] = 0;
                                break;
                            case 2:
                              
                                label1.Text = (values[0] - values[1]).ToString();
                                step = 0;
                                values[0] = 0;
                                values[1] = 0;
                                break;
                            case 3:
                                
                                label1.Text = (values[0] * values[1]).ToString();
                                step = 0;
                                values[0] = 0;
                                values[1] = 0;
                                break;
                            case 4:
                                
                                label1.Text = (values[0] / values[1]).ToString();
                                step = 0;
                                values[0] = 0;
                                values[1] = 0;
                                break;

                        }
                        break;
                    default:
                        label1.Text += s.ToString();
                        values[step] = int.Parse(label1.Text);
                        break;

                }
               
                
            }
        }
    }
}
