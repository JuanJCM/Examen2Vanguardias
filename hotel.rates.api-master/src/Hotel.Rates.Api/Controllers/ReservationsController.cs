using Hotel.Rates.Api.Models;
using Hotel.Rates.Core.Entities;
using Hotel.Rates.Core.Interfaces;
using Hotel.Rates.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.Rates.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReservationsController : BaseApiController
    {
        private readonly InventoryContext _context;
        private readonly ReservationService _reservation;

        public ReservationsController(InventoryContext context, ReservationService reservationService )
        {
            this._context = context;
            _reservation = reservationService;
        }

        [HttpPost]
        public IActionResult Post([FromBody]ReservationModel reservationModel)
        {
            var result = _reservation.RegisterReservation(new ReservationModelDTO { 
                RatePlanId = reservationModel.RatePlanId,
                ReservationEnd = reservationModel.ReservationEnd,
                ReservationStart = reservationModel.ReservationStart,
                AmountOfAdults = reservationModel.AmountOfAdults,
                AmountOfChildren = reservationModel.AmountOfChildren
            });
            return GetResult(result);

            
        }
    }
}
