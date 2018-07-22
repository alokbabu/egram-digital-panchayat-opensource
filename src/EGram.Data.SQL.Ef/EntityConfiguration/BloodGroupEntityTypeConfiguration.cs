using System;
using System.Collections.Generic;
using EGram.Data.SQL.Ef.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EGram.Data.SQL.Ef.EntityConfiguration
{
    public class BloodGroupEntityTypeConfiguration : IEntityTypeConfiguration<BloodGroup>
    {
        public void Configure(EntityTypeBuilder<BloodGroup> builder)
        {
            builder
                .HasKey(b => b.BloodGroupId);

            builder
                .Property(p => p.Group)
                .HasColumnType("varchar(200)");

        }

    }
}
