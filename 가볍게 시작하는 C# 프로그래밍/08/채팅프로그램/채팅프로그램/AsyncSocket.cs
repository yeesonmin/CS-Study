using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;


namespace 채팅프로그램
{
    class AsyncSocket
    {
        //송수신 버퍼 크기
        private const int BUFFER_SIZE = 1024;
        private const int PACKET_HEADER_SIZE = 1024;
        //기본포트번호
        public const int DEFAULT_PORT_NUM = 3317;

        private Form1 mChatWnd = null;

        private string mMyIPAddress = "";
        private string mCorrespondentIPAddress = "";
        private string mServerIPAddress = "";
        private string mClientIPAddress = "";

        private int mServerPortNum = 0;

        private Socket mServerSocket = null;
        private Socket mClientSocket = null;

        private Thread mServerThread = null;
        private Thread mReceiverThread = null;


        public AsyncSocket()
        {

        }

        public AsyncSocket(Form1 chat)
        {
            mChatWnd = chat;
            Init();
        }

        private void Init()
        {
            SetMyIPAddress();

        }

        public void Connect(string address, int portNum)
        {
            mServerIPAddress = address;
            mServerPortNum = portNum;

            IPEndPoint serverIpep = new IPEndPoint(IPAddress.Parse(mServerIPAddress), mServerPortNum);

            mClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            mClientSocket.Connect(serverIpep);
            mChatWnd.NotifyMessage("서버 접속");

            mCorrespondentIPAddress = mServerIPAddress;
            mReceiverThread = new Thread(new ThreadStart(Receive));
            mReceiverThread.Start();
            mChatWnd.NotifyMessage("서버로 부터 메시지 수신시작");




        }

        public void Disconnect()
        {
            if (mClientSocket == null)
            {
                mChatWnd.NotifyMessage("에러\r\n클라이언트 소켓 객체가 null입니다.");
                return;

            }

            if (mClientSocket.Connected == false)
            {
                mChatWnd.NotifyMessage("에러\r\n클라이언트 소켓 접속이 필요합니다.");

            }
            mClientSocket.Close();

            if (mReceiverThread == null)
            {
                mChatWnd.NotifyMessage("에러\r\n클라이언트 스레드 객체가 null입니다.");
                return;
            }

            if (mReceiverThread.IsAlive == false)
            {
                mChatWnd.NotifyMessage("에러\r\n클라이언트 스레드 객체가 동작하지 않습니다.");
                return;
            }
            mReceiverThread.Abort();
        }

        ///
        /// 서버를 시작
        ///

        public void StartServer(int portNum)
        {
            mServerIPAddress = mMyIPAddress;
            mServerPortNum = portNum;

            mServerThread = new Thread(new ThreadStart(WaitConnection));
            mServerThread.Start();
        }

        public void StopServer()
        {
            if (mClientSocket != null)
            {
                if (mClientSocket.Connected == true)
                {
                    mClientSocket.Close();

                }
            }

            if (mServerSocket != null)
            {
                if (mServerSocket.Connected == true)
                {
                    mServerSocket.Close();

                }
            }
            if (mReceiverThread == null)
            {
                mChatWnd.NotifyMessage("에러\r\n클라이언트 스레드 객체가 null입니다.");
                return;
            }
            if (mReceiverThread.IsAlive == false)
            {
                mChatWnd.NotifyMessage("에러\r\n클라이언트 스레드 객체가 동작하지 않습니다.");
                return;
            }
            mReceiverThread.Abort();
        }


        private void WaitConnection()
        {
            IPEndPoint serverIpep = new IPEndPoint(IPAddress.Any, mServerPortNum);
            IPEndPoint clientIpep = null;

            mServerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            mServerSocket.Bind(serverIpep);
            mServerSocket.Listen(10);

            mChatWnd.NotifyMessage("서버가 시작되었다.\r\n클라이언트 접속을 대기합니다.");

            mClientSocket = mServerSocket.Accept();
            clientIpep = (IPEndPoint)mClientSocket.RemoteEndPoint;
            mChatWnd.NotifyMessage("IP 주소 : " + clientIpep.Address.ToString() + "의 클라이언트가 접속했습니다.");

            mCorrespondentIPAddress = clientIpep.Address.ToString();
            mReceiverThread = new Thread(new ThreadStart(Receive));
            mReceiverThread.Start();
            mChatWnd.NotifyMessage("클라이언트로부터 메시지를 수신합니다.");

        }

        private void Receive()
        {
            string message = "";
            byte[] data = null;

           // data = new byte[BUFFER_SIZE];

            while (true)
            {
                if (mClientSocket == null)
                {
                    mChatWnd.NotifyMessage("에러\r\n 소켓 객체가 null입니다.");
                    break;
                }

                if (mClientSocket.Connected == false)
                {
                    mChatWnd.NotifyMessage("에러\r\n 연결되지 않았습니다.");
                    break;
                }

                data = ReceiveData();
               
                //mClientSocket.Receive(data, SocketFlags.None);
                message = Encoding.Default.GetString(data);
                mChatWnd.ReceiveMessage(message);
            }
        }
        private byte[] ReceiveData()
        {
            byte[] headerBuffer = new byte[PACKET_HEADER_SIZE];
            byte[] dataBuffer = null;

            int totoalDataSize = 0;
            int accumulatedDataSize = 0;
            int leftDataSize = 0;
            int receivedDataSize = 0;

            receivedDataSize = mClientSocket.Receive(headerBuffer, 0, PACKET_HEADER_SIZE, SocketFlags.None);

            totoalDataSize = BitConverter.ToInt32(headerBuffer, 0);

            leftDataSize = totoalDataSize;

            dataBuffer = new byte[totoalDataSize];

            while(leftDataSize > 0)
            {
                receivedDataSize = mClientSocket.Receive(dataBuffer, accumulatedDataSize, leftDataSize, 0);

                accumulatedDataSize = accumulatedDataSize + receivedDataSize;
                leftDataSize = leftDataSize - receivedDataSize;


            }

            return dataBuffer;
        }
        public void Send(string message)
        {
            byte[] data = null;

            if (mClientSocket == null)
            {
                mChatWnd.NotifyMessage("에러\r\n 소켓 객체가 null입니다.");
                return;
            }
            if (mClientSocket.Connected == false)
            {
                mChatWnd.NotifyMessage("에러\r\n 연결되지 않았습니다.");
                return;
            }

            data = Encoding.Default.GetBytes(message);
            SendData(data);
            //mClientSocket.Send(data, 0, data.Length, SocketFlags.None);
        }

        private void SendData(byte[] dataBuffer)
        {
            byte[] headerBuffer = new byte[PACKET_HEADER_SIZE];

            int totoalDataSize = 0;
            int accumulatedDataSize = 0;
            int leftDataSize = 0;
            int sentDataSize = 0;

            totoalDataSize = dataBuffer.Length;
            leftDataSize = totoalDataSize - sentDataSize;

            headerBuffer = BitConverter.GetBytes(totoalDataSize);
            mClientSocket.Send(headerBuffer);
            

            while (leftDataSize > 0)
            {
                sentDataSize = mClientSocket.Send(dataBuffer, accumulatedDataSize, leftDataSize,  SocketFlags.None);
                
                accumulatedDataSize = accumulatedDataSize + sentDataSize;
                leftDataSize = leftDataSize - sentDataSize;


            }
        }
        private void SetMyIPAddress()
        {
            string myIPAddress = "";
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach(IPAddress ip in host.AddressList)
            {
                if(ip.AddressFamily ==AddressFamily.InterNetwork)
                {
                    myIPAddress = ip.ToString();
                    break;
                }
            }
            mMyIPAddress = myIPAddress;
        }

        public string GetMyAddress()
        {
            return mMyIPAddress;
        }

        public string GetCorrespondentIPAddress()
        {
            return mCorrespondentIPAddress;
        }
    }
}
