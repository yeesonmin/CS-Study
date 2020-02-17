using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    ////이벤트를 위한 델리게이트 정의
    //public delegate void Delegates(int a);
    //class EventManager
    //{
    //    //이벤트 선언
    //    public event Delegates eventC;
    //    public event Delegates OddC;

    //    //이벤트 발생
    //    public void NumberCheck(int n)
    //    {
    //        if (n % 2 == 0)
    //        {
    //            eventC(n);
    //        }
    //        else
    //        {
    //            OddC(n);
    //        }

    //    }
    //}
    //class Event
    //{
    //    //이벤트 처리
    //    static void EvenNum(int n)
    //    {
    //        Console.WriteLine("{0} 는 짝수", n);
    //    }
    //    static void OddNum(int n)
    //    {
    //        Console.WriteLine("{0} 는 홀수", n);
    //    }
    //    public static void Main()
    //    {

    //        EventManager eventmager = new EventManager();

    //        //이벤트 등록
    //        eventmager.eventC += new Delegates(EvenNum);
    //        eventmager.OddC += new Delegates(OddNum);

    //        for (int i = 1; i < 10; i++)
    //        {
    //            eventmager.NumberCheck(i);
    //        }

    //    }
    //}


    /// <summary>
    /// 복습
    /// </summary>    
    /// 

    //public delegate void Delegates(int n);
    //class CheckNum
    //{
    //    public event Delegates evenNum;
    //    public event Delegates oddNum;
    //    public void Check(int n)
    //    {
    //        if(n/2 == 0)
    //        {

    //            evenNum(n);
    //        }
    //        else
    //        {

    //            oddNum(n);
    //        }


    //    }
    //}

    //class Event
    //{

    //    static void EvenNum(int n)
    //    {
    //        Console.WriteLine("{0}은 짝수", n);
    //    }

    //    static void OddNum(int n)
    //    {
    //        Console.WriteLine("{0}은 홀수", n);
    //    }
    //    public static void Main()
    //    {
    //        CheckNum ch = new CheckNum();
    //        ch.evenNum += new Delegates(EvenNum);
    //        ch.oddNum += new Delegates(OddNum);

    //        int n;
    //        n = int.Parse(Console.ReadLine());
    //        ch.Check(n);


    //    }
    //}






    ///
    ///
    /// 계산기
    /// 
    /// 

    public delegate void Delegates(int a, int b);
    class CheckSign
    {
        public event Delegates ADD;
        public event Delegates SUB;
        public event Delegates MUL;
        public event Delegates DIV;
        public void Signs(int a, int b, string s)
        {
            switch (s)
            {
                case "+":
                    {
                        ADD(a, b);
                        break;
                    }
                case "-":
                    {
                        SUB(a, b);
                        break;
                    }
                case "*":
                    {
                        MUL(a, b);
                        break;
                    }
                case "/":
                    {
                        DIV(a, b);
                        break;
                    }

            }
        }
         
    }

    class Event
    {
        static void ADD(int a, int b)
        {
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
        }
        static void SUB(int a, int b)
        {
            Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
        }
        static void MUL(int a, int b)
        {
            Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
        }
        static void DIV(int a, int b)
        {
            Console.WriteLine("{0} / {1} = {2}", a, b, (float)a / b);
        }
       
        public static void Main()
        {
            CheckSign sign = new CheckSign();
            sign.ADD += new Delegates(ADD);
            sign.SUB += new Delegates(SUB);
            sign.MUL += new Delegates(MUL);
            sign.DIV += new Delegates(DIV);

            int a, b;
            string s;

            a = int.Parse(Console.ReadLine());
            s = Console.ReadLine();
            b = int.Parse(Console.ReadLine());
         

            sign.Signs(a, b, s);

        }
    }


}
