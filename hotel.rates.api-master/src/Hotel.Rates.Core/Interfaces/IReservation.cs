using Hotel.Rates.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Rates.Core.Interfaces
{
    public interface IReservation
    {
        ServiceResult<bool> RegisterReservation(ReservationModelDTO model);
    }
}
