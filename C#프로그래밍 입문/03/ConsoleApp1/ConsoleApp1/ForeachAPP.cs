using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ForeachAPP
    {
        static void Main(string[] args)
        {
            string[] color = { "red", "blue", "green" };
            foreach(string s in color)
            {
                Console.WriteLine(s);
            }
        }
    }
}
