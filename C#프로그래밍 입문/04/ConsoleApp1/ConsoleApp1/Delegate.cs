using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // //델리게이트는 메소드를 대신해서 호출하는 역할
    //    //델리게이트 타입도 그 메소드와 동일한 매개변수, 반환타입으로 선언
    //delegate int Dn(int i, int j);
    //class Delegate
    //{

    //    public static int Plus (int i, int j)
    //    {
    //        return i + j;
    //    }
    //    public static int Minus(int i, int j)
    //    {
    //        return i - j;
    //    }
    //    public static void Calback(int i, int j, Dn c)
    //    {
    //        Console.WriteLine(c(i, j));
    //    }
    //    public static void Main()
    //    {
    //        //int sum, sub;
    //        //Dn calculate; //델리게이트 객체 생성

    //        //calculate = new Dn(Plus);
    //        //sum = calculate(1, 2);

    //        //calculate = new Dn(Minus);
    //        //sub = calculate(2, 1);

    //        //Console.WriteLine("sum = {0}, sub = {1}", sum, sub);

    //        Dn sum = Plus;
    //        Dn sub = Minus;
    //        Calback(1, 2, sum);
    //        Calback(2, 1, sub);

    //    }
    //}

    //사칙연산프로그램

    //delegate void Calculate  (int i, int j);

    //class Delegate
    //{
    //    public static void ADD(int i, int j)
    //    {
    //        Console.WriteLine("sum = {0}", i +j);
    //    }

    //    public static void SUB(int i, int j)
    //    {
    //        Console.WriteLine("sub = {0}", i - j);
    //    }

    //    public static void MULL(int i, int j)
    //    {
    //        Console.WriteLine("mul = {0}", i * j);
    //    }
    //    public static void DIV(int i, int j)
    //    {
    //        Console.WriteLine("div = {0}", (float)i / j);

    //    }

    //    public static void CallBack(int i, int j, Calculate c)
    //    {

    //    }
    //    public static void Main()
    //    {
    //        int a, b;


    //        a = Int32.Parse(Console.ReadLine());
    //        b = Int32.Parse(Console.ReadLine());

    //        Calculate calculate = ADD;
    //        calculate += SUB;
    //        calculate += MULL;
    //        calculate += DIV;

    //        calculate(a, b);




    //    }
    //}



    /// <summary>
    /// 복습
    /// </summary>
    /// 
    delegate void Calculate(int a, int b);
    class Delegate
    {
        public static void ADD (int a, int b)
        {
            Console.WriteLine("sum = {0}", a+b);
        }
        public static void SUB(int a, int b)
        {
            Console.WriteLine("sub = {0}", a - b);
        }
        public static void MUL(int a, int b)
        {
            Console.WriteLine("mul = {0}", a*b);
        }
        public static void DIV(int a, int b)
        {
            Console.WriteLine("div = {0}", (float)a/b);

        }


        public static void Main()
        {

            int a, b;
           

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            Calculate c = ADD;
            c += SUB;
            c += MUL;
            c += DIV;

            c(a, b);



            Console.WriteLine();

            c -= DIV;
            c(a, b);


        }
    }

}
