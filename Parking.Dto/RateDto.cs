using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Dto
{
    public class RateDto
    {
        public string Description { get; set; }
        public decimal DailyAmount { get; set; }
        public decimal OvernightAmount { get; set; }
        public decimal HourAmount { get; set; }
    }
}
