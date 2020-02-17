using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Fruit
    {
        protected int price;
        public int GetCost()
        {
            return price;
        }
    }

    class Apple : Fruit
    {
        public Apple()
        {
            base.price = 100;
        }
    }

    class Banana : Fruit
    {
        public Banana()
        {
            base.price = 200;
        }
    }

    class Customer
    {
        int money;

        public Customer()
        {
            money = 10000;
        }

        public int Buy(Fruit fruit)
        {
            money -= fruit.GetCost();
            return money;
        }
    }

    class 다형성
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Apple apple = new Apple();
            Banana banana = new Banana();

            Console.WriteLine("사과 구매 후 남은 금액 : " + customer.Buy(apple));
            Console.WriteLine("바나나 구매 후 남은 금액 : " + customer.Buy(banana));
        }
    }
}
