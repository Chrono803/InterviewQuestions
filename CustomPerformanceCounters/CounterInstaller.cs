namespace CustomPerformanceCounters
{
    using System.ComponentModel;
    using System.Configuration.Install;
    using System.Diagnostics;

    [RunInstaller(true)]
    public class CounterInstaller : Installer
    {
        public CounterInstaller()
        {
            using (var counterInstaller = new PerformanceCounterInstaller())
            {
                counterInstaller.CategoryHelp = "Category help";
                counterInstaller.CategoryType = PerformanceCounterCategoryType.MultiInstance;
                counterInstaller.CategoryName = "Category name";

                CounterCreationData numbersProcessed = new CounterCreationData
                {
                    CounterType = PerformanceCounterType.NumberOfItems32,
                    CounterName = "Items processed/sec",
                    CounterHelp = "Number of items processed"
                };

                counterInstaller.Counters.Add(numbersProcessed);

                base.Installers.Add(counterInstaller);
            }
        }
    }
}