using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class 델리게이트
    {
        public delegate int cal(int a, int b);

        public static int ADD(int a, int b)
        {
            return a + b;
        }
        public static int SUB(int a, int b)
        {
            return a - b;
        }
        public static int MUL(int a, int b)
        {
            return a * b;
        }
        public static int DIV(int a, int b)
        {
            return a / b;
        }


        static void Main()
        {
            int a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            cal add = new cal(ADD);
            cal sum = new cal(SUB);
            cal mul = new cal(MUL);
            cal div = new cal(DIV);

            Console.WriteLine(add(a, b));
            Console.WriteLine(sum(a, b));
            Console.WriteLine(mul(a, b));
            Console.WriteLine(div(a, b));
        }
    }
}
