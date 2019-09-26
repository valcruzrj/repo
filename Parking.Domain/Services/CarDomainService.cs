using Parking.Domain.Interface;
using Parking.Dto;

namespace Parking.Domain.Services
{
    public class CarDomainService : ICarDomainService
    {
        private ParkingDataContext _context { get; set; }

        public CarDomainService(ParkingDataContext context)
        {
            _context = context;
        }

        public bool Create(CarDto carDto)
        {
            try
            {
                _context.Cars.Add(new Car()
                {
                    Color = carDto.Color,
                    LicensePlate = carDto.LicensePlate,
                    Model = carDto.Model,
                    Year = carDto.Year
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
