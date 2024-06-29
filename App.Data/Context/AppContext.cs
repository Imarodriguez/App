

using App.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace App.Data.Context
{
    public class AppContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("AppDb");
        }

        public DbSet<Category> Categories { get; set; }

    }
}
