using System;
using System.Collections.Generic;
using System.Text;

namespace BeersProject.Domain.Entities
{
    public class BeerRating
    {
        public int Id { get; set; }
        public long? BeerId { get; set; }
        public int? UserId { get; set; }
        public decimal? Rating { get; set; }
        public string Comment { get; set; }

        public Beer Beer { get; set; }
        public User User { get; set; }
    }
}
