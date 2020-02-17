using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CallbyValue {
        public static void Swap(int x, int y)
        {
            Console.WriteLine("Value) 전 x = {0}, y = {1}", x, y);
            int temp;
            temp = x;
            x = y;
            y = temp;
            Console.WriteLine("Value) 후 x = {0}, y = {1}", x, y);
        }
        
        
    }
    public class CallbyReference
    {
        public static void Swap(ref int x, ref int y)
        {
            Console.WriteLine("Reference) 전 x = {0}, y = {1}", x, y);
            int temp;
            temp = x;
            x = y;
            y = temp;
            Console.WriteLine("Reference) 후 x = {0}, y = {1}", x, y);
        }
    }

    class In
    {
        public int i;
    }
    class CallbyObject
    {
       public static void Swap(In x, In y)
        {
            Console.WriteLine("CallbyObject) 전 x = {0}, y = {1}", x.i, y.i);
            int temp = x.i;
            x.i = y.i;
            y.i = temp;
            Console.WriteLine("CallbyObject) 후 x = {0}, y = {1}", x.i, y.i);

        }
    }
    class CallbyValue_And_CallByReference
    {
        public static void Main()
        {
            int x = 1, y = 2;
            CallbyValue.Swap(x, y);
            Console.WriteLine("Value 함수 이후)  x = {0}, y = {1}", x, y);
            CallbyReference.Swap(ref x, ref y);
            Console.WriteLine("Reference 함수 이후)  x = {0}, y = {1}", x, y);

            In inx = new In();
            inx.i = 1;
            In iny = new In();
            iny.i = 2;
            CallbyObject.Swap(inx, iny);
            Console.WriteLine("CallbyObject 함수 이후)  x = {0}, y = {1}", inx.i, iny.i);
        }
    }
}
