using Forceget.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forceget.DataAccessLayer.Seed
{
    public class CitySeed : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasData(
                new City() { Id = 1, Name = "New York", CountryId = 1 },
                new City() { Id = 2, Name = "Los Angeles", CountryId = 1 },
                new City() { Id = 3, Name = "Miami", CountryId = 1 },
                new City() { Id = 4, Name = "Minnesota", CountryId = 1 },
                new City() { Id = 5, Name = "Beijing", CountryId = 2 },
                new City() { Id = 6, Name = "Shanghai", CountryId = 2 },
                new City() { Id = 7, Name = "Istanbul", CountryId = 3 },
                new City() { Id = 8, Name = "Izmir", CountryId = 3 }
                );
        }
    }
}
