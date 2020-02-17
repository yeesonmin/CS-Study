using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MyClass {
        [Obsolete("Old는 폐기. New를 이용")]
        public void Old()
        {
            Console.WriteLine("I'm old");

        }
        public void New()
        {
            Console.WriteLine("I'm New");
        }
    }

    class BsaicAttribute
    {
        static void Main(string[] args)
        {
            MyClass me = new MyClass();
            me.Old();
            me.New();
        }
    }
}
