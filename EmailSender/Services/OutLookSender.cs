using EmailSender.Contracts;
using System;

namespace EmailSender.Services
{
    class OutLookSender : IOutlookSender
    {
        public void Send(string message)
        {
            Console.Write($"Outlook user {message}");
        }
    }
}
