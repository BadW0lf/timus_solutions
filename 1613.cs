using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		Console.ReadLine();
		var m = Console.ReadLine().Split(' ');
		Dictionary<int, List<int>> inp = new Dictionary<int, List<int>>();
		for (int i = 0; i < m.Length; i++)
		{
			var val = int.Parse(m[i]);
			if (inp.ContainsKey(val))
			{
				inp[val].Add(i + 1);
			}
			else
			{
				inp.Add(val, new List<int>());
				inp[val].Add(i+1);
			}
		}
		
		var queriesCount = int.Parse(Console.ReadLine());
		var listChars = new List<char>();
		for (int i = 0; i < queriesCount; i++)
		{
			var str = Console.ReadLine().Split(' ');
			var l = int.Parse(str[0]);
			var r = int.Parse(str[1]);
			var x = int.Parse(str[2]);
			listChars.Add(GetAnswer(inp,l , r, x));
		}
		
		Console.WriteLine(string.Join("", listChars));
	}
	
	public static char GetAnswer(Dictionary<int, List<int>> input, int l, int r, int x)
	{
		if (!input.ContainsKey(x))
			return '0';
		
		var arr = input[x];
		
		var left = -1;
		var right = arr.Count;
		while (right - left != 1)
		{
			var middle = (left + right) / 2;
			if (arr[middle] >= l)
			{
				right = middle;
			}
			else
			{
				left = middle;
			}
		}
		
		if (right == arr.Count) 
			return '0';
		
		if (arr[right] <= r) 
			return '1';
		
		return '0';
	}
}
