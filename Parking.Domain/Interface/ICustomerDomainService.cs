using Parking.Dto;

namespace Parking.Domain.Interface
{
    public interface ICustomerDomainService
    {
        bool Create(CustomerDto customerDto);
    }
}
