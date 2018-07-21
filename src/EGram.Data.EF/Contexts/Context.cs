using System;
using EGram.Data.EF.EntityConfiguration;
using EGram.Data.EF.Models;
using Microsoft.EntityFrameworkCore;

namespace EGram.Data.EF.Contexts
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
        }

        public DbSet<Survey> Surveys { get; set;}

    }
}
