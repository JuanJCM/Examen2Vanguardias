using Hotel.Rates.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Rates.Core.Rules
{
    class IntervalPlanRule : BaseRule
    {
        public override bool Applies(RatePlan rateplan)
        {
            return rateplan.RatePlanType == (int)RatePlanType.Interval;
        }

        protected override void ApplyRules(RatePlan rateplan, Season season, Room room)
        {
            //aqui se aplicaria los cargos por dia
        }
    }
}
