﻿// <auto-generated />
using System;
using EventRegistration.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EventRegistration.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250306201413_FixSeeding")]
    partial class FixSeeding
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EventRegistration.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AdditionalRequest")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("DateRegistered")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("SelectedDays")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clients");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            AdditionalRequest = "Vegetarian meal",
                            DateRegistered = new DateTime(2019, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "alice@example.com",
                            Gender = "F",
                            Name = "Alice Johnson",
                            SelectedDays = "Day 1, Day 3"
                        },
                        new
                        {
                            Id = -2,
                            AdditionalRequest = "Need wheelchair access",
                            DateRegistered = new DateTime(2019, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "bob@example.com",
                            Gender = "M",
                            Name = "Bob Smith",
                            SelectedDays = "Day 2"
                        },
                        new
                        {
                            Id = -3,
                            AdditionalRequest = "No special request",
                            DateRegistered = new DateTime(2019, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "charlie@example.com",
                            Gender = "M",
                            Name = "Charlie Brown",
                            SelectedDays = "Day 1, Day 2"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
