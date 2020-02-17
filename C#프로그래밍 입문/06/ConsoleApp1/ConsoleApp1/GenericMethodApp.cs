using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class GenericMethodApp
    {

        static void Swap<T>(ref T x, ref T y)
        {
            T temp;
            temp = x;
            x = y;
            y = temp;
        }
        static void Main(string[] args)
        {
            int a = 1, b = 2;
            double c = 1.5, d = 2.2;
            Console.WriteLine("a = {0}, b = {1},\nc = {2}, d = {3}", a, b, c, d);
            Swap<int>(ref a, ref b);
            Swap<double>(ref c, ref d);
            Console.WriteLine("a = {0}, b = {1},\nc = {2}, d = {3}", a, b, c, d);


        }
    }
}
