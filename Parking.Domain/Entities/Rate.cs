﻿namespace Parking.Domain
{
    public class Rate
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal DailyAmount { get; set; }
        public decimal OvernightAmount { get; set; }
        public decimal HourAmount { get; set; }
    }
}
