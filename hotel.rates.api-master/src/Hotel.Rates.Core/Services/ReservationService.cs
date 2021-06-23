using Hotel.Rates.Core.Entities;
using Hotel.Rates.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Rates.Core.Services
{
    public class ReservationService : IReservation
    {
        private readonly IRepository<ReservationModelDTO,int> _repository;

        public ReservationService(IRepository<ReservationModelDTO,int> repository)
        {
            _repository = repository;
        }
        public ServiceResult<bool> RegisterReservation(ReservationModelDTO model)
        {
            var igual = _repository.GetbyId(model.RoomId);
            if(igual != null)
            {
                return ServiceResult<bool>.BadRequestResult($"Cuarto ocupado");
            }

            var ratePlan = _context
                 .NightlyRatePlans
                 .Include(r => r.Seasons)
                 .Include(r => r.RatePlanRooms)
                 .ThenInclude(r => r.Room)
                 .First(r => r.Id == reservationModel.RatePlanId);
            var canReserve = ratePlan.Seasons
                .Any(s => s.StartDate <= reservationModel.ReservationStart && s.EndDate >= reservationModel.ReservationEnd);
            var room = ratePlan.RatePlanRooms
                .First(r => r.RoomId == reservationModel.RoomId && r.RatePlanId == reservationModel.RatePlanId);
            var isRoomAvailable = room.Room.Amount > 0 &&
                room.Room.MaxAdults >= reservationModel.AmountOfAdults &&
                room.Room.MaxChildren <= reservationModel.AmountOfChildren;

            if (canReserve && isRoomAvailable)
            {
                room.Room.Amount -= 1;
                _context.SaveChanges();
                var days = (reservationModel.ReservationEnd - reservationModel.ReservationStart).TotalDays;
                return Ok(new
                {
                    Price = days * ratePlan.Price
                });
            }
            return ServiceResult<true>.BadRequest();
        }
    }
}
