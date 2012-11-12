using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeterminePrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            int parsedInput = 0;

            if (Int32.TryParse(input, out parsedInput))
            {
                var items = Enumerable.Range(2, 100).Where(i => parsedInput % i == 0 && parsedInput != i);

                if (items.Count() == 0)
                {
                    Console.WriteLine("{0} is prime", parsedInput);
                }
            }
            else
            {
                Console.WriteLine("Input is not a number");
            }
        }
    }
}