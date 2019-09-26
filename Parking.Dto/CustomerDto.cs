using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Dto
{
    public class CustomerDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Document { get; set; }
        public int Type { get; set; }
    }
}
