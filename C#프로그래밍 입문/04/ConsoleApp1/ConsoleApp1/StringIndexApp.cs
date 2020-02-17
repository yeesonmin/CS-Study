using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class StringIndexer
    {
        public char this[string str, int index]
        {
            get { return str[index]; }
        }
        public string this[string str, int index, int len]
        {
            get { return str.Substring(index, len); }
        }
    }
    class StringIndexApp
    {
        public static void Main()
        {
            string str = "Hi?";
            StringIndexer s = new StringIndexer();
            for(int i = 0; i<str.Length; i++)
            {
                Console.WriteLine("Hi[{0}] = {1} ", i, s[str, i]);

            }
            Console.WriteLine("Substring of {0} is {1}", str, s[str, 1, 2]);
        }
    }
}
