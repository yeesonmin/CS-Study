using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading; //스레드 네임스페이스

namespace ConsoleApp1
{
    /// <summary>
    /// 스레드 기초 
    /// </summary>
    //
    //
    //class ThreadApp
    //{
    //    static void Time()//스레드 메서드
    //    {
    //        int a = 0;
    //        while(true)
    //        {
    //            Console.WriteLine(a);
    //            a++;
    //            Thread.Sleep(1000);
    //        }
    //    }
    //    static void Main(string[] args)
    //    {
    //        ThreadStart ts = new ThreadStart(Time);//델리게이트 연결(메서드와 연결)
    //        Thread t = new Thread(ts);//객체생성
    //        t.Start();//스레드 실행

    //    }
    //}


    /////
    /////  스레드 심화
    /////
    // class ThreadApp
    // {
    //     static public void Time(object i)
    //     {

    //         Thread name = Thread.CurrentThread;
    //         int a = 0;
    //         if((int)i == 0)
    //         {
    //             while (true)
    //             {

    //                 Console.WriteLine("{0} : {1}", name.Name, a);
    //                 a++;
    //                 Thread.Sleep(1000);
    //             }
    //         }
    //         else
    //         {
    //             while (true)
    //             {

    //                 Console.WriteLine("{0} : {1}", name.Name, -a);
    //                 a++;
    //                 Thread.Sleep(1000);
    //             }
    //         }



    //     }
    //     //static public void Time2()
    //     //{

    //     //    Thread name = Thread.CurrentThread;
    //     //    int a = 0;
    //     //    while (true)
    //     //    {
    //     //        Console.WriteLine("{0} : {1}", name.Name, -a);
    //     //        a++;
    //     //        Thread.Sleep(1000);
    //     //    }


    //     //}
    //     static void Main(string[] args)
    //     {
    //         ParameterizedThreadStart ts = new ParameterizedThreadStart(Time);//파라미터 값 전달
    //        // ThreadStart ts = new ThreadStart(Time);  //파라미터 값 전달 못함.
    //        //ThreadStart ts2 = new ThreadStart(Time2);
    //         Thread t1 = new Thread(ts);
    //         Thread t2 = new Thread(ts);
    //         t1.Name = "t1";
    //         t2.Name = "t2";
    //         t1.Start(0);
    //         t2.Start(1);


    //     }
    // }
    //

    ///
    /// 스레드 심화2(우선순위 적용)
    /// 

    //class ThreadApp
    //{
    //    static public void Time(object i)
    //    {

    //        Thread name = Thread.CurrentThread;
    //        int a = 0;
    //        if ((int)i == 0)
    //        {
    //            while (true)
    //            {

    //                Console.WriteLine("{0} : {1}", name.Name, a);
    //                a++;
    //                Thread.Sleep(1000);
    //            }
    //        }
    //        else
    //        {
    //            while (true)
    //            {

    //                Console.WriteLine("{0} : {1}", name.Name, -a);
    //                a++;
    //                Thread.Sleep(10);
    //            }
    //        }



    //    }
    //    static void Main(string[] args)
    //    {
    //        ParameterizedThreadStart ts = new ParameterizedThreadStart(Time);
    //        //파라미터 값 전달
    //        // ThreadStart ts = new ThreadStart(Time);  //파라미터 값 전달 못함.
    //        //ThreadStart ts2 = new ThreadStart(Time2);
    //        Thread t1 = new Thread(ts);
    //        Thread t2 = new Thread(ts);
    //        t1.Name = "t1";
    //        t2.Name = "t2";
    //        t1.Start(0);
    //        t1.Priority = ThreadPriority.Highest; //우선순위 최상 //실행 후 sleep에 의해 잠시 대기
    //        t2.Start(1); //t1이 대기 할 때 실행

    //    }
    //}




    ///
    /// 스레드 동기화(LOCK,MONITOR)
    /// 
    ///

    class ThreadApp
    {
       public void TCount(object n)
        {
            
           
                Thread t = Thread.CurrentThread;

            //lock(this)
            //{

            //    if ((int)n == 0)
            //    {
            //        for (int i = 0; i < 100; i++)
            //        {
            //            Console.WriteLine("{0} : {1}", t.Name, i);
            //        }
            //        Thread.Sleep(100);
            //    }
            //    else
            //    {
            //        for (int i = 0; i < 100; i++)
            //        {
            //            Console.WriteLine("{0} : {1}", t.Name, -i);
            //        }
            //        Thread.Sleep(100);
            //    }
            //}

            Monitor.Enter(this);
            if ((int)n == 0)
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine("{0} : {1}", t.Name, i);
                }
                Thread.Sleep(100);
            }
            else
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine("{0} : {1}", t.Name, -i);
                }
                Thread.Sleep(100);
            }
            Monitor.Exit(this);


        }
        static void Main(string[] args)
        {
            
            ThreadApp th = new ThreadApp();
            ParameterizedThreadStart ts = new ParameterizedThreadStart(th.TCount);
            Thread t1 = new Thread(ts);
            Thread t2 = new Thread(ts);

            t1.Name = "일반";
            t2.Name = "반대";

           
            t1.Start(0);
            t2.Start(1);

        }
    }


}
