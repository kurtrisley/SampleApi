using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApi.Controllers
{
    public class StandardShippingEstimator : IEstimateShipping
    {
        ISystemTime SystemTime;
        DateTime IEstimateShipping.GetEstimatedShipDate()
        {
            return SystemTime.GetCurrent().Hour <= 17 ?
                SystemTime.GetCurrent() :
                SystemTime.GetCurrent().AddDays(1).Date;
        }
    }

    public interface ISystemTime
    {
        DateTime GetCurrent();
    }

    public class SystemTime : ISystemTime
    {
        DateTime ISystemTime.GetCurrent()
        {
            return DateTime.Now;
        }
    }
}
