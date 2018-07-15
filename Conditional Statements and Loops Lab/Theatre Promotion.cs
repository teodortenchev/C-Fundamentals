using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            var price = 0;

            if ((age < 0 || age > 122))
            {
                Console.WriteLine("Error!");
                return;
            }

            if (day == "Weekday")
            {
                if ((age >= 0 && age <= 18) || (age > 64))
                {
                    price = 12;
                }
                else
                {
                    price = 18;
                } 
            }
            else if (day == "Weekend")
            {
                if ((age >= 0 && age <= 18) || (age > 64))
                {
                    price = 15;
                }
                else
                {
                    price = 20;
                }               
            }
            else 
            {
                if (age >= 0 && age <= 18)
                {
                    price = 5;
                }
                else if (age > 18 && age <= 64)
                {
                    price = 12;
                }
                else
                {
                    price = 10;
                }
            }

            Console.WriteLine($"{price}$");
        }
    }
}
