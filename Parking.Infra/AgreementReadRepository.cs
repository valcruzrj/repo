using Parking.Domain;
using Parking.Dto;
using Parking.Infra.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Parking.Infra
{
    public class AgreementReadRepository : IAgreementReadRepository
    {
        private ParkingDataContext _context { get; set; }

        public AgreementReadRepository(ParkingDataContext context)
        {
            _context = context;
        }

        public List<AgreementDto> GetAll()
        {
            return (from agreement in _context.Agreements
                    select new AgreementDto()
                    {
                        Description = agreement.Description,
                        DiscountAmount = agreement.DiscountAmount,
                        DiscountPercentual = agreement.DiscountPercentual
                    }).ToList();
        }

        public AgreementDto GetById(int id)
        {
            return _context.Agreements
                .Where(x => x.Id == id)
                .Select(x => new AgreementDto
                {
                    Description = x.Description,
                    DiscountAmount = x.DiscountAmount,
                    DiscountPercentual = x.DiscountPercentual
                }).FirstOrDefault();
        }
    }
}
