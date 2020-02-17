using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class A
    {
        public void Output()
        {
            Console.WriteLine("A");
        }

    }
    class B : A
    {
        new public void Output()
        {
            Console.WriteLine("B overriding");
        }
        public void Output(int i)
        {
            Console.WriteLine("B overodding");
        }
    }


    class OverridingAndOverloading
    {
        static void Main(string[] args)
        {
            B bclass = new B();
            bclass.Output();
            bclass.Output(1);
        }
    }
}
