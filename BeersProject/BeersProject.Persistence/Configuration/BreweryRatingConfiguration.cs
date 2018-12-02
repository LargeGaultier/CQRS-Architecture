using BeersProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeersProject.Persistence.Configuration
{
    public class BreweryRatingConfiguration : IEntityTypeConfiguration<BreweryRating>
    {
        public void Configure(EntityTypeBuilder<BreweryRating> builder)
        {
            builder.HasOne(d => d.Brewery)
                    .WithMany(p => p.BreweryRating)
                    .HasForeignKey(d => d.BreweryId)
                    .HasConstraintName("fk_brewery_rating_brewery");

            builder.HasOne(d => d.User)
                .WithMany(p => p.BreweryRating)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("fk_brewery_rating_user");
        }
    }
}
