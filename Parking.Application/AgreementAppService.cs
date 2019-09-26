using Parking.Application.Interface;
using Parking.Domain.Interface;
using Parking.Dto;

namespace Parking.Application
{
    public class AgreementAppService : IAgreementAppService
    {
        public IAgreementDomainService _agreementDomainService { get; set; }

        public AgreementAppService(IAgreementDomainService agreementDomainService)
        {
            _agreementDomainService = agreementDomainService;
        }

        public bool Create(AgreementDto agreementDto)
        {
            return _agreementDomainService.Create(agreementDto);
        }
    }
}
