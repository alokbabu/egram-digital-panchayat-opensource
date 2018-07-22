using Microsoft.EntityFrameworkCore;

namespace EGram.Data.SQL.Ef.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed<T>(this ModelBuilder modelBuilder, T[] data) where T : class
        {
            modelBuilder.Entity<T>().HasData(data);
        }
    }
}
