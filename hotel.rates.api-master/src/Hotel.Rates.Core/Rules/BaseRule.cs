using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Rates.Core.Rules
{
    public abstract class BaseRule
    {
        public abstract bool Applies(RatePlan rateplan);
        public abstract void ApplyRule(RatePlan rateplan, Season season, Room room);

    }
}
