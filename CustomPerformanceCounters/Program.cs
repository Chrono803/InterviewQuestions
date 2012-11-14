namespace CustomPerformanceCounters
{
    using System.Diagnostics;
    using System.Linq;

    class Program
    {
        private static PerformanceCounter itemsPerSecond;

        static void Main(string[] args)
        {
            SetUpCounters();

            Enumerable.Range(1, 100).ToList().ForEach(i =>
                {
                    itemsPerSecond.IncrementBy(i);
                });
        }

        private static void SetUpCounters()
        {
            itemsPerSecond = new PerformanceCounter("Custom Counters", "Items/sec", "Custom Counter", false)
            {
                RawValue = 0
            };
        }
    }
}