using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class StaticConstructor
    {
        static int staticok = 100;
        static int staticno;
        StaticConstructor()
        {
            staticno = staticok + 100;
        }
        public static void PrintStatic()
        {
            Console.WriteLine("1 : {0}, 2 : {1}", staticok, staticno);
        }
    }
    class StaticConstructorApp
    {
      
        public static void Main()
        {
            StaticConstructor.PrintStatic();
        }
       
    }
}
