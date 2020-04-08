using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Console서버
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket server = null;//서버 소켓
            Socket client = null;//클라이언트 소켓
            byte[] data = new byte[1024];//데이터 배열

            IPEndPoint ipep = new IPEndPoint(IPAddress.Any, 3317);//포트번호 설정
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);//TCP서버

            server.Bind(ipep);//서버소켓 포트값 설정;
            server.Listen(10);//최대 접속 가능 클라이언트 수

            Console.WriteLine("서버를 시작합니다.\n클라이언트의 접속을 대기합니다.");

            client = server.Accept();//클라이언트 접속 대기

            Console.WriteLine("클라이언트 접속했습니다.");

            //데이터 수신
            client.Receive(data);
            Console.WriteLine("클라이언트로부터 데이터를 수신했습니다.\n메세지 : " + Encoding.Default.GetString(data));


            client.Close();
            server.Close();
        }
    }
}
