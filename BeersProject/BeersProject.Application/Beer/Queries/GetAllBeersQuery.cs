using BeersProject.Application.Beer.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeersProject.Application.Beer.Queries
{
    public class GetAllBeersQuery : IRequest<List<BeerDto>>
    {
    }
}
