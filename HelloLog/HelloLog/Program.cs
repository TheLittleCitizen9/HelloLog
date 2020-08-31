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
            //var log = new LoggerConfiguration().WriteTo.Console().CreateLogger();
            //log.Information("Hello Serilog!");

            //var configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
            //.AddJsonFile("appsettings.json")
            //.Build();

            //var logger = new LoggerConfiguration()
            //    .ReadFrom.Configuration(configuration)
            //    .CreateLogger();

            //logger.Information("Hello Serilog!");

            LogicRunner logicRunner = new LogicRunner();

            logicRunner.RunLogic("Hello Serilog!");
        }
    }
}
