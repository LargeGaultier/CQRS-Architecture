using BeersProject.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BeersProject.Domain.Entities;

namespace BeersProject.Application.Beers.Commands.CreateBeer
{
    public class CreateBeerCommandHandler : IRequestHandler<CreateBeerCommand, Unit>
    {
        private readonly BeersProjectDbContext _context;
        
        public CreateBeerCommandHandler(
            BeersProjectDbContext context
           )
        {
            _context = context;
        }

        public async Task<Unit> Handle(CreateBeerCommand request, CancellationToken cancellationToken)
        {
            Beer entity = new Beer()
            {
                Id = request.Id,
                Abv = request.Abv,
                BreweryId = request.BreweryId,
                Ibu = request.Ibu,
                Name = request.Name,
                Ounces = request.Ounces,
                Style = request.Style
            };
        
            _context.Beer.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
