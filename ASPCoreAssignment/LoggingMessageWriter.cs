﻿namespace ASPCoreAssignment
{
    public class LoggingMessageWriter : ILoggingMessageWriter
    {
        private readonly ILogger<LoggingMessageWriter> _logger;

        public LoggingMessageWriter(ILogger<LoggingMessageWriter> logger) =>
            _logger = logger;

        public void Write(string message) =>
            _logger.LogInformation(message);
    }
}
