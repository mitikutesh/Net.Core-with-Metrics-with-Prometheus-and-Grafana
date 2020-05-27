using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace LocationAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LocationController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Location> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new Location()
                {
                    X = rng.Next(-20, 55),
                    Y = rng.Next(-20, 55)
                })
                .ToArray();
        }
    }
}