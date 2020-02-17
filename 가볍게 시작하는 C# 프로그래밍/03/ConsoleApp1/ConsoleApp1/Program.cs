using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace ConsoleApp1
{
    class Program
    {
        static Thread A = new Thread(Acount);
        static Thread B = new Thread(Bcount);
        static void Acount()
        {
            for(int i = 0; i<=100; i++)
            {
                Console.WriteLine("A : " + i);
                if(i ==0)
                    A.Suspend();
            }
        }
        static void Bcount()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine("B : " + i);
                
            }
            A.Resume();
        }
        static void Main(string[] args)
        {
           

            A.Start();
           
            B.Start();
            
        }
    }
}
