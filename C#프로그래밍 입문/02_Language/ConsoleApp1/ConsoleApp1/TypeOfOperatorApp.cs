using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Apple {
        public int nSeeds = 0;
        public void Ripen() { }
    }

    class TypeOfOperatorApp
    {
        static void Main(string[] args)
        {
            Type t = typeof(Apple);
            string className = t.ToString();
            MemberInfo[] allMembers = t.GetMembers();
            Console.WriteLine("All " + className + "Members : ");
            foreach(MemberInfo member in allMembers)
            {
                Console.WriteLine(member.ToString());
            }
        }
    }
}
