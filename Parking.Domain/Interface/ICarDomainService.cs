using Parking.Dto;

namespace Parking.Domain.Interface
{
    public interface ICarDomainService
    {
        bool Create(CarDto carDto);
    }
}
