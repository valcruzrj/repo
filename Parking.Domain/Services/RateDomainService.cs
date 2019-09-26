using Parking.Domain.Interface;
using Parking.Dto;

namespace Parking.Domain.Services
{
    public class RateDomainService : IRateDomainService
    {
        private ParkingDataContext _context { get; set; }

        public RateDomainService(ParkingDataContext context)
        {
            _context = context;
        }

        public bool Create(RateDto rateDto)
        {
            try
            {
                _context.Rates.Add(new Rate()
                {
                    Description = rateDto.Description,
                    DailyAmount = rateDto.DailyAmount,
                    HourAmount = rateDto.HourAmount,
                    OvernightAmount = rateDto.OvernightAmount
                });

                _context.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public decimal GenerateAmountByType(RateDto rate, int type)
        {
            // Calcula o periodo de acordo com o tipo
            
            return (type == 0 ? rate.DailyAmount :
                        type == 1 ? rate.OvernightAmount :
                          type == 2 ? rate.HourAmount : rate.DailyAmount);
        }
    }
}
