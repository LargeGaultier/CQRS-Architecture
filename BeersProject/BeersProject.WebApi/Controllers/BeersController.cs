using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using BeersProject.Application.Beers.Commands.CreateBeer;
using BeersProject.Application.Beers.Models;
using BeersProject.Application.Beers.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BeersProject.WebApi.Controllers
{
    public class BeersController : BaseController
    {
        [HttpGet]
        [Route("/api/Beers")]
        [ProducesResponseType(typeof(IEnumerable<BeerDto>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> Get()
        {
            return Ok(await Mediator.Send(new GetAllBeersQuery()));
        }

        [HttpPost]
        [Route("/api/Beers")]
        [ProducesResponseType(typeof(Unit), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> Post([FromBody] CreateBeerCommand command)
        {
            return Ok(await Mediator.Send(command));
        }
    }
}