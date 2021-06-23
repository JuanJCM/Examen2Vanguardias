using Hotel.Rates.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Rates.Core.Interfaces
{
    public interface IRoomService
    {

        ServiceResult<IReadOnlyList<RoomDTO>> Get();
    }
}
