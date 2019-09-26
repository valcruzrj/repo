using Parking.Domain;
using Parking.Dto;
using Parking.Infra.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Parking.Infra
{
    public class CustomerReadRepository : ICustomerReadRepository
    {
        private ParkingDataContext _context { get; set; }

        public CustomerReadRepository(ParkingDataContext context)
        {
            _context = context;
        }

        public List<CustomerDto> GetAll()
        {
            return (from customer in _context.Customers
                    select new CustomerDto()
                    {
                        Description = customer.Description,
                        Document = customer.Document,
                        Type = customer.Type
                    }).ToList();
        }

        public CustomerDto GetById(int id)
        {
            return _context.Customers
                .Where(x => x.Id == id)
                .Select(x => new CustomerDto
                {
                    Description = x.Description,
                    Document = x.Document,
                    Type = x.Type
                }).FirstOrDefault();
        }

        public CustomerDto GetByReservationId(int reservationId)
        {
            return (from customer in _context.Customers
                    join reservation in _context.Reservations on customer.Id equals reservation.CustomerId
                    where reservation.Id == reservationId
                    select new CustomerDto()
                    {
                        Id = customer.Id,
                        Description = customer.Description,
                        Document = customer.Document,
                        Type = customer.Type
                    }).FirstOrDefault();
        }
    }
}
