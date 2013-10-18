namespace DelegatesExamples
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        public delegate int NewDelegate(string input);

        static void Main(string[] args)
        {
            // Delegate keyword
            var myDelegate = new NewDelegate(new Program().ParseInput);

            // Anonymous delegate
            var myDelegate2 = new NewDelegate(delegate(string input)
                { 
                    return Int32.Parse(input);
                });

            // Func
            Func<string, int> myFunc = i => Int32.Parse(i);

            // Action
            Action<int> myAction = i => Console.WriteLine(i);

            // Predicate
            Predicate<int> myPredicate = i => i == 0;

            // Output
            Console.WriteLine("Delegate keyword - {0}", myDelegate.Invoke("10"));

            Console.WriteLine("Anonymous delegate keyword - {0}", myDelegate2.Invoke("10"));

            Console.WriteLine("Func - {0}", myFunc.Invoke("10"));

            Console.WriteLine("Action Executed:");
            myAction.Invoke(10);

            Console.WriteLine("Predicate executed:");
            if (myPredicate.Invoke(0))
            {
                Console.WriteLine("Invoked and true");
            }
            else
            {
                Console.WriteLine("Invoked and false");
            }
        }

        public int ParseInput(string input)
        {
            return Int32.Parse(input);
        }
    }
}