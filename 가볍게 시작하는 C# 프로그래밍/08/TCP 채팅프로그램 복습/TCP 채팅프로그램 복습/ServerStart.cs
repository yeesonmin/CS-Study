using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace TCP_채팅프로그램_복습
{
    public class ServerStart
    {
        Socket server = null;
        Socket client = null;
        Thread clientThread;
        Form1 form1 = new Form1();
        public void serverStart()
        {
            form1 = (Form1)Application.OpenForms["Form1"];

            int portNum = Int32.Parse(form1.txt_PortNum.Text);
            IPEndPoint ipep = new IPEndPoint(IPAddress.Any, portNum);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            server.Bind(ipep);
            server.Listen(10);
            form1.txt_View.Text += "서버를 시작합니다.\r\n";

            while (true)
            {
               
                client = server.Accept();
                form1.txt_View.Text += "클라이언트" + form1.clientCNT + "이 접속했습니다.\r\n";

                clientThread = new Thread(new ThreadStart(RunClient));
                clientThread.Start();
                
            }
           


        }

        void RunClient()
        {
            byte[] data = new byte[1024];
            string message = "";

            client.Receive(data);
            message = Encoding.Default.GetString(data);
            form1.txt_View.Text += "클라이언트" + form1.clientCNT + " : " + message + "\r\n";
        }

        public void serverStop()
        {
            clientThread.Abort();
            client.Close();
            server.Close();
        }
    }
}
