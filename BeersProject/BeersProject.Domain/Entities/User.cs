using System;
using System.Collections.Generic;
using System.Text;

namespace BeersProject.Domain.Entities
{
   public class User
    {
        public User()
        {
            BeerRating = new HashSet<BeerRating>();
            BreweryRating = new HashSet<BreweryRating>();
        }
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string Avatar { get; set; }
        public ICollection<BeerRating> BeerRating { get; set; }
        public ICollection<BreweryRating> BreweryRating { get; set; }
    }
}
