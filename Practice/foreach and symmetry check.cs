
using System;

namespace Arrays2
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			
			int[] numbers = { 1, 2, 3 , 4 , 3, 2, 1};
			int upperIndex = numbers.Length - 1;
			
			bool isSymmetric = true;
			
			for (int i = 0; i <= upperIndex; i++) {
				if (numbers[i] != numbers[upperIndex - i]) {
					isSymmetric = false;
				} 
			}
			
			if (isSymmetric){
				Console.WriteLine("This array is symmetric.");
			} else {
				Console.WriteLine("Not symmetric.");
			}
			
			Console.WriteLine;
			Console.WriteLine("Listing values of array with foreach");
			//Listing values of array with foreach
			
			string[] elements = {
			"Fire",
			"Water",
			"Earth",
			"Air",
			"Dark matter"};
			
			foreach (string element in elements) {
				Console.WriteLine(element);
			}
			
			//often times you will see var used instead of specifying the exact type
			
			foreach (var element in elements) {
				
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
