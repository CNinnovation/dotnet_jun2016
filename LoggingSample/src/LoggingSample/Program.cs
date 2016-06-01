using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoggingSample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ILoggerFactory logger = new LoggerFactory()
                .AddConsole()
                .AddDebug();

            Logger = logger.CreateLogger<Program>();

            Foo();

        }

        private static void Foo()
        {
            Logger.LogInformation($"{nameof(Foo)}");
            Bar();
        }

        private static void Bar()
        {
            Logger.LogError($"Error in {nameof(Bar)}");
        }

        public static ILogger Logger { get; private set; }
    }
}
