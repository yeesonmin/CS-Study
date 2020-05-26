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
    public class ClientStart
    {
        Socket server = null;
        Client clientForm;
        public void clientStart(Form1 form1)
        {

            int portNum = Int32.Parse(form1.txt_PortNum.Text);
            IPAddress ipAddress = IPAddress.Parse(form1.txt_IPNum.Text);
            IPEndPoint ipep = new IPEndPoint(ipAddress, portNum);

            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);


            clientForm.txt_View.Text += "서버에 접속합니다.\r\n";
            server.Connect(ipep);
            clientForm.txt_View.Text += "서버에 접속 성공!\r\n";

           
           
        }

        public void clientSend()
        {
            byte[] data = new byte[1024];

            data = Encoding.Default.GetBytes(clientForm.txt_Send.Text);
            server.Send(data);

            clientForm.txt_View.Text += "데이터를 전송함!\r\n";

            server.Close();

        }
    }
}
