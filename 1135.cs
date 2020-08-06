using System;
					
public class Program
{
	public static void Main()
	{
		var length = int.Parse(Console.ReadLine()) ;
		
		var ar = new char[length];
		var c = 0;
		
		while (c < length)
		{
			var str = Console.ReadLine();
			for (int i = 0; i < str.Length; i++)
			{
				ar[c + i] = str[i];
			}
			c += str.Length;
		}
		
		var counter = 0;
		var sum = 0;
		for (int i = 0; i < ar.Length; i ++)
		{
			if (ar[i] == '<')
			{
				sum += i - counter;
				
				counter++;
			}
		}
		
		Console.WriteLine(sum);
	}	
}
