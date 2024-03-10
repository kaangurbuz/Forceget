using Forceget.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Forceget.DataAccessLayer.Seed
{
    public class PackageTypeSeed: IEntityTypeConfiguration<PackageType>
    {
        public void Configure(EntityTypeBuilder<PackageType> builder)
        {
            builder.HasData(
                new PackageType { Id = 1, Name = "Pallets" },
                new PackageType { Id = 2, Name = "Boxes" },
                new PackageType { Id = 3, Name = "Cartons" }
                );
        }
    }
}
