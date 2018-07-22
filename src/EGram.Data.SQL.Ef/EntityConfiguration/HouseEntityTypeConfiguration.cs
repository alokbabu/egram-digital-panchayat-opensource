using System;
using EGram.Data.SQL.Ef.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EGram.Data.SQL.Ef.EntityConfiguration
{
    public class HouseEntityTypeConfiguration : IEntityTypeConfiguration<House>
    {
        public void Configure(EntityTypeBuilder<House> builder)
        {
            builder.ToTable("House")
                   .HasKey(c => c.HouseId);

            builder
                .Property(p => p.HouseNumber)
                .HasColumnType("varchar(200)")
                .IsRequired();

            builder
                .Property(p => p.AddressLine)
                .HasColumnType("varchar(200)")
                .IsRequired();

            builder
                .Property(p => p.StreetAddress)
                .HasColumnType("varchar(200)")
                .IsRequired();

            builder
                .Property(p => p.PostOffice)
                .HasColumnType("varchar(200)")
                .IsRequired();

            builder
                .Property(p => p.Latitude)
                .HasColumnType("decimal(10, 6)");

            builder
                .Property(p => p.Longitude)
                .HasColumnType("decimal(10, 6)");

        }
    }
}
