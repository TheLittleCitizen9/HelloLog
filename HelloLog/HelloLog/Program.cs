using Serilog;
using System;

namespace HelloLog
{
    class Program
    {
        static void Main(string[] args)
        {
            var log = new LoggerConfiguration().WriteTo.Console().CreateLogger();
            log.Information("Hello Serilog!");
        }
    }
}
