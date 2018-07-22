using System;
using EGram.Data.SQL.Ef.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EGram.Data.SQL.Ef.EntityConfiguration
{
    public class PersonEntityTypeConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder
                .HasKey(p => p.PersonId);

            builder
                .Property(p => p.Firstname)
                .HasColumnType("varchar(200)");

            builder
                .Property(p => p.Lastname)
                .HasColumnType("varchar(200)");

            builder
                .Property(p => p.Email)
                .HasColumnType("varchar(100)");
            
            builder
                .Property(p => p.MobileNumber)
                 .HasColumnType("varchar(10)");
            
            //Education
            builder
                .HasOne(person => person.Education)
                .WithOne(education => education.Person)
                .HasForeignKey<Person>(personEducation => personEducation.EducationId);

            //Occupation
            builder
                .HasOne(person => person.Occupation)
                .WithOne(occupation => occupation.Person)
                .HasForeignKey<Person>(personOccupation => personOccupation.OccupationId);

            //BloodGroup
            builder.HasOne(person => person.BloodGroup)
                   .WithOne(bloodGroup => bloodGroup.Person)
                   .HasForeignKey<Person>(personBloodGroup => personBloodGroup.BloodGroupId);


        }
    }
}
