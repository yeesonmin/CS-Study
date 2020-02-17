using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class JumpApp
    {
        static int sum(int in1 ,int s)
        {
            
            return in1 + s;
        }
        static void Main(string[] args)
        {
            int a ,s = 0;
            a = Int32.Parse(Console.ReadLine());
            for(int i = 1; i<=a; i++)
            {
                s = sum(i, s);
            }
            Console.WriteLine(s);
        }
    }
}
