using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ReadLineApp
    {
        static void Main(string[] args)
        {
            int time, hour, minute, second;
            time = Int32.Parse(Console.ReadLine());
            hour = time / 10000;
            minute = (time / 100) % 100;
            second = time % 100;
            Console.WriteLine(hour + " : " + minute + " : " + second);
        }
    }
}
