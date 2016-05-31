using Microsoft.Extensions.Configuration;
using System;
using Microsoft.Extensions.DependencyInjection;

namespace ConfigurationFilesSample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Config = new ConfigurationBuilder()
                 .SetBasePath(@"C:\Source\dotnet_jun2016\ConfigurationFilesSample\src\ConfigurationFilesSample\")
                 .AddJsonFile("mymandatoryconfig.json")
                 .AddJsonFile("myoptionalconfig.json", optional: true)
                 .AddEnvironmentVariables()
                 .AddCommandLine(args)
                 .AddUserSecrets()
                 .AddOptions()
                 .Build();

            Run();

        }

        private static void Run()
        {
            string val1 = Config["SomeKey"];
            string val2 = Config["ConnectionStrings:DefaultConnection"];

            Console.WriteLine(val1);
            Console.WriteLine(val2);

            string val3 = Config["a"];
            Console.WriteLine(val3);

            string val4 = Config["mysecret"];
            Console.WriteLine(val4);

        }

        public static IConfigurationRoot Config { get; private set; }
    }
}
