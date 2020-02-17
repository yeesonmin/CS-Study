using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ConditionalOperatorApp
    {
        static void Main(string[] args)
        {
            int a = 5, b = 10, c = 2;
            int m;
            m = (a > b) ? a : b;
            Console.WriteLine("a, b 중 무엇이 크냐? " + m);
            m = (a > b) ? ((b>c) ? c:b) : ((a > c) ? c : a);
            Console.WriteLine("a, b, c 중 무엇이 가장 작냐? " + m);

        }
    }
}
