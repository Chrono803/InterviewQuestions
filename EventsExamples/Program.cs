namespace EventsExamples
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var logger = new Logger();

            // Subscribing to the events via lambda expressions
            logger.Logging += (s, e) => Console.WriteLine("Logging with logger type: {0}\nWith message: {1}\n\n", e.LoggerType, e.Message);
            logger.LoggingCompleted += (s, e) => Console.WriteLine("Logging has completed");

            logger.Log("Logging info message", LoggerType.Information);

            Console.ReadLine();
        }
    }
}