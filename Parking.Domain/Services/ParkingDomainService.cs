using Parking.Domain.Interface;
using Parking.Dto;

namespace Parking.Domain.Services
{
    public class ParkingDomainService : IParkingDomainService
    {
        private ParkingDataContext _context { get; set; }

        public ParkingDomainService(ParkingDataContext context)
        {
            _context = context;
        }

        public bool Create(ParkingDto parkingDto)
        {
            try
            {
                _context.Parking.Add(new Parking()
                {
                    Address = parkingDto.Address,
                    Description = parkingDto.Description,
                    Document = parkingDto.Document,
                    Phone = parkingDto.Phone
                });

                _context.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(ParkingDto parkingDto)
        {
            try
            {
                if (parkingDto != null)
                {
                    _context.Parking.Remove(new Parking()
                    {
                        Address = parkingDto.Address,
                        Description = parkingDto.Description,
                        Document = parkingDto.Document,
                        Id = parkingDto.Id,
                        Phone = parkingDto.Phone
                    });

                    _context.SaveChanges();
                    return true;
                }

                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
