using System;
using System.Collections.Generic;
using System.Text;

namespace BeersProject.Domain.Entities
{
    public class BreweryRating
    {
        public int Id { get; set; }
        public long? BreweryId { get; set; }
        public int? UserId { get; set; }
        public decimal? Rating { get; set; }
        public string Comment { get; set; }
        public Brewery Brewery { get; set; }
        public User User { get; set; }
    }
}
