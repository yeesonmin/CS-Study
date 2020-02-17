using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Static
    {
        int a;
        static int b;
        public static void Main()
        {
            Static n = new Static();
            n.a = 10;
            Static.b = 20;
            Console.WriteLine("a = {0}, b = {1}", n.a, Static.b);
        }
    }
}
