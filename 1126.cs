using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var windowSize = int.Parse(Console.ReadLine());
            var next = int.Parse(Console.ReadLine());
            var inputList = new List<int>();
            while (next != -1)
            {
                inputList.Add(next);
                next = int.Parse(Console.ReadLine());
            }

            var answer = Resolve(windowSize, inputList.ToArray());

            foreach (var item in answer)
            {
                Console.WriteLine(item);
            }
        }

        public static int[] Resolve(int windowSize, int[] inputArray)
        {
            List<int> answersList = new List<int>();
            List<int> l = new List<int>(windowSize);
            for (int i = 0; i < windowSize; i++)
            {
                l.Add(inputArray[i]);
            }
            
            l.Sort();
            answersList.Add(l[windowSize-1]);
            
            for (int i = 1; i < inputArray.Length - windowSize + 1; i++)
            {
                 l = new List<int>();
                for (int j = i; j < i+windowSize; j++)
                {
                    l.Add(inputArray[j]);
                }

                l.Sort();
                answersList.Add(l[windowSize-1]);
            }
            
            return answersList.ToArray();
        }
    }
}