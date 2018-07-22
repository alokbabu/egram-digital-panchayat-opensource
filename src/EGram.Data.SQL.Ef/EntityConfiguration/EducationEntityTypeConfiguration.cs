using System;
using System.Collections.Generic;
using EGram.Data.SQL.Ef.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EGram.Data.SQL.Ef.EntityConfiguration
{
    public class EducationEntityTypeConfiguration : IEntityTypeConfiguration<Education>
    {
        public void Configure(EntityTypeBuilder<Education> builder)
        {
            builder
                .HasKey(e => e.EducationId);

            builder
                .Property(p => p.EducationLevel)
               .HasColumnType("varchar(200)");

        }

    }
}
