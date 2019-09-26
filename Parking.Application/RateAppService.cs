using Parking.Application.Interface;
using Parking.Domain.Interface;
using Parking.Dto;

namespace Parking.Application
{
    public class RateAppService : IRateAppService
    {
        public IRateDomainService _rateDomainService { get; set; }

        public RateAppService(IRateDomainService rateDomainService)
        {
            _rateDomainService = rateDomainService;
        }

        public bool Create(RateDto rateDto)
        {
            return _rateDomainService.Create(rateDto);
        }
    }
}
