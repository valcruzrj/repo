﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Dto
{
    public class CarDto
    {
        public int Id { get; set; }
        public string LicensePlate { get; set; }
        public string Model { get; set; }
        public DateTime Year { get; set; }
        public string Color { get; set; }
    }
}
