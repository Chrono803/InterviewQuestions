using System;
using System.Collections.Generic;
using System.Linq;

namespace SnippetsAndAlgorithms
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();

            var result = ReverseString(input);

            result.ToList().ForEach(Console.Write);
        }

        private static IEnumerable<string> ReverseString(string input)
        {
            var resultArray = new string[input.Length];

            for (int i = 0; i < resultArray.Length; i++)
            {
                resultArray[i] = input.Substring(i, 1);
            }

            Array.Reverse(resultArray);

            return resultArray;
        }
    }
}