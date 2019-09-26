using Parking.Domain;
using Parking.Dto;
using Parking.Infra.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Parking.Infra
{
    public class AssociateReadRepository : IAssociateReadRepository
    {
        private ParkingDataContext _context { get; set; }

        public AssociateReadRepository(ParkingDataContext context)
        {
            _context = context;
        }

        public List<AssociateDto> GetAll()
        {
            return (from associate in _context.Associates
                    select new AssociateDto()
                    {
                        Agreement = new AgreementDto()
                        {
                            Description = associate.Agreement.Description,
                            DiscountAmount = associate.Agreement.DiscountAmount,
                            DiscountPercentual = associate.Agreement.DiscountPercentual
                        },
                        Customer = new CustomerDto()
                        {
                            Description = associate.Customer.Description,
                            Document = associate.Customer.Document,
                            Type = associate.Customer.Type
                        },
                        Quantity = associate.Quantity
                    }).ToList();
        }

        public AssociateDto GetById(int id)
        {
            return _context.Associates
                .Where(x => x.Id == id)
                .Select(x => new AssociateDto
                {
                    Agreement = new AgreementDto()
                    {
                        Description = x.Agreement.Description,
                        DiscountAmount = x.Agreement.DiscountAmount,
                        DiscountPercentual = x.Agreement.DiscountPercentual
                    },
                    Customer = new CustomerDto()
                    {
                        Description = x.Customer.Description,
                        Document = x.Customer.Document,
                        Type = x.Customer.Type
                    },
                    Quantity = x.Quantity
                }).FirstOrDefault();
        }
    }
}
