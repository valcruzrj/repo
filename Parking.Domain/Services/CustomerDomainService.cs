using Parking.Domain.Interface;
using Parking.Dto;

namespace Parking.Domain.Services
{
    public class CustomerDomainService : ICustomerDomainService
    {
        private ParkingDataContext _context { get; set; }

        public CustomerDomainService(ParkingDataContext context)
        {
            _context = context;
        }

        public bool Create(CustomerDto customerDto)
        {
            try
            {
                _context.Customers.Add(new Customer()
                {
                    Description = customerDto.Description,
                    Document = customerDto.Document,
                    Type = customerDto.Type
                });

                _context.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
