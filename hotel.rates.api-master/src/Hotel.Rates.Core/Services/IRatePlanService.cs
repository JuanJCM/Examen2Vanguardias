using Hotel.Rates.Core.Interfaces;
using Hotel.Rates.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Hotel.Rates.Core.Services
{
    public class IRatePlanService : IRatePlan
    {
        private readonly IRatePlanRepository _ratePlan;
        public IRatePlanService(IRatePlanRepository rateplan)
        {
            _ratePlan = rateplan;
        }

        public ServiceResult<IReadOnlyList<RatePlanDTO>> Get()
        {
            var result = _ratePlan.GetAll()
    .Select(x => new RatePlanDTO
    {
        Id = x.Id,
        Name = x.Name,
        RatePlanType = x.RatePlanType,
        Price = x.Price,
        Seasons = x.Seasons.Select(s => new SeasonDTO
        {
          Id = s.Id,
          StartDate = s.StartDate,
          EndDate = s.EndDate
        }),
        Rooms = x.RatePlanRooms.Select(r => new RoomDTO
        {
           Name =  r.Room.Name,
           MaxAdults = r.Room.MaxAdults,
           MaxChildren = r.Room.MaxChildren,
           Amount = r.Room.Amount
        })
    }); 
            return ServiceResult<IReadOnlyList<RatePlanDTO>>.OkResult(result.ToList());
        }

        public ServiceResult<RatePlanDTO> GetById(int id)
        {
            var ratePlan = _ratePlan.GetById(id);

            var result =    (new RatePlanDTO
            {
                Id = ratePlan.Id,
                Name = ratePlan.Name,
                RatePlanType = ratePlan.RatePlanType,
                 Price =  ratePlan.Price,
                Seasons = ratePlan.Seasons.Select(s => new SeasonDTO
                {
                 Id =  s.Id,
                 StartDate =  s.StartDate,
                 EndDate = s.EndDate
                }),
                Rooms = ratePlan.RatePlanRooms.Select(r => new RoomDTO
                {
                   Name = r.Room.Name,
                   MaxAdults = r.Room.MaxAdults,
                   MaxChildren = r.Room.MaxChildren,
                   Amount = r.Room.Amount
                })
            });
            return ServiceResult<RatePlanDTO>.OkResult(result);
        }
    }
}
