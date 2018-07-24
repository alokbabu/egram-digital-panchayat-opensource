using System;
using EGram.Data.SQL.Ef.EntityConfiguration;
using EGram.Data.SQL.Ef.Extensions;
using EGram.Data.SQL.Ef.Identity.Models;
using EGram.Data.SQL.Ef.Models;
using EGram.Data.SQL.Ef.Seeds;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EGram.Data.SQL.Ef.Contexts
{
    public class EGramContext: IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public EGramContext(DbContextOptions<EGramContext> options)
            :base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<ApplicationUser>().Property(p => p.Id).ValueGeneratedOnAdd();

            builder.ApplyConfiguration(new SurveyEntityTypeConfiguration());
            builder.ApplyConfiguration(new BloodGroupEntityTypeConfiguration());
            builder.ApplyConfiguration(new HouseEntityTypeConfiguration());
            builder.ApplyConfiguration(new OccupationEntityTypeConfiguration());

            builder.Seed(BloodGroupSeed.Get());
            builder.Seed(EducationSeed.Get());
            builder.Seed(HouseSeed.Get());
            builder.Seed(OccupationSeed.Get());
            
        }

        public DbSet<House> Houses { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Occupation> Occupations { get; set; }
        public DbSet<BloodGroup> BloodGroups { get; set; }
        public DbSet<Survey> Surveys { get; set; }


    }
}
