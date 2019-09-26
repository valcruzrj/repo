using Parking.Dto;

namespace Parking.Application.Interface
{
    public interface ICustomerAppService
    {
        bool Create(CustomerDto customerDto);
    }
}
