﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Parking.Domain;

namespace Parking.Domain.Migrations
{
    [DbContext(typeof(ParkingDataContext))]
    partial class ParkingDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Parking.Domain.Agreement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(120)")
                        .HasMaxLength(200);

                    b.Property<decimal>("DiscountAmount")
                        .HasColumnType("money");

                    b.Property<double>("DiscountPercentual");

                    b.HasKey("Id");

                    b.ToTable("Agreement");
                });

            modelBuilder.Entity("Parking.Domain.Associate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AgreementId");

                    b.Property<int?>("CustomerId");

                    b.Property<int>("Quantity");

                    b.Property<int?>("RateId");

                    b.HasKey("Id");

                    b.HasIndex("AgreementId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("RateId");

                    b.ToTable("Associate");
                });

            modelBuilder.Entity("Parking.Domain.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Color")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("LicensePlate")
                        .IsRequired()
                        .HasColumnType("varchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime>("Year");

                    b.HasKey("Id");

                    b.ToTable("Car");
                });

            modelBuilder.Entity("Parking.Domain.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(120)")
                        .HasMaxLength(200);

                    b.Property<string>("Document")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("Parking.Domain.Parking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("varchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Document")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Phone")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Parking");
                });

            modelBuilder.Entity("Parking.Domain.Rate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("DailyAmount")
                        .HasColumnType("money");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(200)")
                        .HasMaxLength(200);

                    b.Property<decimal>("HourAmount")
                        .HasColumnType("money");

                    b.Property<decimal>("OvernightAmount")
                        .HasColumnType("money");

                    b.HasKey("Id");

                    b.ToTable("Rate");
                });

            modelBuilder.Entity("Parking.Domain.Associate", b =>
                {
                    b.HasOne("Parking.Domain.Agreement", "Agreement")
                        .WithMany()
                        .HasForeignKey("AgreementId");

                    b.HasOne("Parking.Domain.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId");

                    b.HasOne("Parking.Domain.Rate", "Rate")
                        .WithMany()
                        .HasForeignKey("RateId");
                });
#pragma warning restore 612, 618
        }
    }
}
