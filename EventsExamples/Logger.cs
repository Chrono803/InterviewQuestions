using System;
namespace EventsExamples
{
    // public delegate void LoggerHandler(object sender, LoggerEventArgs e);

    public class Logger
    {
        // Uses delegate inference so we don't need the above delegate signature
        public event EventHandler<LoggerEventArgs> OnLogging;

        public void LogMessage()
        {
            // Log(new LoggerEventArgs
        }

        private void Log(string message, LoggerType loggerType)
        {
            if (OnLogging != null) // Making sure something is listening
            {
                Console.WriteLine("{0} message - {1}", loggerType, message);
            }
        }
    }
}