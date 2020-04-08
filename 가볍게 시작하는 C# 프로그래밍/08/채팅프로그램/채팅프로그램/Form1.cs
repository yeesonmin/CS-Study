using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 채팅프로그램
{
    public partial class Form1 : Form
    {
        delegate void UpdateTextCallback(string message);
        public Form1()
        {
            InitializeComponent();

            txt_MyIp.Text = "127.0.0.1";
            txt_MyPort.Text = "3317";
            txt_ServerIp.Text = "127.0.0.1";
            txt_ServerPort.Text = "3317";
        }

        //멀티스레딩에서 사용
        private void AppenMessage(string message)
        {
            try
            {
                if(txt_send.InvokeRequired)
                {
                    UpdateTextCallback d = new UpdateTextCallback(AppenMessage);
                    Invoke(d, new object[] { message });
                }else
                {
                    txt_View.AppendText(message + "\r\n");
                    txt_View.ScrollToCaret();
                    txt_send.Focus();
                }
            }
            catch { }
        }

        //메세지 전달
        public void NotifyMessage(string message)
        {
            message = "----------알림!----------\r\n" + message + "\r\n----------\r\n";
            AppenMessage(message);

        }


        
        private void bnt_SeverStart_Click(object sender, EventArgs e)
        {
            Socket server = null;
            Socket client = null;
            byte[] data = new byte[1024];
            string message = "";

            int portNum = Int32.Parse(txt_MyPort.Text.ToString());

            IPEndPoint ipep = new IPEndPoint(IPAddress.Any, portNum);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            server.Bind(ipep);
            server.Listen(10);

            NotifyMessage("서버를 시작합니다.\n클라이언트 접속을 대기합니다.");

            client = server.Accept();

            NotifyMessage("클라이언트가 접속했습니다.");

            client.Receive(data);

            message = Encoding.Default.GetString(data);
            message = "상대방: " + message;
            AppenMessage(message);

            client.Close();
            server.Close();


        }

        private void bnt_SeverAccept_Click(object sender, EventArgs e)
        {
            byte[] data = new byte[1024];
            string serverIPAddress = "";
            int portNum = 0;

            serverIPAddress = txt_ServerIp.Text.Trim();
            portNum = Int32.Parse(txt_ServerPort.Text.Trim());

            IPAddress ipAddress = IPAddress.Parse(serverIPAddress);
            IPEndPoint ipep = new IPEndPoint(ipAddress, portNum);

            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            NotifyMessage("서버에 접속합니다.");
            server.Connect(ipep);

            NotifyMessage("서버에 접속했습니다. 메세지를 보내세요.");

            data = Encoding.Default.GetBytes("클라이언트에서 보내는 메세지 입니다.");
            server.Send(data);

            NotifyMessage("서버에 데이터를 전송했습니다.");

            server.Close();
        }
    }
}
