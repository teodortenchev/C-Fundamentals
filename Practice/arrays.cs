using System;

namespace Arrays
{
	class Program
	{
		public static void Main(string[] args)
		{
			//creates an array of 10 int elements
			int[] numbers = new int[10];
			
			//creates an array with 5 values initialized
			
			int[] knownNumbers = { 1 , 2 , 3, 4, 5 };
			//This can also be written out like int[] knownNumbers = new int[] { 1, 2, 3, ...}
			
			
			//
			
			Console.WriteLine("The length of this array is " + knownNumbers.Length);
			Console.WriteLine("Its contents are the following numbers: ");
			
			for (int i = 0; i < knownNumbers.Length; i++) {
				Console.WriteLine(knownNumbers[i]);
			}
			
			Console.WriteLine("Now we will reverse them below using a simple for loop and by storing them in a new array: ");
			
			int[] reverseNumbers = new int[knownNumbers.Length];
			
			for (int i = 0; i < knownNumbers.Length; i++) {
				reverseNumbers[i] = knownNumbers[knownNumbers.Length - 1 - i];
				Console.WriteLine(reverseNumbers[i]);
				
			}
				
				
			//assigns values to the array. Could have been done when initializing
			
			
			string[] daysOfWeek = 
			{
				"Monday",
				"Tuesday",
				"Wednessday",
				"Thursday",
				"Friday",
				"Saturday",
				"Sunday"
			};
			
			
			
			for (int i = 0; i < daysOfWeek.Length; i++) {
				Console.WriteLine(daysOfWeek[i]);
				
				
			}
			
			//now to reverse this and store the reversed order one way is with a loop
			Console.WriteLine("----------------------------");
			string[] reverseDays = new string[daysOfWeek.Length];
			
			for (int i = 0; i < daysOfWeek.Length; i++) {
				
				reverseDays[i] = daysOfWeek[daysOfWeek.Length - 1 -i];
				Console.WriteLine(reverseDays[i]);
			}
			
			Array.Reverse(knownNumbers);
			PrintIndexAndValues(knownNumbers);
			
	
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static void PrintIndexAndValues( Array myArray )  {
      			for ( int i = myArray.GetLowerBound(0); i <= myArray.GetUpperBound(0); i++ )
         		Console.WriteLine( "\t[{0}]:\t{1}", i, myArray.GetValue( i ) );
		}
		
	}
	
}
