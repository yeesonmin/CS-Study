using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class UserOne : ApplicationException { }
    class UserTwo : ApplicationException { }
    
    class UserexceptionApp
    {
        static void Number(int i)
        {
            if (i == 1)
            {
                throw new UserOne(); //예외발생

            }
            else
            {
                throw new UserTwo();
            }
        }
        static void Main(string[] args)
        {
            int a;

            try //예외 검사
            {
                a = int.Parse(Console.ReadLine());
                Number(a);
            }
            catch (UserOne) //예외 발생시 실행
            {
                Console.WriteLine("에러 1");
            }
            catch (UserTwo)
            {
                Console.WriteLine("에러 2");
            }
            finally //예외가 발생하든 않하든 무조건 실행
            {
                Console.WriteLine("가 발생 했어");
            }

        }
    }
}
