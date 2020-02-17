using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student
    {
        private string name;
        private int age;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Length > 3)
                {
                    Console.WriteLine("이름은 3글자를 넘을 수 없어");

                }
                else
                {
                    name = value;
                }
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }



    }

    class PropertyApp
    {
        public static void Main()
        {
            Student student = new Student();
            student.Age = 13;
            student.Name = "안녕하세요";
            student.Name = "삼겹살";

            Console.WriteLine("안녕? 나는 {0}이고 {1}살이야. 맛있게 먹어",student.Name, student.Age);
        }
        

    }

}
