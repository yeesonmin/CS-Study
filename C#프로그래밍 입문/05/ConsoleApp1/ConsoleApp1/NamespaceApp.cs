using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shape;

namespace ConsoleApp1
{
    class NamespaceApp
    {
        static void Main(string[] args)
        {
            Namespace r = new Namespace();
            r.w = 10;
            r.h = 5;
            Console.WriteLine("rect : {0}", r);
        }
    }
}
