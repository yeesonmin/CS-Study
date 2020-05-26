using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCP_채팅프로그램_복습
{
    public partial class Client : Form
    {
        Form1 server;
        public Client()
        {
            InitializeComponent();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            server = (Form1)Application.OpenForms["Form1"];
            this.Text = "클라이언트" + server.clientCNT;
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {

        }
    }
}
