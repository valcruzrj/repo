using Parking.Dto;
using System.Collections.Generic;

namespace Parking.Domain.Interface
{
    public interface IParkingDomainService
    {
        bool Create(ParkingDto parkingDto);
        bool Delete(ParkingDto parkingDto);
    }
}
