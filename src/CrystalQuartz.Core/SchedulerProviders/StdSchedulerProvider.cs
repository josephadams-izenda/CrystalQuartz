using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CrystalQuartz.Core.Contracts;

namespace CrystalQuartz.Core.SchedulerProviders
{
    public class StdSchedulerProvider : ISchedulerProvider
    {
        public object CreateScheduler(ISchedulerEngine engine)
        {
            return engine.CreateStdScheduler();
        }
    }
}
