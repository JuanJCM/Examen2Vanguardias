using Hotel.Rates.Core.Services;
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
    public class RatePlansController : BaseApiController
    {
        private readonly InventoryContext _context;
        private readonly RatePlanService _rateplanService;

        public RatePlansController(InventoryContext context, RatePlanService ratePlanService)
        {
            _context = context;
            _rateplanService = ratePlanService;
        }
        
        [HttpGet]
        public IActionResult Get()
        {
            var result = _rateplanService.Get();
            return GetResult(result);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {

            var result = _rateplanService.GetById(id);
            return GetResult(result);
           
        }
    }
}
