using Microsoft.EntityFrameworkCore;
using Parking.Domain.Entities;
using Parking.Domain.Maps;

namespace Parking.Domain
{
    public class ParkingDataContext : DbContext
    {
        public DbSet<Parking> Parking { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Rate> Rates { get; set; }
        public DbSet<Agreement> Agreements { get; set; }
        public DbSet<Associate> Associates { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=localhost,1433;Database=parking.database.teste;User ID=sa;Password=cm@123456789;");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new AgreementMap());
            builder.ApplyConfiguration(new AssociateMap());
            builder.ApplyConfiguration(new CarMap());
            builder.ApplyConfiguration(new CustomerMap());
            builder.ApplyConfiguration(new ParkingMap());
            builder.ApplyConfiguration(new RateMap());
            builder.ApplyConfiguration(new ReservationMap());

        }
    }
}