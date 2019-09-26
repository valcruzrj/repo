using Parking.Dto;

namespace Parking.Application.Interface
{
    public interface IAssociateAppService
    {
        bool Create(AssociateDto associateDto);
    }
}
