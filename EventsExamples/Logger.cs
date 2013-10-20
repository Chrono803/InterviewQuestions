namespace EventsExamples
{
    using System;

    // public delegate void LoggerHandler(object sender, LoggerEventArgs e);

    public class Logger
    {
        // The compiler can infer the delegate to the event so we don't need the above delegate signature
        public event EventHandler<LoggerEventArgs> Logging; // Event with custom EventArgs
        public event EventHandler LoggingCompleted; // Even with built in EventArgs

        protected virtual void OnLogging(string message, LoggerType loggerType)
        {
            if (Logging != null) // Making sure there's something in the delegate's invocation list (no listeners attached).
            {
                Logging(this, new LoggerEventArgs(message, loggerType));
            }
        }

        protected virtual void OnLoggingCompleted()
        {
            if (LoggingCompleted != null)
            {
                LoggingCompleted(this, EventArgs.Empty);
            }
        }

        public void Log(string message, LoggerType loggerType)
        {
            // Raise the logging event
            OnLogging(message, loggerType);

            // Raise the logging completed event
            OnLoggingCompleted();
        }
    }
}