﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BookingTravel.Models.BookingTravelModels
{
    public partial class BookingTravelContext : DbContext
    {
        public BookingTravelContext()
        {
        }

        public BookingTravelContext(DbContextOptions<BookingTravelContext> options)
            : base(options)
        {
        }

        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Country> Country { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>(entity =>
            {
                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.Citycode).HasColumnName("CITYCODE");

                entity.Property(e => e.Cityname).HasColumnName("CITYNAME");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.Countryarea).HasColumnName("COUNTRYAREA");

                entity.Property(e => e.Countrycode).HasColumnName("COUNTRYCODE");

                entity.Property(e => e.Countryname).HasColumnName("COUNTRYNAME");

                entity.Property(e => e.Flagimage).HasColumnName("FLAGIMAGE");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}