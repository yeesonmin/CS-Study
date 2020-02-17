using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Color2
    {
        private string[] color = new string[5];
        public string this[int index]
        {
            get { return color[index]; }
            set { color[index] = value; }
        }
    }

    class IndexApp
    {
        public static void Main()
        {
            Color2 c = new Color2();
            c[0] = "WHITE";
            c[1] = "RED";
            c[2] = "GREEN";
            c[3] = "BLUE";
            c[4] = "BLACK";
            for(int i =0; i<5; i++)
            {
                Console.WriteLine("color = {0}", c[i]);
            }
        }

    }
}
