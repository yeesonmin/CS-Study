using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //다차원 배열 선언
            int[][] array = new int[3][];
            array[0] = new int[3];
            array[1] = new int[4];
            array[2] = new int[5];


            //다차원 배열 정의
            for(int i = 0; i <array.Length; i++)
            {
                for(int j = 0; j < array[i].Length; j++)
                {
                    array[i][j] = j + 1;
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
