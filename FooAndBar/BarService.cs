using System;
using System.Collections.Generic;
using System.Text;

namespace EmailSender
{
    public class BarService : IBarService
    {
        private readonly IFooservice _fooservice;

        public BarService(IFooservice fooservice)
        {
            _fooservice = fooservice;
        }

        public void DoSomeRealWork()
        {
            for (int i = 0; i < 10; i++)
            {
                _fooservice.DoThing(i);
            }
        }
    }
}
