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
                .ToTable("Education")
                .HasKey(e => e.EducationId);

            builder
                .Property(p => p.EducationLevel)
               .HasColumnType("varchar(200)");

            builder.HasData(SeedEducation());
            
        }

        private List<Education> SeedEducation()
        {
            return new List<Education>
            {
                new Education { EducationLevel = "Basic School" },
                new Education { EducationLevel = "High School" },
                new Education { EducationLevel = "Predegree/Diploma" },
                new Education { EducationLevel = "Graduate" },
                new Education { EducationLevel = "Post Graduate" },
                new Education { EducationLevel = "Doctorate or Higher" }
            };
        }


    }
}
