using Parking.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Domain.Interface
{
    public interface IReservationDomainService
    {
        bool Post(ReservationDto reservationDto);
        bool UpdateStatus(ReservationDto reservationDto, int statusId);
    }
}
