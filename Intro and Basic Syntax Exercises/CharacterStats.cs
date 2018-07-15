using System;


namespace CharacterSets
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currentHP = int.Parse(Console.ReadLine());
            int maxHP = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");
            
            string healthBar = new string('|', currentHP);
            string emptyHP = new string('.', maxHP - currentHP);
            string energyBar = new string('|', currentEnergy);
            string emptyEnergy = new string('.', maxEnergy - currentEnergy);

            Console.WriteLine($"Health: |{healthBar}{emptyHP}|");
            Console.WriteLine($"Energy: |{energyBar}{emptyEnergy}|");
        }
    }
}
