using Parking.Dto;

namespace Parking.Domain.Interface
{
    public interface IAssociateDomainService
    {
        bool Create(AssociateDto associateDto);
    }
}
