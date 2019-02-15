using BeersProject.Application.Beers.Models;
using BeersProject.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BeersProject.Application.Beers.Queries
{
    public class GetAllBeersQueryHandler : IRequestHandler<GetAllBeersQuery, List<BeerDto>>
    {
        private readonly BeersProjectDbContext _context;

        public GetAllBeersQueryHandler(BeersProjectDbContext context)
        {
            _context = context;
        }

        public Task<List<BeerDto>> Handle(GetAllBeersQuery request, CancellationToken cancellationToken)
        {
            return _context.Beer.Include(x=> x.Brewery)
                .Select(BeerDto.Projection)
                .ToListAsync(cancellationToken);

        }
    }
}
