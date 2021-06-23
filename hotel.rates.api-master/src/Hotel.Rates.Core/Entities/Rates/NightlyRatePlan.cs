using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Rates.Core
{
    public class NightlyRatePlan : RatePlan
    {
        public NightlyRatePlan()
        {
            RatePlanType = (int)Data.RatePlanType.Nightly;
        }
    }
}
