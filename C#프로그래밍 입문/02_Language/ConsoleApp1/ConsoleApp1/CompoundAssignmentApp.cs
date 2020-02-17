using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CompoundAssignmentApp
    {
        static void Main(string[] args)
        {
            int x, y = 2;
            x = 10;
            x += y;
            Console.WriteLine(x);
            x = 10;
            x -= y;
            Console.WriteLine(x);
            x = 10;
            x *= y;
            Console.WriteLine(x);
            x = 10;
            x /= y;
            Console.WriteLine(x);
            x = 10;
            x %= y;
            Console.WriteLine(x);
            x = 10;
            x &= y;
            Console.WriteLine(x);
            x = 10;
            x |= y;
            Console.WriteLine(x);
            x = 10;
            x ^= y;
            Console.WriteLine(x);
            x = 10;
            x <<= y;
            Console.WriteLine(x);
            x = 10;
            x >>= y;
            Console.WriteLine(x);
        }
    }
}
