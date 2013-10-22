namespace EventsExamples
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var logger = new Logger();

            // Can subscribe to the events via a method
            logger.Logging += logger_Logging;
            logger.LoggingCompleted += logger_LoggingCompleted;

            // Can also subscribe to the events via lambda expressions
            logger.Logging += (s, e) => Console.WriteLine("Logging with logger type: {0}\nWith message: {1}. Inside lambda.", e.LoggerType, e.Message);
            logger.LoggingCompleted += (s, e) => Console.WriteLine("Logging has completed inside lambda.\n\n");
            
            // Making the call to the event. Each subscription is being listened and will execute
            logger.Log("Logging info message", LoggerType.Information);

            // Unsubscribing to the event. This won't fire as nothing is attached to it (nothing is listening)
            logger.Logging -= (s, e) => Console.WriteLine("Logging with logger type: {0}\nWith message: {1}. Inside lambda.", e.LoggerType, e.Message);

            logger.Log("Unsubscribe example", LoggerType.Warning);

            Console.ReadLine();
        }

        static void logger_LoggingCompleted(object sender, EventArgs e)
        {
            Console.WriteLine("Logging completed inside method\n\n");
        }

        static void logger_Logging(object sender, LoggerEventArgs e)
        {
            Console.WriteLine("Logging with logger type: {0}\nWith message: {1}\n\n", e.LoggerType, e.Message);
        }
    }
}