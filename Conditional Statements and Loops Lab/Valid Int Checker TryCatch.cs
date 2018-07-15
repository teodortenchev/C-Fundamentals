using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("It is a number.");
            }
            catch
            {
                Console.WriteLine("Invalid input!");
                
            }
            
        }
    }
}
