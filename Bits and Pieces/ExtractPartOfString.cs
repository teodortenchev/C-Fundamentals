using System;
					
public class Program
{
	public static void Main()
	{
		String path = "C:\\Pictures\\hello.jpg";
		int index = path.LastIndexOf("\\");
		String getName = path.Substring(index+1);
		Console.WriteLine(getName);
		
		//displays string from index 0 to index 11
		
		getName = path.Substring(0,12);
		Console.WriteLine(getName);
		
	}
}
