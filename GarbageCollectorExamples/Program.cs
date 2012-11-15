namespace GarbageCollectorExamples
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            // Shows that large objects are in the Large Object Heap and are automatically promoted to gen2.
            // This helps performance since it doesn't start in gen0 and has to be promoted each time
            // until it reaches gen2.
            LargeObjectHeap();
        }

        private static void LargeObjectHeap()
        {
            var sb = new StringBuilder();
            Console.WriteLine("StringBuilder is in gen{0}", GC.GetGeneration(sb));

            var byteArray = new byte[86000];
            Console.WriteLine("Byte array is in gen{0}", GC.GetGeneration(byteArray));
        }
    }
}