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
    public partial class SetTime : Form
    {
        public SetTime()
        {
            InitializeComponent();
        }


        //시간, 분, 초 코보박스 추가
        private void SetTime_Load(object sender, EventArgs e)
        {
            for(int i = 0; i <24; i++)
            {
                cmb_H.Items.Add(i);
            }
            for(int i = 0; i<60; i++)
            {
                cmb_M.Items.Add(i);
                cmb_S.Items.Add(i);
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.lbl_H.ForeColor = Color.Red;
            f.lbl_M.ForeColor = Color.Red;
            f.lbl_S.ForeColor = Color.Red;
            f.lbl_o1.ForeColor = Color.Red;
            f.lbl_o2.ForeColor = Color.Red;


        }
    }
}
