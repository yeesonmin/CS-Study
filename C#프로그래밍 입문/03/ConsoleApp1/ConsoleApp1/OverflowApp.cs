using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class OverflowApp
    {
        static void Main(string[] args)
        {
            int i, max = int.MaxValue;
            try
            {
                Console.WriteLine("start");
                i = max + 1;
                Console.WriteLine("default");
              
                unchecked
                {
                    i = max + 1;
                }
                Console.WriteLine("unchecked");
                checked
                {
                    i = max + 1;
                }
                Console.WriteLine("checked");

            }catch(OverflowException e)
            {
                Console.WriteLine("overflowexcepton");
            }
           

        }
    }
}
