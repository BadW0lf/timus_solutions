using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            Console.WriteLine(Resolve(input));
        }

        public static string Resolve(int input)
        {
            var totalAnswerStr = "";
            if (input == 0) return "10";
            if (input >= 1 && input <= 9) return input.ToString();
            var i = 9;
            while (i > 1)
            {
                if (input % i == 0)
                {
                    totalAnswerStr = i + totalAnswerStr;
                    input = input / i;
                    i = 9;
                    continue;
                }

                i--;
                if (i == 1 && input > 1) return "-1";
            }

            return string.IsNullOrEmpty(totalAnswerStr) ? "-1" : totalAnswerStr;
        }
    }
}