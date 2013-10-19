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
            Console.WriteLine("Delegate keyword - {0}", myDelegate("10"));
            Console.WriteLine("Delegate invocation list - {0}", myDelegate.GetInvocationList());

            Console.WriteLine("Anonymous delegate keyword - {0}", myDelegate2("10"));

            Console.WriteLine("Func - {0}", myFunc("10"));

            Console.WriteLine("Action Executed:");
            myAction(10);

            Console.WriteLine("Predicate executed:");
            if (myPredicate(0))
            {
                Console.WriteLine("Invoked and true");
            }
            else
            {
                Console.WriteLine("Invoked and false" + Environment.NewLine + Environment.NewLine);
            }

            // Set first delegate's invocation list
            myDelegate += myDelegate2;

            // Can we add a Func, Action, and Predicate to it as well?
            // myDelegate += myFunc + myAction + myPredicate;   Nope

            foreach (Delegate item in myDelegate.GetInvocationList())
            {
                Console.WriteLine("Delegate method - {0}", item.Method.Name);
                Console.WriteLine("Delegate target - {0}", item.Target);
            }

            Console.ReadLine();
        }

        public int ParseInput(string input)
        {
            return Int32.Parse(input);
        }
    }
}