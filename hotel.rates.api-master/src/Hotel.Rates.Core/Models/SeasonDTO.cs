using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Rates.Core.Models
{
     public class SeasonDTO
    {
        public int Id { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int RatePlanID { get; set; }
    }
}
