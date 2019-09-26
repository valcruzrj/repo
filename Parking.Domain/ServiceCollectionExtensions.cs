using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Parking.Domain.Interface;
using Parking.Domain.Services;
using Parking.Dto;
using Parking.Dto.Validation;

namespace Parking.Domain
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDomain(this IServiceCollection services)
        {
            services.AddScoped<ParkingDataContext, ParkingDataContext>();

            services.AddTransient<IAgreementDomainService, AgreementDomainService>();
            services.AddTransient<IParkingDomainService, ParkingDomainService>();
            services.AddTransient<IAssociateDomainService, AssociateDomainService>();
            services.AddTransient<ICarDomainService, CarDomainService>();
            services.AddTransient<ICustomerDomainService, CustomerDomainService>();
            services.AddTransient<IRateDomainService, RateDomainService>();
            services.AddTransient<IReservationDomainService, ReservationDomainService>();

            services.AddTransient<IValidator<ParkingDto>, ParkingValidator>();
            services.AddTransient<IValidator<AgreementDto>, AgreementValidator>();
            services.AddTransient<IValidator<AssociateDto>, AssociateValidator>();
            services.AddTransient<IValidator<CarDto>, CarValidator>();
            services.AddTransient<IValidator<CustomerDto>, CustomerValidator>();
            services.AddTransient<IValidator<RateDto>, RateValidator>();
            services.AddTransient<IValidator<ReservationDto>, ReservationValidator>();

            return services;
        }
    }
}
