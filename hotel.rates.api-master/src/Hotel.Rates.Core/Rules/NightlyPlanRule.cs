using Hotel.Rates.Data;
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

        protected override void ApplyRules(RatePlan rateplan, Season season, Room room)
        {
           //aqui vendria los calculos por noche
        }
    }
}
