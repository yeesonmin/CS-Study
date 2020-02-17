using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
    class IsAsOperatorApp
    {
        static void IsOperator(object obj)
        {
            Console.WriteLine(obj + " is int : " + (obj is int));
            Console.WriteLine(obj + " is string : " + (obj is string));
        }

        static void AsOperator(object obj)
        {
            Console.WriteLine(obj + " as string == null" + (obj as string == null));
        }
        static void Main(string[] args)
        {
            IsOperator(10);
            IsOperator("abc");
            AsOperator(10);
            AsOperator("abc");
        }
    }
}
