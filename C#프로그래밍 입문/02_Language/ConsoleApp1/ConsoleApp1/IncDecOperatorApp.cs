using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class IncDecOperatorApp
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0;
            int x = 2, y = 5;
            Console.WriteLine("a = " + a + "x = " + x);
            Console.WriteLine("b = " + b + "y = " + y);
            a = x++;// a = 2, x = 3;
            b = ++y;// b = 6, y = 6;
            Console.WriteLine("a = " + a + "x = " + x);
            Console.WriteLine("b = " + b + "y = " + y);

        }
    }
}
