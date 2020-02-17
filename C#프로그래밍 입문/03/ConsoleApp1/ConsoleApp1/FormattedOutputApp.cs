using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class FormattedOutputApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1) {0,-5},{1,5},{2,5}", 1.2, 1.2, 123.45);
            double d = Math.PI;
            Console.WriteLine("2) {0,10}", d);
            Console.WriteLine("3) {0:c}", d);
            Console.WriteLine("4) {0:e}", d);
            Console.WriteLine("5) {0:f}", d);
            Console.WriteLine("6) {0:g}", d);
            Console.WriteLine("7) {0:p}", d);
            Console.WriteLine("8) {0:r}", d);
            Console.WriteLine("9) {0,20:x}",255);
        }
    }
}
