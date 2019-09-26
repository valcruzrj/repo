using Parking.Domain.Interface;
using Parking.Dto;

namespace Parking.Domain.Services
{
    public class AgreementDomainService : IAgreementDomainService
    {
        private ParkingDataContext _context { get; set; }

        public AgreementDomainService(ParkingDataContext context)
        {
            _context = context;
        }

        public bool Create(AgreementDto agremmentDto)
        {
            try
            {
                _context.Agreements.Add(new Agreement()
                {
                    Description = agremmentDto.Description,
                    DiscountAmount = agremmentDto.DiscountAmount,
                    DiscountPercentual = agremmentDto.DiscountPercentual
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
