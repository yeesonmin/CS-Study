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
    public partial class Form1 : Form
    {
        public int clientCNT = 1;
        ServerStart serverstart;
        public Form1()
        {
            InitializeComponent();
        }

        private void bnt_ClientStart_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.Show();
            txt_View.Text += "클라이언트" + clientCNT + "접속을 시도합니다.\r\n";
            clientCNT++;
            ClientStart clientStart = new ClientStart();
            clientStart.clientStart(this,client);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_IPNum.Text = "127.0.0.1";
            txt_PortNum.Text = "1234";

        }

        private void btn_ServerStart_Click(object sender, EventArgs e)
        {
            serverstart = new ServerStart();
            serverstart.serverStart();
        }

        private void btn_ServerClose_Click(object sender, EventArgs e)
        {
            serverstart.serverStop();
        }
    }
}
