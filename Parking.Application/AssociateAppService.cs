using Parking.Application.Interface;
using Parking.Domain.Interface;
using Parking.Dto;

namespace Parking.Application
{
    public class AssociateAppService : IAssociateAppService
    {
        public IAssociateDomainService _associateDomainService { get; set; }

        public AssociateAppService(IAssociateDomainService associateDomainService)
        {
            _associateDomainService = associateDomainService;
        }

        public bool Create(AssociateDto associateDto)
        {
            return _associateDomainService.Create(associateDto);
        }
    }
}
