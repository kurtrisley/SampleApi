using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApi.Controllers
{
    public class DevelopSystemTime : ISystemTime
    {
        DateTime ISystemTime.GetCurrent()
        {
            return DateTime.Now;
        }
    }
}
