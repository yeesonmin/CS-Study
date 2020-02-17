using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class BaseClass
    {

        public int a = 0;
    }
    class DerivedClass : BaseClass
    {
        new public int a = 6;
        public void OutPut()
        {
            Console.WriteLine("{0} {1}", base.a, a);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass d = new DerivedClass();
            d.OutPut();
            
        }
    }
}
