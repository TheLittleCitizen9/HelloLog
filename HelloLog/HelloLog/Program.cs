using Microsoft.Extensions.Configuration;
using Serilog;
using System;
using System.IO;

namespace HelloLog
{
    class Program
    {
        static void Main(string[] args)
        {
            var configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

            var logger = new LoggerConfiguration()
                .ReadFrom.Configuration(configuration)
                .CreateLogger();

            LogicRunner logicRunner = new LogicRunner();

            logicRunner.RunLogic("Hello Serilog!", logger);
        }
    }
}
