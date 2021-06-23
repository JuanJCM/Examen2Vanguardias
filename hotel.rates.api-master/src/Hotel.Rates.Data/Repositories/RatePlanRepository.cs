using Hotel.Rates.Core;
using Hotel.Rates.Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotel.Rates.Data.Repositories
{
    public class RatePlanRepository : IRatePlanRepository
    {
        InventoryContext _context;
        public RatePlanRepository(InventoryContext context)
        {
            _context = context;
        }
        public RatePlan GetById(int id)
        {
            return _context.RatePlans.Include(r => r.Seasons)
            .Include(r => r.RatePlanRooms)
            .ThenInclude(r => r.Room).FirstOrDefault(r => r.Id == id);

        }

        IReadOnlyList<RatePlan> IRatePlanRepository.GetAll()
        {
            return _context.RatePlans.Include(r => r.Seasons)
            .Include(r => r.RatePlanRooms)
            .ThenInclude(r => r.Room).ToList();
        }
    }
}
