using Parking.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Infra.Interface
{
    public interface ICustomerReadRepository
    {
        List<CustomerDto> GetAll();
        CustomerDto GetById(int id);
        CustomerDto GetByReservationId(int reservationId);
    }
}
