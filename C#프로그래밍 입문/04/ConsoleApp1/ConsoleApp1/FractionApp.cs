using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Fraction
    {
        int chd;
        int pnt; //멤버필드
        public Fraction(int num, int mom)//생성장
        {
            chd = num;
            pnt = mom;
        }

        public void PrintFraction() //메서드
        {
            Console.WriteLine(chd + " / " + pnt);
        }
    }
    class FractionApp
    {
        public static void Main()
        {
            Fraction f = new Fraction(1, 2);
            f.PrintFraction();
            
        }

       
    }
}
