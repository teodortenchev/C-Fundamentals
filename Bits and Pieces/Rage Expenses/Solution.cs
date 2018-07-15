using System;
using System.Collections.Generic;

namespace RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort lostGames = ushort.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double screenPrice = double.Parse(Console.ReadLine());

            Dictionary<string, int> gamingGearTracker = new Dictionary<string, int>()
            {
                { "headset", 0 }, { "mouse", 0 }, { "keyboard", 0}, { "screen", 0 }
            };

            Dictionary<string, double> priceList = new Dictionary<string, double>()
            {
                { "headset", headsetPrice }, { "mouse", mousePrice },{ "keyboard", keyboardPrice }, { "screen", screenPrice },
            };

            int keyboardTracker = 0;


            for (int i = 1; i <= lostGames; i++)
            {
                
                if (i % 2 == 0) //Detects every 2nd loss
                {
                    gamingGearTracker["headset"]++;


                    if (i % 3 == 0) //also the third?
                    {
                        gamingGearTracker["mouse"]++;
                        gamingGearTracker["keyboard"]++;

                        keyboardTracker++;


                        if (keyboardTracker == 2)
                        {

                            gamingGearTracker["screen"]++;
                            keyboardTracker = 0;
                        }
                    }
                }

                else if (i % 3 == 0) //this is a standalone 3rd loss
                {
                    gamingGearTracker["mouse"]++;

                }


            }

            double totalCost = CalculateRageExpenses(gamingGearTracker, priceList);

            Console.WriteLine("Rage expenses: {0:F2} lv.", totalCost);


        }
        static double CalculateRageExpenses(Dictionary<string,int> brokenItems, Dictionary<string,double> itemPrices)
        {
            double totalAmount = 0;

            foreach (var item in brokenItems)
            {
                totalAmount += item.Value * itemPrices[item.Key];
            }

            return totalAmount;
        }
    }
}
