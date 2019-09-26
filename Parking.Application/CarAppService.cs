using Parking.Application.Interface;
using Parking.Domain.Interface;
using Parking.Dto;

namespace Parking.Application
{
    public class CarAppService : ICarAppService
    {
        public ICarDomainService _carDomainService { get; set; }

        public CarAppService(ICarDomainService carDomainService)
        {
            _carDomainService = carDomainService;
        }

        public bool Create(CarDto carDto)
        {
            return _carDomainService.Create(carDto);
        }
    }
}
