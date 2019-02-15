using System;
using System.Linq.Expressions;
using BeersProject.Domain.Entities;

namespace BeersProject.Application.Beers.Models
{
    public class BeerDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string BreweryName { get; set; }
        public string Color { get; set; }
        public string City { get; set; }

        public static Expression<Func<Domain.Entities.Beer, BeerDto>> Projection
        {
            get
            {
                return b => new BeerDto
                {
                    BreweryName = b.Brewery.Name,
                    Name = b.Name,
                    City = b.Brewery.City,
                    Color = b.Ibu,
                    Id = b.Id
                };
            }
        }
    }
}
