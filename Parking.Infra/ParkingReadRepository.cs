﻿using Dapper;
using Microsoft.EntityFrameworkCore;
using Parking.Domain;
using Parking.Dto;
using Parking.Infra.Interface;
using System.Collections.Generic;
using System.Linq;

namespace Parking.Infra
{
    public class ParkingReadRepository : IParkingReadRepository
    {
        private ParkingDataContext _context { get; set; }

        public ParkingReadRepository(ParkingDataContext context)
        {
            _context = context;
        }

        public List<ParkingDto> GetAll()
        {
            return (from parking in _context.Parking
                    select new ParkingDto()
                    {
                        Description = parking.Description,
                        Address = parking.Address,
                        Document = parking.Document,
                        Phone = parking.Phone
                    }).ToList();
        }

        public ParkingDto GetById(int id)
        {
            return _context.Parking
                .Where(x => x.Id == id)
                .Select(x => new ParkingDto
                {
                    Address = x.Address,
                    Description = x.Description,
                    Document = x.Document,
                    Phone = x.Phone
                }).FirstOrDefault();
        }

        public List<ParkingDto> GetAllWithDapper()
        {
            using (var connection = _context.Database.GetDbConnection())
            {
                return connection.Query<ParkingDto>("select Id, Description, Document, Address, Phone" +
                    "from Parking").ToList();
            }
        }
    }
}
