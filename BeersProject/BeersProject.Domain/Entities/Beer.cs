using System;
using System.Collections.Generic;
using System.Text;

namespace BeersProject.Domain.Entities
{
    public class Beer
    {
        public Beer()
        {
            BeerRating = new HashSet<BeerRating>();
        }
        public decimal? Abv { get; set; }
        public string Ibu { get; set; }
        public long Id { get; set; }
        public string Name { get; set; }
        public string Style { get; set; }
        public long BreweryId { get; set; }
        public decimal? Ounces { get; set; }
        public Brewery Brewery { get; set; }
        public ICollection<BeerRating> BeerRating { get; set; }
    }

}
