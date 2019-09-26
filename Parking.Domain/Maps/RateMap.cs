﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Parking.Domain.Maps
{
    public class RateMap : IEntityTypeConfiguration<Rate>
    {
        public void Configure(EntityTypeBuilder<Rate> builder)
        {
            builder.ToTable("Rate");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Description).IsRequired().HasMaxLength(200).HasColumnType("varchar(200)");
            builder.Property(x => x.DailyAmount).IsRequired().HasColumnType("money");
            builder.Property(x => x.OvernightAmount).HasColumnType("money");
            builder.Property(x => x.HourAmount).HasColumnType("money");
        }
    }
}