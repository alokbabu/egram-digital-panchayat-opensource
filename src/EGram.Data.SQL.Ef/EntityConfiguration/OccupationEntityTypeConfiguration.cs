using System;
using EGram.Data.SQL.Ef.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EGram.Data.SQL.Ef.EntityConfiguration
{
    public class OccupationEntityTypeConfiguration : IEntityTypeConfiguration<Occupation>
    {
        public void Configure(EntityTypeBuilder<Occupation> builder)
        {
            builder
                .HasKey(o => o.OccupationId);

            builder.Property(p => p.Type)
                   .HasColumnType("varchar(50)");

            builder.Property(p => p.Info)
                   .HasColumnType("varchar(200)");
        }
    }
}
