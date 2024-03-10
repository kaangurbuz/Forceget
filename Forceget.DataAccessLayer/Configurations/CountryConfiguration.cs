using Forceget.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Forceget.DataAccessLayer.Configurations
{
    public class CountryConfiguration:IEntityTypeConfiguration<Country>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Country> builder)
        {
            builder.ToTable("Country");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Name).IsRequired().HasMaxLength(50);
        }
    }
}
