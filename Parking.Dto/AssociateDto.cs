using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Dto
{
    public class AssociateDto
    {
        public int Quantity { get; set; }
        public CustomerDto Customer { get; set; }
        public AgreementDto Agreement { get; set; }
    }
}
