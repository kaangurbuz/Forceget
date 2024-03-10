using Forceget.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Forceget.DataAccessLayer.Configurations
{
    public class PackageTypeConfiguration:IEntityTypeConfiguration<PackageType>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<PackageType> builder)
        {
            builder.ToTable("PackageType");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).IsRequired().HasMaxLength(50);
        }
    }
}
