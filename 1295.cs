using System;
					
public class Program
{
	public static void Main()
	{
		var t = GetEndingZeroes(int.Parse(Console.ReadLine()));
		Console.WriteLine(t);
	}
	
	public static int GetEndingZeroes(int n)
	{
		var result = 0;
		var sum = 0;
		var prev2 = 2;
		var prev3 = 3;
		var prev4 = 4;
		for (int i = 1; i < n; i++)
		{
			prev2 = prev2*2 % 1000;
			prev3 = prev3*3 % 1000;
			prev4 = prev4*4 % 1000;
		}
		
		sum = 1+prev2+prev3+prev4;
		
		while (sum % 10 == 0)
		{
			result ++;
			sum = sum / 10;
		}
		
		return result;
	}
}
