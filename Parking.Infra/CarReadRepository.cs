using Parking.Domain;
using Parking.Dto;
using Parking.Infra.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Parking.Infra
{
    public class CarReadRepository : ICarReadRepository
    {
        private ParkingDataContext _context { get; set; }

        public CarReadRepository(ParkingDataContext context)
        {
            _context = context;
        }

        public List<CarDto> GetAll()
        {
            return (from car in _context.Cars
                    select new CarDto()
                    {
                        Color = car.Color,
                        LicensePlate = car.LicensePlate,
                        Model = car.Model,
                        Year = car.Year
                    }).ToList();
        }

        public CarDto GetById(int id)
        {
            return _context.Cars
                .Where(x => x.Id == id)
                .Select(x => new CarDto
                {
                    Color = x.Color,
                    LicensePlate = x.LicensePlate,
                    Model = x.Model,
                    Year = x.Year
                }).FirstOrDefault();
        }
    }
}
