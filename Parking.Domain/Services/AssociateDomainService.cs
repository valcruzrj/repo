using Parking.Domain.Interface;
using Parking.Dto;

namespace Parking.Domain.Services
{
    public class AssociateDomainService : IAssociateDomainService
    {
        private ParkingDataContext _context { get; set; }

        public AssociateDomainService(ParkingDataContext context)
        {
            _context = context;
        }

        public bool Create(AssociateDto associateDto)
        {
            try
            {
                _context.Associates.Add(new Associate()
                {
                    Agreement = new Agreement()
                    {
                        Description = associateDto.Agreement.Description,
                        DiscountAmount = associateDto.Agreement.DiscountAmount,
                        DiscountPercentual = associateDto.Agreement.DiscountPercentual
                    },
                    Customer = new Customer()
                    {
                        Description = associateDto.Customer.Description,
                        Document = associateDto.Customer.Document,
                        Type = associateDto.Customer.Type
                    },
                    Quantity = associateDto.Quantity
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
