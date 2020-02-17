using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp1
{ 
    
    class RacingGame
    {
        static Thread[] horse = new Thread[3];
        static int pos1 = 0, pos2 = 0, pos3 = 0;
        static int sel;
        static bool gameover = false;

        static Random r1 = new Random(DateTime.Now.Millisecond);
        static Random r2= new Random(DateTime.Now.Millisecond);
        static Random r3 = new Random(DateTime.Now.Millisecond);
        static void Hores1()
        {
            while(pos1 <50)
            {
                Thread.Sleep(50);
                Console.SetCursorPosition(pos1, 5);
                Console.Write("   @1>");
                pos1 += r1.Next(0, 3);
              
            }
            GameOver(1);
        }
        static void Hores2()
        {
            while (pos2 < 50)
            {
                Thread.Sleep(50);
                Console.SetCursorPosition(pos2, 8);
                Console.Write("   @2>");
                pos2 += r2.Next(0, 3);
                
            }
            GameOver(2);
        }
        static void Hores3()
        {
            while (pos3 < 50)
            {
                Thread.Sleep(50);
                Console.SetCursorPosition(pos3, 11);
                Console.Write("   @3>");
                pos3 += r3.Next(0, 3);
               
            }
            GameOver(3);
        }
        static void GameOver(int i)
        {
            if(gameover == false)
            {
                gameover = true;
                Console.SetCursorPosition(0, 0);
                Console.WriteLine(i + "번 말이 우승했습니다.");

                Console.SetCursorPosition(0, 1);
                if (sel == i)
                {
                    Console.WriteLine("당신의 말이 우승했습니다.");

                }
                else
                {
                    Console.WriteLine("당신의 말이 패배했습니다.");
                }

                
            }
            
        }
        static void Main()
        {
            horse[0] = new Thread(Hores1);
            horse[1] = new Thread(Hores2);
            horse[2] = new Thread(Hores3);
            Console.WriteLine("말을 선택하시오(1~3)");
            sel = int.Parse(Console.ReadLine());
            Console.WriteLine("당신이 선택한 말은 " + sel + "번 말입니다.");

            horse[0].Start();
            horse[1].Start();
            horse[2].Start();
        }
    }
}
