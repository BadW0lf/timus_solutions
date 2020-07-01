using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var line1 = Console.ReadLine().Split(' ');
            List<int> inputList = new List<int>(6);
            foreach (var s in line1)
            {
                inputList.Add(int.Parse(s));
            }

            var ticketPrice = int.Parse(Console.ReadLine());
            
            var t =Resolve(inputList.ToArray(), ticketPrice);

            Console.Out.WriteLine(t.Item1);
            Console.Out.WriteLine(string.Join(" ", t.Item2));
        }

        public static Tuple<int, int[]> Resolve(int[] input, int ticketPrice)
        {
            var totalMoney = input[0] * 10 + input[1] * 50 + input[2] * 100 + input[3] * 500 + input[4] * 1000 +
                             input[5] * 5000;

            var dictionary = new Dictionary<int, int>
            {
                {0, 10},
                {1, 50},
                {2, 100},
                {3, 500},
                {4, 1000},
                {5, 5000}
            };
            var max = totalMoney / ticketPrice;
            var index = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] <= 0) continue;
                index = i;
                break;
            }

            var lowBound = (totalMoney - dictionary[index]) / ticketPrice + 1;

            var result = new List<int>();
            for (int i = lowBound; i <= max; i++)
            {
                result.Add(i);
            }

            return new Tuple<int, int[]>(result.Count, result.ToArray());
        }
    }
}