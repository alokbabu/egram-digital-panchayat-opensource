using EGram.Data.SQL.Ef.EntityConfiguration;
using EGram.Data.SQL.Ef.Extensions;
using EGram.Data.SQL.Ef.Models;
using EGram.Data.SQL.Ef.Seeds;
using Microsoft.EntityFrameworkCore;

namespace EGram.Data.SQL.Ef.Contexts
{
    public class Context: DbContext
    {
        public Context(DbContextOptions<Context> options)
            :base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SurveyEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new BloodGroupEntityTypeConfiguration());

            modelBuilder.Seed(BloodGroupSeed.Get());
            modelBuilder.Seed(EducationSeed.Get());
            
        }

        //public DbSet<House> Houses { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<BloodGroup> BloodGroups { get; set; }
        public DbSet<Survey> Surveys { get; set; }


    }
}
