using Forceget.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Forceget.DataAccessLayer.Seed
{
    public class CountrySeed : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasData(
                new Country { Id = 1, Name = "USA" },
                new Country { Id = 2, Name = "China" },
                new Country { Id = 3, Name = "Turkey" }
                );
        }
    }
}
