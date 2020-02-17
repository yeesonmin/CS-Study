using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class GenericType<T> where T : SystemException {
        private T value;
        public GenericType(T v)
        {
            value = v;
        }

        override public String ToString()
        {
            return "type is " + value.GetType();
        }
    }

   

    class BoundedGenericApp
    {
        static void Main(string[] args)
        {
            GenericType<NullReferenceException> gNullEx = new GenericType<NullReferenceException>(new NullReferenceException());
            GenericType<IndexOutOfRangeException> gIndexEx = new GenericType<IndexOutOfRangeException>(new IndexOutOfRangeException());
            Console.WriteLine(gNullEx.ToString());
            Console.WriteLine(gIndexEx.ToString());


        }
    }
}
