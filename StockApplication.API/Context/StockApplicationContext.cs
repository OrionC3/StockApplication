using Microsoft.EntityFrameworkCore;
using StockApplication.API.Entities;

namespace StockApplication.API.Context
{
    public class StockApplicationContext : DbContext
    {
        public StockApplicationContext(DbContextOptions<StockApplicationContext> options) : base(options) { }

        public DbSet<Item> Item => Set<Item>();
        public DbSet<NetworkSpecs> NetworkSpecs => Set<NetworkSpecs>();
        public DbSet<HardwareSpecs> HardwareSpecs => Set<HardwareSpecs>();
    }
}
