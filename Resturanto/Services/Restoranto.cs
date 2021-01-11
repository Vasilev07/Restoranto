using System.Data.Entity;
using Resturanto.Models;

namespace Resturanto.Services
{
    public class Restoranto : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }

        public DbSet<Table> Table { get; set; }
    }
}
