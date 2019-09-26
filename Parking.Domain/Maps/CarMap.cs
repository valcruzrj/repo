using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Parking.Domain.Maps
{
    public class CarMap : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.ToTable("Car");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.LicensePlate).IsRequired().HasMaxLength(200).HasColumnType("varchar(200)");
            builder.Property(x => x.Model).IsRequired().HasMaxLength(100).HasColumnType("varchar(100)");
            builder.Property(x => x.Color).HasMaxLength(50).HasColumnType("varchar(50)");
            builder.Property(x => x.Year);
        }
    }
}