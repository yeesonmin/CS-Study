using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CastOperatorApp
    {
        static void Main(string[] args)
        {
            int i = 123;
            float j = 1.23f;
            //float j = 1.23;는 오류 발생;
            Console.WriteLine((float)i/2);
            Console.WriteLine(i / 2);
            Console.WriteLine((int)j);
        }
    }
}
