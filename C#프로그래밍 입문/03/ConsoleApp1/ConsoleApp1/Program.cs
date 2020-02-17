using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            string c;
            //char c;
            bool chk = true;

            while(chk)
            {
                Console.WriteLine("정수 입력");
                a = Int32.Parse(Console.ReadLine());
                b = Int32.Parse(Console.ReadLine());
            
                Console.WriteLine("부호를 입력하시오");
               
                c = Console.ReadLine();
                //c = (char)Console.Read(); 오류발생

                switch (c)
                {
                    case "+": Console.WriteLine(a + " + " + b + " = " + (a + b)); break;
                    case "-": Console.WriteLine(a + " - " + b + " = " + (a - b)); break;
                    case "*": Console.WriteLine(a + " * " + b + " = " + (a * b)); break;
                    case "/": Console.WriteLine(a + " / " + b + " = " + (a / b)); break;
                    case "%": Console.WriteLine(a + " % " + b + " = " + (a % b)); break;
                    default: chk = false; break;
                }

            }
        }
    }
}
