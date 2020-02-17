using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SimpleGeneric<T> {
        private T[] values;
        private int index;
        public SimpleGeneric(int len)
        {
            values = new T[len];
            index = 0;

        }

        public void ADD(params T[] args)
        {
            foreach (T e in args)
            {
                values[index++] = e;
            }
        }

        public void Print()
        {
            foreach (T e in values)
            {
                Console.Write(e + " ");

            }
            Console.WriteLine();

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SimpleGeneric<int> gInteger = new SimpleGeneric<int>(10);
            SimpleGeneric<double> gDouble = new SimpleGeneric<double>(10);

            gInteger.ADD(1, 2);
            gInteger.ADD(1, 2, 3, 4, 5, 6, 7, 8);
            gInteger.Print();

            gDouble.ADD(10.1, 2.2, 3.3);
            gDouble.Print();
        }
    }
}
