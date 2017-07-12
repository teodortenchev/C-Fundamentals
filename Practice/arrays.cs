/*
 * Created by SharpDevelop.
 * User: c09190a
 * Date: 7/11/2017
 * Time: 11:38 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
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
			
			Console.WriteLine("The length of this array is " + knownNumbers.Length);
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
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
