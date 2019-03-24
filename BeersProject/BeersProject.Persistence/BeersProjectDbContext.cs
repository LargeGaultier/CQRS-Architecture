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
            //this.Database.EnsureCreated();
            this.Database.Migrate();
        }

        public virtual DbSet<Beer> Beer { get; set; }
        public virtual DbSet<BeerRating> BeerRating { get; set; }
        public virtual DbSet<Brewery> Brewery { get; set; }
        public virtual DbSet<BreweryRating> BreweryRating { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyAllConfigurations();

            modelBuilder.Entity<Brewery>().HasData(
            new Brewery
            {
                Id = 1,
                City = "Grenoble",
                Name = "Brasserie Grenobloise",
                State = "open",
            }
            );

            modelBuilder.Entity<Beer>().HasData(
            new Beer
            {
                Id = 1,
                Abv = 10,
                Name = "biere test 1",
                BreweryId = 1,
                Ibu = "test",
                Ounces = 10,
                Style = "blanche"
                
            },
            new Beer
            {
                Id = 2,
                Abv = 10,
                Name = "biere test 2",
                BreweryId = 1,
                Ibu = "test",
                Ounces = 10,
                Style = "blonde"

            }
            );

        }
    }
}
