using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Character
    {
        public void Attack()
        {
            Console.WriteLine("공격");
        }
        public void MOVE()
        {
            Console.WriteLine("걷기");
        }
        public void RUN()
        {
            Console.WriteLine("달리기");
        }
        public void Defence()
        {
            Console.WriteLine("방어");
        }
    }
    class Warrior : Character
    {
        public void Dash()
        {
            Console.WriteLine("돌격");
        }
    }
    class Magician : Character
    {
        public void Magic()
        {
            Console.WriteLine("마법");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Warrior p1 = new Warrior();
            Magician p2 = new Magician();

            p1.Attack();
            p1.Dash();
            p1.Defence();
            p1.MOVE();
            p1.RUN();

            p2.Attack();
            p2.Defence();
            p2.MOVE();
            p2.RUN();
            p2.Magic();

        }
    }
}
