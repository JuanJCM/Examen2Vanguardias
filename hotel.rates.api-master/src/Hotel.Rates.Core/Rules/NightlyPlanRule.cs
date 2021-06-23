﻿using Hotel.Rates.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Rates.Core.Rules
{
    class NightlyPlanRule : BaseRule
    {
        public override bool Applies(RatePlan rateplan)
        {
            return rateplan.RatePlanType == (int)RatePlanType.Nightly;
        }

        public override void ApplyRule(RatePlan rateplan, Season season, Room room)
        {
            throw new NotImplementedException();
        }
    }
}
