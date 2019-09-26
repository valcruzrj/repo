using Parking.Dto;

namespace Parking.Application.Interface
{
    public interface ICarAppService
    {
        bool Create(CarDto carDto);
    }
}
