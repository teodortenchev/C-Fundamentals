using System;

namespace count_integers
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			string input = "";
			int value;
			int counter = 0;
			for (int i = 0; i <= 100; i++) {
				input = Console.ReadLine();
				
				if (int.TryParse(input, out value)) {
					counter++;
				
				} else {
					Console.WriteLine(counter);
					break;
				}
			}
			
			
		}
	}
}
