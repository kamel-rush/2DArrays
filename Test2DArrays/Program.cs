using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2DArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[,] StudentGrades = new int[5,3];

            int NumberOfStudents = 0;
            int NumberOfGrades = 0;

            NumberOfStudents = GetInput("Please enter the number of students");

            NumberOfGrades = GetInput("Please enter the number of grades");
           


            int[,] StudentGrades = new int[NumberOfStudents, NumberOfGrades];

            for (int Row = 0; Row < NumberOfStudents; Row++)
            {
                Console.WriteLine("Grades for Student {0}", Row + 1);

                for (int Column = 0; Column < NumberOfGrades; Column++)
                {
                    Console.Write("Please enter grade {0}: ", Column + 1);
                    StudentGrades[Row, Column] = int.Parse(Console.ReadLine());

                }

            }


        }

        private static int GetInput(string P)
        {
            int input;
            Console.WriteLine(P);

            input = int.Parse(Console.ReadLine());
            return input;
        }
    }
}
