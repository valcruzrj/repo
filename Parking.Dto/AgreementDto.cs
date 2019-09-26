using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Dto
{
    public class AgreementDto
    {
        public string Description { get; set; }
        public decimal DiscountAmount { get; set; }
        public double DiscountPercentual { get; set; }
    }
}
