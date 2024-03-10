using Forceget.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Forceget.DataAccessLayer.Seed
{
    public class CurrencySeed : IEntityTypeConfiguration<Currency>
    {
        public void Configure(EntityTypeBuilder<Currency> builder)
        {
            builder.HasData(
                new Currency { Id = 1, Name = "US Dollar", ShortName = "USD" },
                new Currency { Id = 2, Name = "Chinese Yuan", ShortName = "CNY" },
                new Currency { Id = 3, Name = "Turkish Lira", ShortName = "TRY" }
                );
        }
    }
}
