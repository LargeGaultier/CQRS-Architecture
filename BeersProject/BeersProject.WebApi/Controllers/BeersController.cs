using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using BeersProject.Application.Beer.Models;
using BeersProject.Application.Beer.Queries;
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

       
    }
}