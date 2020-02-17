using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class StringApp
    {
        static void Main(string[] args)
        {
            StringApp obj = new StringApp();
            string str = "Class name is ";
            Console.WriteLine(str + obj.ToString());
            StringBuilder sb = new StringBuilder();
            sb.Append(str);
            sb.Append(obj.ToString());
            Console.WriteLine(sb);
        }
        
    }
}
