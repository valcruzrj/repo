using Parking.Domain;
using Parking.Dto;
using Parking.Infra.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Parking.Infra
{
    public class RateReadRepository : IRateReadRepository
    {
        private ParkingDataContext _context { get; set; }

        public RateReadRepository(ParkingDataContext context)
        {
            _context = context;
        }

        public List<RateDto> GetAll()
        {
            return (from rate in _context.Rates
                    select new RateDto()
                    {
                        DailyAmount = rate.DailyAmount,
                        Description = rate.Description,
                        HourAmount = rate.HourAmount,
                        OvernightAmount = rate.OvernightAmount
                    }).ToList();
        }

        public RateDto GetById(int id)
        {
            return _context.Rates
                .Where(x => x.Id == id)
                .Select(x => new RateDto
                {
                    DailyAmount = x.DailyAmount,
                    Description = x.Description,
                    HourAmount = x.HourAmount,
                    OvernightAmount = x.OvernightAmount
                }).FirstOrDefault();
        }
    }
}
