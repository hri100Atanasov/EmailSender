using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmailSender
{
    public class FooService : IFooservice
    {
        private readonly ILogger<FooService> _logger;
        public FooService(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<FooService>();
        }

        public void DoThing(int number)
        {
            _logger.LogInformation($"Type count {number}");
        }
    }
}
