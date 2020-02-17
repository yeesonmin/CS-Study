#define CSHARP
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace ConsoleApp1
{
    class ConditionalAttrApp
    {
        [Conditional("CSHARP")]
        public static void CsharpMethod()
        {
            Console.WriteLine("In the Csharp Method...");

        }

        [Conditional("JAVA")]
        public static void JavaMethod()
        {
            Console.WriteLine("In the Java");
        }

        static void Main(string[] args)
        {
            ConditionalAttrApp.CsharpMethod();
            ConditionalAttrApp.JavaMethod();
        }

    }
}
