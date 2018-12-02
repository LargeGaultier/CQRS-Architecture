using BeersProject.Domain.Entities;
using BeersProject.Persistence.Extensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeersProject.Persistence
{
    public class BeersProjectDbContext : DbContext
    {
        public BeersProjectDbContext(DbContextOptions<BeersProjectDbContext> options)
        : base(options)
        {
            this.Database.EnsureCreated();
        }

        public virtual DbSet<Beer> Beer { get; set; }
        public virtual DbSet<BeerRating> BeerRating { get; set; }
        public virtual DbSet<Brewery> Brewery { get; set; }
        public virtual DbSet<BreweryRating> BreweryRating { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyAllConfigurations();
        }
    }
}
