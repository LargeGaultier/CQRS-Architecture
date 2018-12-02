using System;
using System.Collections.Generic;
using System.Text;

namespace BeersProject.Domain.Entities
{
    public partial class Brewery
    {
        public Brewery()
        {
            Beer = new HashSet<Beer>();
            BreweryRating = new HashSet<BreweryRating>();
        }
        public long Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public ICollection<Beer> Beer { get; set; }
        public ICollection<BreweryRating> BreweryRating { get; set; }
    }
}
