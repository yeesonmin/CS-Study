using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Color {
        public const int FULL = 0xFF;
        public const int EMPTY = 0x00;
        private byte red, green, blue;
        public Color(byte r, byte g, byte b)
        {
            red = r;
            green = g;
            blue = b;
        }

        public static readonly Color Red = new Color(FULL, EMPTY, EMPTY);
        public static readonly Color Green = new Color(EMPTY, FULL, EMPTY);
        public static readonly Color Blue = new Color(EMPTY, EMPTY, FULL);
        

        public static void PrintColor(Color C)
        {
            Console.WriteLine("red = {0}, green = {1}, blue = {2}", C.red, C.green, C.blue);
        }

        public static void StaticPrint()
        {
            Console.WriteLine("스태틱 .");
        }


    }
     class Nomal {
        public void Print()
        {
            Console.WriteLine("스태틱 아니다.");
        }
    }

        


    class ConstAndReadOnly
    {
        public static void Main()
        {
            Color.PrintColor(Color.Red);
            Color.PrintColor(Color.Blue);
            Color.PrintColor(Color.Green);
            Nomal a = new Nomal();
            a.Print();
            Color.StaticPrint();
        }

       
        
        
        
    }
}
