using System;


namespace BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            string productName = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energyContentPer100ml = int.Parse(Console.ReadLine());
            int sugarContentPer100ml = int.Parse(Console.ReadLine());
            double modifier = volume / 100d;
            double totalEnergy = modifier * energyContentPer100ml;
            double totalSugars = modifier * sugarContentPer100ml;

            Console.WriteLine($"{volume}ml {productName}:");
            Console.WriteLine($"{totalEnergy}kcal, {totalSugars}g sugars");


        }
    }
}
