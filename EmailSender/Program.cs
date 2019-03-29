using EmailSender.Contracts;
using EmailSender.Services;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace EmailSender
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IGoogleSender, GoogleSender>()
                .AddSingleton<IOutlookSender, OutLookSender>()
                .BuildServiceProvider();

            var gs = serviceProvider.GetService<IGoogleSender>();
            var os = serviceProvider.GetService<IOutlookSender>();

            Console.WriteLine("Choose user signature");
            Console.WriteLine("1. Google");
            Console.WriteLine("2. Outlook");

            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    gs.Send("Hello from google");
                    break;
                case 2:
                    os.Send("Hello form outlook");
                    break;
            }
        }
    }
}
