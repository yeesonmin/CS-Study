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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sum;
            sum = int.Parse(textBox1.Text) + int.Parse(textBox2.Text);
            textBox3.Text = sum.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sub;
            sub = int.Parse(textBox1.Text) - int.Parse(textBox2.Text);
            textBox3.Text = sub.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            int mul;
            mul = int.Parse(textBox1.Text) * int.Parse(textBox2.Text);
            textBox3.Text = mul.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int div;
            div = int.Parse(textBox1.Text) / int.Parse(textBox2.Text);
            textBox3.Text = div.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int re;
            re = int.Parse(textBox1.Text) % int.Parse(textBox2.Text);
            textBox3.Text = re.ToString();
        }
    }
}
