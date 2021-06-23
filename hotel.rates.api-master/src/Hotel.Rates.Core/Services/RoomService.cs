using Hotel.Rates.Core.Interfaces;
using Hotel.Rates.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotel.Rates.Core.Services
{
    public class RoomService : IRoomService
    {
        private readonly IRepository<Room, int> _room;
        public RoomService()
        {

        }

        public ServiceResult<IReadOnlyList<RoomDTO>> Get()
        {
            var rooms = _room.GetAll().Select(
               x => new RoomDTO
               {
                   Id = x.Id,
                   MaxAdults = x.MaxAdults,
                   MaxChildren = x.MaxChildren,
                   Amount = x.Amount,
                   Name = x.Name,
                   RatePlanRoom = x.RatePlanRooms.Select(s => new RatePlanRoomDTO
                   {
                       RoomId = s.RoomId,
                       Room = s.Room,
                       Rateplan = s.Rateplan,
                       RatePlanId = s.RatePlanId
                   })
               }
                )
                ;
            return ServiceResult<IReadOnlyList<RoomDTO>>.OkResult(rooms.ToList());
        }
    }
}
