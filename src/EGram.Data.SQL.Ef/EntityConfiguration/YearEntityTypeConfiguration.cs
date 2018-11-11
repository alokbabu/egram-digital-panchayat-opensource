using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using EGram.Data.SQL.Ef.Models;

namespace EGram.Data.SQL.Ef.EntityConfiguration
{
    public class YearEntityTypeConfiguration: IEntityTypeConfiguration<Year>
    {
        public void Configure(EntityTypeBuilder<Year> builder)
        {
            builder
            .HasIndex(s => s.YearId)
            .IsUnique();
        }
    }
}
