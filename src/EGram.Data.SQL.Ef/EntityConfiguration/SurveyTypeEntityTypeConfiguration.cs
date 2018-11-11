using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using EGram.Data.SQL.Ef.Models;

public class SurveyTypeEntityTypeConfiguration : IEntityTypeConfiguration<SurveyType>
{
    public void Configure(EntityTypeBuilder<SurveyType> builder)
    {
        builder
        .HasIndex(s => s.SurveyTypeId)
        .IsUnique();
    }
}
