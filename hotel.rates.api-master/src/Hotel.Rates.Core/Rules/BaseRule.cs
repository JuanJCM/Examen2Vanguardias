using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Rates.Core.Rules
{
    public abstract class BaseRule
    {
        public abstract bool Applies(RatePlan rateplan);
        public void ApplyRule(RatePlan rateplan, Season season, Room room) 
        {
            //Aqui iria toda la logica y reglas de los rate plans pero ya no me dio tiempo :(
            ApplyRules(rateplan, season, room);
        }

        protected abstract void ApplyRules(RatePlan rateplan, Season season, Room room);

    }
}
