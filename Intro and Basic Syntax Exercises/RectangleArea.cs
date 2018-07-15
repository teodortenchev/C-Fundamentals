using System;


namespace Rectangle Area
{
    class Program
    {
        static void Main(string[] args)
        {
            float width = float.Parse(Console.ReadLine());
            float height = float.Parse(Console.ReadLine());
            float area = width * height;

            Console.WriteLine($"{area:F2}");


        }
    }
}
