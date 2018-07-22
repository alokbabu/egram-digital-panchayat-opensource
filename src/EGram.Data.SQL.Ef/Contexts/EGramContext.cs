using EGram.Data.SQL.Ef.EntityConfiguration;
using EGram.Data.SQL.Ef.Extensions;
using EGram.Data.SQL.Ef.Models;
using EGram.Data.SQL.Ef.Seeds;
using Microsoft.EntityFrameworkCore;

namespace EGram.Data.SQL.Ef.Contexts
{
    public class EGramContext: DbContext
    {
        public EGramContext(DbContextOptions<EGramContext> options)
            :base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SurveyEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new BloodGroupEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new HouseEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new OccupationEntityTypeConfiguration());

            modelBuilder.Seed(BloodGroupSeed.Get());
            modelBuilder.Seed(EducationSeed.Get());
            modelBuilder.Seed(HouseSeed.Get());
            modelBuilder.Seed(OccupationSeed.Get());
            
        }

        public DbSet<House> Houses { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Occupation> Occupations { get; set; }
        public DbSet<BloodGroup> BloodGroups { get; set; }
        public DbSet<Survey> Surveys { get; set; }


    }
}
