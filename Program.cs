using System;

namespace CSharp.LabExercise1
{
    internal class Program
    {
        static void number1()
        {
            Console.WriteLine("Welcome to the Area and Perimeter Calculator");
            Console.WriteLine("");

            bool solveAgain = true;

            do
            {
                Console.Write("Enter length: ");
                double length = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter Width: ");
                double width = Convert.ToDouble(Console.ReadLine());

                double area = length * width;
                double perimeter = (2 * length) + (2 * width);

                Console.WriteLine("Area: {0}", area);
                Console.WriteLine("Perimeter: {0}", perimeter);
                Console.WriteLine("");

                Console.Write("Continue? (y/n): ");
                string willContinue = Console.ReadLine();
                Console.WriteLine("");

                if (willContinue == "y" || willContinue == "Y")
                {
                    solveAgain = true;
                }
                else
                { 
                    solveAgain = false;
                }
            } while (solveAgain == true);
            
        }

        static void number2()
        {
            Console.WriteLine("Welcome to the Letter Grade Calculator");
            Console.WriteLine("");

            bool solveAgain = true;

            do
            {
                Console.Write("Enter numerical grade: ");
                int grade = Convert.ToInt32(Console.ReadLine());

                if (grade < 60)
                {
                    Console.WriteLine("Letter grade: F");
                }

                else if (grade >= 60 && grade <= 66)
                {
                    Console.WriteLine("Letter grade: D");
                }

                else if (grade >= 67 && grade <= 79)
                {
                    Console.WriteLine("Letter grade: C");
                }

                else if (grade >= 80 && grade <= 87)
                {
                    Console.WriteLine("Letter grade: B");
                }

                else if (grade >= 88 && grade <= 100)
                {
                    Console.WriteLine("Letter grade: A");
                }

                Console.WriteLine("");
                Console.Write("Continue? (y/n): ");
                string willContinue = Console.ReadLine();
                Console.WriteLine("");

                if (willContinue == "y" || willContinue == "Y")
                {
                    solveAgain = true;
                }
                else
                {
                    solveAgain = false;
                }

            } while (solveAgain == true);
        }

        static void number3()
        {
            Console.WriteLine("Welcome to the Download Time Estimator");
            Console.WriteLine("");
            Console.WriteLine("This program calculates how long it will take to download a file with a 56k analog modem.");
            Console.WriteLine("");

            bool solveAgain = true;

            do
            {
                Console.Write("Enter a file size (MB): ");
                int fileSizeMB = Convert.ToInt32(Console.ReadLine());

                int fileSize = fileSizeMB * 1024000;
                int totalTime = fileSize / 5200;

                int hours = totalTime / 3600;
                int minutes = (totalTime % 3600) / 60;
                int seconds = (totalTime % 3600) % 60;

                Console.WriteLine("A 56k modem will take {0} hours {1} minutes {2} seconds", hours, minutes, seconds);

                Console.WriteLine("");
                Console.Write("Continue? (y/n): ");
                string willContinue = Console.ReadLine();
                Console.WriteLine("");

                if (willContinue == "y" || willContinue == "Y")
                {
                    solveAgain = true;
                }
                else
                {
                    solveAgain = false;
                }

            } while (solveAgain == true);
        }

        static void number4()
        {
            Console.Write("Enter square size: ");
            int square = Convert.ToInt32(Console.ReadLine());

            for(int row = 1; row <= square; row++)
            {
                for (int i = 1; i <= square; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            number1();
            number2();
            number3();
            number4();
        }
    }
}
