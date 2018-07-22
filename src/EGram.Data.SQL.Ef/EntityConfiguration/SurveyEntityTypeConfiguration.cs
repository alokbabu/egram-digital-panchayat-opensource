using System;
using EGram.Data.EF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EGram.Data.EF.EntityConfiguration
{
    public class SurveyEntityTypeConfiguration : IEntityTypeConfiguration<Survey>
    {
        public void Configure(EntityTypeBuilder<Survey> builder)
        {
            builder
            .HasIndex(s => s.YearId)
            .IsUnique();
        }
    }
}
