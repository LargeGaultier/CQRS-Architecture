using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeersProject.Application.Beers.Commands.CreateBeer
{
    public class CreateBeerCommandValidator :  AbstractValidator<CreateBeerCommand>
    {
        public CreateBeerCommandValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
            RuleFor(x => x.Name).MaximumLength(200);
            RuleFor(x => x.Style).MaximumLength(200);
            RuleFor(x => x.BreweryId).NotEmpty();
            RuleFor(x => x.Style).NotEmpty();
            
        }
    }
}
