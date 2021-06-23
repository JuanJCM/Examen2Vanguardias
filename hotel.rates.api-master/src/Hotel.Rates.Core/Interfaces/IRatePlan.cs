using Hotel.Rates.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Rates.Core.Interfaces
{
    public interface IRatePlan
    {
        ServiceResult<IReadOnlyList<RatePlanDTO>> Get();

        ServiceResult<RatePlanDTO> GetById(int id);
    }
}
