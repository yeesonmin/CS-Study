using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ParameterArrayApp
    {
        static void ParameterArray(params object[] obj)
        {
            for( int i = 0; i < obj.Length;i++)
            {
                Console.WriteLine(obj[i]);
            }
        }
        public static void Main()
        {
            ParameterArray(123, "Hi", true, 'A', "!@#", 10000000000000000000);
        }
    }
}
