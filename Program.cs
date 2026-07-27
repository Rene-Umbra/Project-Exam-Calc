using System;

namespace StudentQualification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Student Exam Qualification Calculator ---");
            Console.WriteLine();

            double test1 = ReadMark("Enter Test 1 mark (30%): ");
            double test2 = ReadMark("Enter Test 2 mark (50%): ");
            double assignment1 = ReadMark("Enter Assignment 1 mark (10%): ");
            double project = ReadMark("Enter Project mark (10%): ");

            double finalMark = (test1 * 0.3) + (test2 * 0.5) + (assignment1 * 0.1) + (project * 0.1);

            Console.WriteLine();
            Console.WriteLine($"Final Mark: {finalMark:F2}%");

            if (finalMark >= 50)
            {
                Console.WriteLine("Result: Student QUALIFIES to write the exam.");
            }
            else
            {
                Console.WriteLine("Result: Student DOES NOT QUALIFY to write the exam.");
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

       static double ReadMark(string prompt)
        {
            double mark;
            while (true)
            {
                Console.Write(prompt);
                string? input = Console.ReadLine();

                if (input != null && double.TryParse(input, out mark) && mark >= 0 && mark <= 100)
                {
                    return mark;
                }

                Console.WriteLine("Invalid mark. Please enter a value between 0 and 100.");
            }
        }
    }
}
