﻿// <auto-generated />
using System;
using EmployeeManagement.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EmployeeManagement.Migrations
{
    [DbContext(typeof(EmployeeDbContext))]
    [Migration("20250310100133_SeedEmployeeDataTotable")]
    partial class SeedEmployeeDataTotable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EmployeeManagement.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateOnly>("DateOfJoining")
                        .HasColumnType("date");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Designation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateOfJoining = new DateOnly(2020, 6, 15),
                            Department = "IT",
                            Designation = "Software Developer",
                            Name = "John Smith"
                        },
                        new
                        {
                            Id = 2,
                            DateOfJoining = new DateOnly(2018, 3, 22),
                            Department = "IT",
                            Designation = "Project Manager",
                            Name = "Sarah Johnson"
                        },
                        new
                        {
                            Id = 3,
                            DateOfJoining = new DateOnly(2019, 9, 10),
                            Department = "HR",
                            Designation = "HR Manager",
                            Name = "James Brown"
                        },
                        new
                        {
                            Id = 4,
                            DateOfJoining = new DateOnly(2021, 12, 5),
                            Department = "Marketing",
                            Designation = "Marketing Specialist",
                            Name = "Emily Davis"
                        },
                        new
                        {
                            Id = 5,
                            DateOfJoining = new DateOnly(2022, 1, 30),
                            Department = "Analytics",
                            Designation = "Data Analyst",
                            Name = "Michael Wilson"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
