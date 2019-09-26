using Parking.Application.Interface;
using Parking.Domain.Interface;
using Parking.Dto;

namespace Parking.Application
{
    public class CustomerAppService : ICustomerAppService
    {
        public ICustomerDomainService _customerDomainService { get; set; }

        public CustomerAppService(ICustomerDomainService customerDomainService)
        {
            _customerDomainService = customerDomainService;
        }

        public bool Create(CustomerDto customerDto)
        {
            return _customerDomainService.Create(customerDto);
        }
    }
}
