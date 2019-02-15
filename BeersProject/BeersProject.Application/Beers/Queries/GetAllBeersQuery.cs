using BeersProject.Application.Beers.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeersProject.Application.Beers.Queries
{
    public class GetAllBeersQuery : IRequest<List<BeerDto>>
    {
    }
}
