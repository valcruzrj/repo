using System.Collections.Generic;
using Parking.Application.Interface;
using Parking.Domain.Interface;
using Parking.Dto;
using Parking.Infra.Interface;

namespace Parking.Application
{
    public class ParkingAppService : IParkingAppService
    {
        public IParkingDomainService _parkingDomainService { get; set; }
        public IParkingReadRepository _parkingReadRepository { get; set; }

        public ParkingAppService(IParkingDomainService parkingDomainService,
                                 IParkingReadRepository parkingReadRepository)
        {
            _parkingDomainService = parkingDomainService;
            _parkingReadRepository = parkingReadRepository;
        }

        public bool Create(ParkingDto parkingDto)
        {
            return _parkingDomainService.Create(parkingDto);
        }

        public List<ParkingDto> GetAll()
        {
            return _parkingReadRepository.GetAll();
        }

        public ParkingDto GetById(int id)
        {
            return _parkingReadRepository.GetById(id);
        }

        public List<ParkingDto> GetAllWithDapper()
        {
            return _parkingReadRepository.GetAllWithDapper();
        }

        public bool Delete(int id)
        {
            var dto = _parkingReadRepository.GetById(id);
            return _parkingDomainService.Delete(dto);
        }
    }
}
