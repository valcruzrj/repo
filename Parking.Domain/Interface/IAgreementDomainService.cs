using Parking.Dto;

namespace Parking.Domain.Interface
{
    public interface IAgreementDomainService
    {
        bool Create(AgreementDto agreementDto);
    }
}
