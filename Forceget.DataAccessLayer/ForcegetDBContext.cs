using Forceget.Core.Models;
using Forceget.DataAccessLayer.Seed;
using Microsoft.EntityFrameworkCore;

namespace Forceget.DataAccessLayer
{
    public class ForcegetDBContext : DbContext
    {
        public ForcegetDBContext(DbContextOptions<ForcegetDBContext> options) : base (options)
        {
            
        }
        
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<PackageType> PackageTypes { get; set; }
        public DbSet<Offer> Offers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new Configurations.CountryConfiguration());
            modelBuilder.ApplyConfiguration(new CountrySeed());
            modelBuilder.ApplyConfiguration(new Configurations.CityConfiguration());
            modelBuilder.ApplyConfiguration(new CitySeed());
            modelBuilder.ApplyConfiguration(new Configurations.CurrencyConfiguration());
            modelBuilder.ApplyConfiguration(new CurrencySeed());
            modelBuilder.ApplyConfiguration(new Configurations.PackageTypeConfiguration());
            modelBuilder.ApplyConfiguration(new PackageTypeSeed());
            modelBuilder.ApplyConfiguration(new Configurations.OfferConfiguration());

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
        }
    }
}
