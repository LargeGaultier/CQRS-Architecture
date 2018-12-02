using BeersProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeersProject.Persistence.Configuration
{
    public class BeerConfiguration : IEntityTypeConfiguration<Beer>
    {
        public void Configure(EntityTypeBuilder<Beer> builder)
        {
            builder.HasOne(d => d.Brewery)
                    .WithMany(p => p.Beer)
                    .HasForeignKey(d => d.BreweryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_brewery_id");

        }
    }
}
