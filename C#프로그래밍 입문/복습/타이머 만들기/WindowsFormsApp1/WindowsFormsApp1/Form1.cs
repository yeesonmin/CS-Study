using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp1
{
    
    public partial class Form1 : Form
    {

        //delegate void SetTimeCall();
        bool go = true;
       public void SetTime()
        {
            Time();
        }
        public void Time()
        {
            int s = (int)cmb_S.SelectedItem;
            int h = (int)cmb_H.SelectedItem, m = (int)cmb_M.SelectedItem;

            while (go)
            {
                if (s == 0 && m == 0 && h == 0)
                {
                    break;
                }
                else
                {
                    if (h == 0)
                    {
                        if (m == 0)
                        {

                            s--;
                            lbl_S.Text = s.ToString();

                        }
                        else
                        {
                            s--;
                            if (s < 0)
                            {
                                s = 59;
                                lbl_S.Text = s.ToString();
                                m--;
                                lbl_M.Text = m.ToString();
                            }
                            else
                            {
                                lbl_S.Text = s.ToString();
                            }


                        }
                    }
                    else
                    {
                        s--;
                        if (s < 0)
                        {
                            s = 59;
                            lbl_S.Text = s.ToString();
                            m--;
                            if (m < 0)
                            {
                                m = 59;
                                lbl_M.Text = m.ToString();
                                h--;
                                lbl_H.Text = h.ToString();

                            }
                            else
                            {
                                lbl_M.Text = m.ToString();
                            }

                        }
                        else
                        {
                            lbl_S.Text = s.ToString();
                        }
                    }
                }

            }
            //Thread.Sleep(1000);

            //if (InvokeRequired)
            //{
            //    SetTimeCall d = new SetTimeCall(Time);
            //    Invoke(d);
                

               
            //}

            
        }
       
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ThreadStart ts = new ThreadStart(SetTime);
            //Thread t = new Thread(ts);
            //t.Start();
            Time();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 24; i++)
            {
                //if(i <10)
                //{
                //    cmb_H.Items.Add(string.Format("{0:d2}",i));
                //}
                //else
                //{
                //    cmb_H.Items.Add(i);
                //}

                cmb_H.Items.Add(i);

            }
            for (int i = 0; i < 60; i++)
            {
                //if (i < 10)
                //{
                //    cmb_M.Items.Add(string.Format("{0:d2}", i));
                //    cmb_S.Items.Add(string.Format("{0:d2}", i));
                //}
                //else
                //{
                //    cmb_M.Items.Add(i);
                //    cmb_S.Items.Add(i);
                //}
                cmb_M.Items.Add(i);
                cmb_S.Items.Add(i);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lbl_H.Text = cmb_H.Text;
            lbl_M.Text = cmb_M.Text;
            lbl_S.Text = cmb_S.Text;

        }
    }
}
