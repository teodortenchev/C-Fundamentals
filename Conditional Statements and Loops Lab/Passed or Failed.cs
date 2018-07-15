using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());

            if (grade >= 3.0)
            {
                Console.WriteLine("Passed!");
            }
            else
                Console.WriteLine("Failed!");
        }
    }
}
