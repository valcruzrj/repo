using Parking.Domain.Entities;
using Parking.Domain.Interface;
using Parking.Dto;
using System;
using System.Collections.Generic;
using System.Domain.Extensions;
using System.Text;

namespace Parking.Domain.Services
{
    public class ReservationDomainService : IReservationDomainService
    {
        private ParkingDataContext _context { get; set; }

        public ReservationDomainService(ParkingDataContext context)
        {
            _context = context;
        }

        public bool Post(ReservationDto reservationDto)
        {
            try
            {
                var reservation = new Reservation()
                {
                    Status = reservationDto.Status,
                    Type = reservationDto.Type,
                    StartDate = reservationDto.StartDate,
                    CarId = reservationDto.CarId
                };

                if (reservationDto.Associate != null)
                    reservation.AssociateId = reservationDto.AssociateId.TryParseToInt32();

                if (reservationDto.Customer != null)
                    reservation.CustomerId = reservationDto.CustomerId.TryParseToInt32();

                _context.Reservations.Add(reservation);

                _context.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateStatus(ReservationDto reservationDto, int statusId)
        {
            try
            {
                _context.Reservations.Update(new Reservation()
                {
                    Id = reservationDto.Id,
                    Status = statusId,
                    AssociateId = reservationDto.AssociateId,
                    Car = new Car()
                    {
                        Id = reservationDto.Car.Id,
                        Color = reservationDto.Car.Color,
                        LicensePlate = reservationDto.Car.LicensePlate,
                        Model = reservationDto.Car.Model,
                        Year = reservationDto.Car.Year
                    },
                    CustomerId = reservationDto.CustomerId,
                    Type = reservationDto.Type,
                    StartDate = reservationDto.StartDate,
                    FinalDate = statusId == 1 ? DateTime.Now : default(DateTime)
                });

                _context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
