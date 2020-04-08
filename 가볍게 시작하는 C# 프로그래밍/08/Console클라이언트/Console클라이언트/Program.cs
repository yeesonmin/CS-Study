using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Console클라이언트
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] data = new byte[1024];

            //접속할 서버 IP 주소
            IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
            IPEndPoint ipep = new IPEndPoint(ipAddress, 3317);

            //서버소켓 생성
            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            Console.WriteLine("서버에 접속합니다.");

            server.Connect(ipep);

            Console.WriteLine("서버에 접속했습니다.");

            data = Encoding.Default.GetBytes("클라에서 보내요.");

            server.Send(data);

            Console.WriteLine("서버에 데이터를 보냈어요.");

            server.Close();
        }
    }
}
