using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Bclass
    {
        virtual public void A()
        {
            Console.WriteLine("A");
        }
        virtual public void B()
        {
            Console.WriteLine("B");
        }
        virtual public void C()
        {
            Console.WriteLine("C");
        }
    }
    class Dclass : Bclass
    {
        new public void A()
        {
            Console.WriteLine("New A");
        }
        public override void B()
        {
            Console.WriteLine("Override B");
        }
        public void C()
        {
            Console.WriteLine("D C");
        }
    }
    class Virtual
    {
        static void Main(string[] args)
        {
            Bclass d = new Dclass();

            d.A();
            d.B();
            d.C();

        }
    }
}
