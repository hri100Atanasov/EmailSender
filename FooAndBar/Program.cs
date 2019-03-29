using EmailSender;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;

namespace FooAndBar
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceProvider serviceProvider = new ServiceCollection()
                .AddLogging()
                .AddSingleton<IFooservice, FooService>()
                .AddSingleton<IBarService, BarService>()
                .BuildServiceProvider();

            serviceProvider.GetService<ILoggerFactory>()
                .AddConsole(LogLevel.Debug);

            var logger = serviceProvider.GetService<ILoggerFactory>()
                .CreateLogger<Program>();
            logger.LogDebug("Starting application");

            var bar = serviceProvider.GetService<IBarService>();

            bar.DoSomeRealWork();

            logger.LogDebug("All done!");

            Console.ReadKey();
        }
    }
}
