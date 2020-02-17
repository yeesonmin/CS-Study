using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static int ShowMenu()
        {
            int i;
            Console.WriteLine("**************************************");
            Console.WriteLine("*           내가 만든 게임           *");
            Console.WriteLine("**************************************");
            Console.WriteLine("* 1. 가위 바위 보                    *");
            Console.WriteLine("* 2. 탱크                            *");
            Console.WriteLine("* 3. 끝내기                          *");
            Console.WriteLine("**************************************");
            Console.Write("무엇을 하겠습니까? : ");
            i = int.Parse(Console.ReadLine());
            return i;
        }
        static int SelectRockScissorPaper()
        {
            int i;
            Console.WriteLine();
            Console.WriteLine("**************************************");
            Console.WriteLine("*             1. 가위                *");
            Console.WriteLine("*             2. 바위                *");
            Console.WriteLine("*             3. 보                  *");
            Console.WriteLine("*             4. 종료                *");
            Console.WriteLine("**************************************");
            Console.Write("무엇을 내겠습니까? : ");
            i = int.Parse(Console.ReadLine());

            return i;
        }
        static int ComputerRockScissorPaper()
        {
            int i;
            Random r = new Random();
            i = r.Next(1, 4);
            return i;
        }

        static void GameRockScissorPaper()
        {
            int people = 0, computer;

            while(people != 4)
            {
                people = SelectRockScissorPaper();
                computer = ComputerRockScissorPaper();

                switch (people)
                {
                    case 1:
                        if (computer == 1)
                        {
                            Console.WriteLine();
                            Console.WriteLine("**************************************");
                            Console.WriteLine("*       당신은 가위를 냈습니다.      *");
                            Console.WriteLine("*       컴퓨터는 가위를 냈습니다.    *");
                            Console.WriteLine("*                                    *");
                            Console.WriteLine("*              게임결과              *");
                            Console.WriteLine("*             비겼습니다.            *");
                            Console.WriteLine("**************************************");
                            

                        }
                        else if (computer == 2)
                        {
                            Console.WriteLine();
                            Console.WriteLine("**************************************");
                            Console.WriteLine("*       당신은 가위를 냈습니다.      *");
                            Console.WriteLine("*       컴퓨터는 바위를 냈습니다.    *");
                            Console.WriteLine("*                                    *");
                            Console.WriteLine("*              게임결과              *");
                            Console.WriteLine("*          졌습니다. ㅠㅠㅠㅠ        *");
                            Console.WriteLine("**************************************");
                            
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("**************************************");
                            Console.WriteLine("*       당신은 가위를 냈습니다.      *");
                            Console.WriteLine("*       컴퓨터는 보를 냈습니다.      *");
                            Console.WriteLine("*                                    *");
                            Console.WriteLine("*              게임결과              *");
                            Console.WriteLine("*         이겼습니다!!!!!!!          *");
                            Console.WriteLine("**************************************");
                            
                        }
                        break;
                    case 2:
                        if (computer == 1)
                        {
                            Console.WriteLine();
                            Console.WriteLine("**************************************");
                            Console.WriteLine("*       당신은 바위를 냈습니다.      *");
                            Console.WriteLine("*       컴퓨터는 가위를 냈습니다.    *");
                            Console.WriteLine("*                                    *");
                            Console.WriteLine("*              게임결과              *");
                            Console.WriteLine("*         이겼습니다!!!!!!!          *");
                            Console.WriteLine("**************************************");
                            
                        }
                        else if (computer == 2)
                        { 
                            Console.WriteLine();
                            Console.WriteLine("**************************************");
                            Console.WriteLine("*       당신은 바위를 냈습니다.      *");
                            Console.WriteLine("*       컴퓨터는 바위를 냈습니다.    *");
                            Console.WriteLine("*                                    *");
                            Console.WriteLine("*              게임결과              *");
                            Console.WriteLine("*             비겼습니다.            *");
                            Console.WriteLine("**************************************");
                            
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("**************************************");
                            Console.WriteLine("*       당신은 바위를 냈습니다.      *");
                            Console.WriteLine("*       컴퓨터는 보를 냈습니다.      *");
                            Console.WriteLine("*                                    *");
                            Console.WriteLine("*              게임결과              *");
                            Console.WriteLine("*          졌습니다. ㅠㅠㅠㅠ        *");
                            Console.WriteLine("**************************************");
                            
                        }
                        break;
                    case 3:
                        if (computer == 1)
                        {
                            Console.WriteLine();
                            Console.WriteLine("**************************************");
                            Console.WriteLine("*       당신은 보를 냈습니다.        *");
                            Console.WriteLine("*       컴퓨터는 가위를 냈습니다.    *");
                            Console.WriteLine("*                                    *");
                            Console.WriteLine("*              게임결과              *");
                            Console.WriteLine("*          졌습니다. ㅠㅠㅠㅠ        *");
                            Console.WriteLine("**************************************");
                            
                        }
                        else if (computer == 2)
                        {
                            Console.WriteLine();
                            Console.WriteLine("**************************************");
                            Console.WriteLine("*       당신은 보를 냈습니다.        *");
                            Console.WriteLine("*       컴퓨터는 바위를 냈습니다.    *");
                            Console.WriteLine("*                                    *");
                            Console.WriteLine("*              게임결과              *");
                            Console.WriteLine("*         이겼습니다!!!!!!!          *");
                            Console.WriteLine("**************************************");
                           
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("**************************************");
                            Console.WriteLine("*       당신은 보를 냈습니다.        *");
                            Console.WriteLine("*       컴퓨터는 보를 냈습니다.      *");
                            Console.WriteLine("*                                    *");
                            Console.WriteLine("*              게임결과              *");
                            Console.WriteLine("*             비겼습니다.            *");
                            Console.WriteLine("**************************************");
                            
                        }
                        break;
                    case 4:

                        break;

                }
            }
            

        }
        static void Main(string[] args)
        {
            int i = 0;
            i = ShowMenu();
            switch (i)
            {
                case 1:
                    GameRockScissorPaper();
                    break;
                case 2:
                    break;
                case 3:
                    break;
            }


        }
    }
}
