using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PeopleAPI.Model;

namespace PeopleAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PeopleController : ControllerBase
    {
        private readonly ILogger<People> _logger;

        public PeopleController(ILogger<People> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<People> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new People()
                {
                    Email = $"Name-{rng.Next(-20, 55)}@gmail.com",
                    Name = $"Name-{rng.Next(-20, 55)}",
                    Id = rng.Next(-20, 55)
                })
                .ToArray();
        }

        [HttpPost]
        public IActionResult Post([FromBody] People people)
        {
            var rng = new Random();
            people.Id = rng.Next(-20, 55);
            return Ok(people);
        }
    }
}