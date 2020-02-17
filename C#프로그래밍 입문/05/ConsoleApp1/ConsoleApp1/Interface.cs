using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface Mycar
    {
        void run();
    }

    public interface IFly
    {
        void fly();
    }

    public class MyDream : Mycar,IFly
    {
        public void run()
        {

        }

        public void fly()
        {

        }
    }

    class Interface
    {
        

        

        static void Main(string[] args)
        {
           
        }
    }
}
