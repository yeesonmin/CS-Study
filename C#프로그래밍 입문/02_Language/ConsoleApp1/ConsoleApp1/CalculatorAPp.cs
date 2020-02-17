using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CalculatorAPp
    {
        static void Main(string[] args)
        {
            //두 정수 입력 및 부호 입력 후 계산
            int a, b;
            char c;
            bool chk = true;

            while(chk)
            {
                Console.WriteLine("두 정수를 입력하시오.");
                a = Int32.Parse(Console.ReadLine());
                b = Int32.Parse(Console.ReadLine());
                Console.WriteLine("부호를 입력하시오");
                c = (char)Console.Read();

                switch (c)
                {
                    case '+': Console.WriteLine(a + " + " + b + " = " + (a + b)); break;
                    case '-': Console.WriteLine(a + " - " + b + " = " + (a - b)); break;
                    case '*': Console.WriteLine(a + " * " + b + " = " + (a * b)); break;
                    case '/': Console.WriteLine(a + " / " + b + " = " + (a / b)); break;
                    case '%': Console.WriteLine(a + " % " + b + " = " + (a % b)); break;
                    default: chk = false; break;
                }
            }
            
            
        }
    }
}
