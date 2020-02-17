using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class nestedifApp
    {
        static void Main(string[] args)
        {
            //1~7입력을 받아 요일 출력 1:일요일 ~7:토요일
            int n;

            n = int.Parse(Console.ReadLine());

            //if (n==1)
            //{
            //    Console.WriteLine("일요일");
            //}
            //else if(n == 2)
            //{
            //    Console.WriteLine("월요일");
            //}
            //else if (n == 3)
            //{
            //    Console.WriteLine("화요일");
            //}
            //else if (n == 4)
            //{
            //    Console.WriteLine("수요일");
            //}
            //else if (n == 5)
            //{
            //    Console.WriteLine("목요일");
            //}
            //else if (n == 6)
            //{
            //    Console.WriteLine("금요일");
            //}
            //else if (n == 7)
            //{
            //    Console.WriteLine("토요일");
            //}
            //else
            //{
            //    Console.WriteLine("뭐야");
            //}

            switch(n)
            {
                case 1: Console.WriteLine("일요일"); break;
                case 2: Console.WriteLine("월요일"); break;
                case 3: Console.WriteLine("화요일"); break;
                case 4: Console.WriteLine("수요일"); break;
                case 5: Console.WriteLine("목요일"); break;
                case 6: Console.WriteLine("금요일"); break;
                case 7: Console.WriteLine("토요일"); break;
                default: Console.WriteLine("뭐야"); break;

            }
        }
    }
}
