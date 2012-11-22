namespace GarbageCollectorExamples
{
    using System;
    using System.Text;
    using System.Threading;

    class Program
    {
        static void Main(string[] args)
        {
            // Shows that large objects are in the Large Object Heap and are automatically promoted to gen2.
            // This helps performance since it doesn't start in gen0 and has to be promoted each time
            // until it reaches gen2.
            //LargeObjectHeap();

            // Shows that, when a collection occurs, it sees if there are any roots left in the objects.
            // In this case, after the call to ReadLine, there was no other reference to "t", so when the
            // call to GC.Collect was made, it considered it garbage. Another way to do this is to use the
            // Dispose Pattern, shown in the comments below, which I tend to prefer.
            TimerCall();
        }

        private static void LargeObjectHeap()
        {
            var sb = new StringBuilder();
            Console.WriteLine("StringBuilder is in gen{0}", GC.GetGeneration(sb));
             
            var byteArray = new byte[86000];
            Console.WriteLine("Byte array is in gen{0}", GC.GetGeneration(byteArray));
        }

        private static void TimerCall()
        {
            //using (var t = new Timer(TimerCallBack, null, 0, 2000))
            //{
            //    Console.ReadLine();
            //}

            var t = new Timer(TimerCallBack, null, 0, 2000);

            Console.ReadLine();

            // Calling dispose on "t" still refers to it (so it has a root), therefore
            // it won't be considered garbage and will be kept alive.
            //t.Dispose();
        }

        private static void TimerCallBack(object o)
        {
            Console.WriteLine("In TimerCallBack: {0}", DateTime.Now);

            GC.Collect();
        }
    }
}