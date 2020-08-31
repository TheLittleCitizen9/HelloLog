using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Events;

namespace HelloLog
{
    public class LogicRunner
    {
        public void RunLogic(string message)
        {
            Random rnd = new Random();

            LogEventLevel logLevel = (LogEventLevel)(LogLevel)rnd.Next(6);
            var configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

            var logger = new LoggerConfiguration()
                .ReadFrom.Configuration(configuration)
                .CreateLogger();

            logger.Write(logLevel, message);
        }
    }
}
