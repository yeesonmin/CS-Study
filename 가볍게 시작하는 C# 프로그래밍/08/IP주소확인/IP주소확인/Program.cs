using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace IP주소확인
{
    class Program
    {
        static void Main(string[] args)
        {
            string hostName = Dns.GetHostName();
            IPHostEntry host = Dns.GetHostEntry(hostName);

            for(int i = 0; i<host.AddressList.Length;i++)
            {
                string myIpAddress = host.AddressList[i].ToString();
                Console.WriteLine(myIpAddress);
            }
        }
    }
}
