using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();

            switch (country) {
                case "England":
                case "USA":
                    Console.WriteLine("English");
                    break;
                case "Argentina":
                case "Mexico":
                case "Spain":
                    Console.WriteLine("Spanish");
                    break;

                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
