using Parking.Dto;
using System.Collections.Generic;

namespace Parking.Application.Interface
{
    public interface IParkingAppService
    {
        bool Create(ParkingDto parkingDto);
        bool Delete(int id);

        List<ParkingDto> GetAll();
        ParkingDto GetById(int id);
        List<ParkingDto> GetAllWithDapper();
    }
}
