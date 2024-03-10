using Forceget.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Forceget.DataAccessLayer.Configurations
{
    public class OfferConfiguration:IEntityTypeConfiguration<Offer>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Offer> builder)
        {
            builder.ToTable("Offer");
            builder.HasKey(o => o.Id);
            builder.Property(o => o.Mode).IsRequired().HasMaxLength(50);
            builder.Property(o => o.MovementType).IsRequired();
            builder.Property(o => o.Incoterm).IsRequired();
            builder.Property(o => o.Unit1).IsRequired();
            builder.Property(o => o.Unit2).IsRequired();
            builder.Property(o => o.Unit1Quantity).IsRequired();
            builder.Property(o => o.Unit2Quantity).IsRequired();
            builder.HasOne(o => o.Currency).WithMany(c => c.Offers).HasForeignKey(o => o.CurrencyId);
            builder.HasOne(o => o.City).WithMany(c => c.Offers).HasForeignKey(o => o.CityId);
            builder.HasOne(o => o.PackageType).WithMany(p => p.Offers).HasForeignKey(o => o.PackageTypeId);
        }
    }
}
