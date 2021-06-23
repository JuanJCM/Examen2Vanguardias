using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Rates.Core.Models
{
    public class RatePlanDTO
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int RatePlanType { get; set; }
        public double Price { get; set; }
        public IEnumerable<SeasonDTO> Seasons { get; set; }
        public IEnumerable<RoomDTO> Rooms { get; set; }
    }
}
