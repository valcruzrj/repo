using Parking.Dto;

namespace Parking.Application.Interface
{
    public interface IRateAppService
    {
        bool Create(RateDto rateDto);
    }
}
