﻿// <auto-generated />
using System;
using Amaryllis.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Amaryllis.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20190313084432_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Amaryllis.Models.Cars.Car", b =>
                {
                    b.Property<long>("CarId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("CarClassId");

                    b.Property<long?>("ModelCarModelId");

                    b.Property<string>("RegistrationNumber");

                    b.Property<long?>("WhoManufacturerCarId");

                    b.Property<int>("YearOfIssue");

                    b.HasKey("CarId");

                    b.HasIndex("CarClassId");

                    b.HasIndex("ModelCarModelId");

                    b.HasIndex("WhoManufacturerCarId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("Amaryllis.Models.Cars.CarAttributes.CarClass", b =>
                {
                    b.Property<long>("CarClassId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClassName");

                    b.HasKey("CarClassId");

                    b.ToTable("CarClasses");
                });

            modelBuilder.Entity("Amaryllis.Models.Cars.CarAttributes.CarModel", b =>
                {
                    b.Property<long>("CarModelId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Model");

                    b.HasKey("CarModelId");

                    b.ToTable("CarModels");
                });

            modelBuilder.Entity("Amaryllis.Models.Cars.CarAttributes.WhoManufacturerCar", b =>
                {
                    b.Property<long>("WhoManufacturerCarId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("WhoManufacturer");

                    b.HasKey("WhoManufacturerCarId");

                    b.ToTable("Manufacturers");
                });

            modelBuilder.Entity("Amaryllis.Models.Orders.Order", b =>
                {
                    b.Property<long>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("CarId");

                    b.Property<string>("Comment");

                    b.Property<DateTime>("EndOfRental");

                    b.Property<DateTime>("StartOfRental");

                    b.Property<long?>("UserId");

                    b.HasKey("OrderId");

                    b.HasIndex("CarId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Amaryllis.Models.Users.User", b =>
                {
                    b.Property<long>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("DlNumber");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Amaryllis.Models.Cars.Car", b =>
                {
                    b.HasOne("Amaryllis.Models.Cars.CarAttributes.CarClass", "CarClass")
                        .WithMany()
                        .HasForeignKey("CarClassId");

                    b.HasOne("Amaryllis.Models.Cars.CarAttributes.CarModel", "Model")
                        .WithMany()
                        .HasForeignKey("ModelCarModelId");

                    b.HasOne("Amaryllis.Models.Cars.CarAttributes.WhoManufacturerCar", "WhoManufacturerCar")
                        .WithMany()
                        .HasForeignKey("WhoManufacturerCarId");
                });

            modelBuilder.Entity("Amaryllis.Models.Orders.Order", b =>
                {
                    b.HasOne("Amaryllis.Models.Cars.Car", "Car")
                        .WithMany()
                        .HasForeignKey("CarId");

                    b.HasOne("Amaryllis.Models.Users.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
