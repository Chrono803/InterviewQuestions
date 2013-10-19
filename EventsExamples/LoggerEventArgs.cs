namespace EventsExamples
{
    using System;

    public class LoggerEventArgs : EventArgs
    {
        public LoggerEventArgs(string message, LoggerType loggerType)
        {
            this.Message = message;
            this.LoggerType = loggerType;
        }

        public string Message { get; set; }
        public LoggerType LoggerType { get; set; }
    }
}