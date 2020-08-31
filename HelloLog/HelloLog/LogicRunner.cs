using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Core;
using Serilog.Events;

namespace HelloLog
{
    public class LogicRunner
    {
        public void RunLogic(string message, Logger logger)
        {
            Random rnd = new Random();

            LogEventLevel logLevel = (LogEventLevel)(LogLevel)rnd.Next(6);

            logger.Write(logLevel, message);
        }
    }
}
