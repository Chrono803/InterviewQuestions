namespace FizzBuzz
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            Enumerable.Range(1, 100).ToList().ForEach(i => Console.WriteLine(
                i % 5 == 0 && i % 3 == 0 ? "FizzBuzz" :
                    i % 3 == 0 ? "Fizz" :
                    i % 5 == 0 ? "Buzz" :
                    i.ToString()));
        }
    }
}