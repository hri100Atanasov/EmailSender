using EmailSender.Contracts;
using System;

namespace EmailSender.Services
{
    public class GoogleSender : IGoogleSender
    {
        public void Send(string message)
        {
            Console.Write($"Google user {message}");
        }
    }
}
