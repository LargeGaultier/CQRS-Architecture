using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeersProject.Application.Beers.Commands.CreateBeer
{
    public class CreateBeerCommand : IRequest
    {
        public decimal? Abv { get; set; }
        public string Ibu { get; set; }
        public long Id { get; set; }
        public string Name { get; set; }
        public string Style { get; set; }
        public long BreweryId { get; set; }
        public decimal? Ounces { get; set; }
    }
}
