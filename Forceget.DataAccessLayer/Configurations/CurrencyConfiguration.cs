using Forceget.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Forceget.DataAccessLayer.Configurations
{
    public class CurrencyConfiguration:IEntityTypeConfiguration<Currency>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Currency> builder)
        {
            builder.ToTable("Currency");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Name).IsRequired().HasMaxLength(50);
            builder.Property(c => c.ShortName).IsRequired().HasMaxLength(3);
        }
    }
}
