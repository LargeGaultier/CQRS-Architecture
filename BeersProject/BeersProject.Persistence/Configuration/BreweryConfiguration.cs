using BeersProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeersProject.Persistence.Configuration
{
    public class BreweryConfiguration : IEntityTypeConfiguration<Brewery>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Brewery> builder)
        {
            // Method intentionally left empty.
        }
    }
}
