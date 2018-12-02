using BeersProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeersProject.Persistence.Configuration
{
    public class BeerRatingConfiguration : IEntityTypeConfiguration<BeerRating>
    {
        public void Configure(EntityTypeBuilder<BeerRating> builder)
        {
            builder.HasOne(d => d.Beer)
                   .WithMany(p => p.BeerRating)
                   .HasForeignKey(d => d.BeerId)
                   .HasConstraintName("fk_beer_id");

            builder.HasOne(d => d.User)
                .WithMany(p => p.BeerRating)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("fk_user_id");
        }
    }
}
