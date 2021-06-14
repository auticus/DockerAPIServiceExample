using System;
using System.Collections.Generic;
using Gaming.api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Gaming.api.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class GamingController
    {
        private readonly ILogger<GamingController> _logger;

        public GamingController(ILogger<GamingController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Game> GetAllGames()
        {
            _logger.LogInformation("Getting all games");
            var returnList = new List<Game>
            {
                new Game() {Name = "Savage Worlds", Rating = "6.8", ReleaseDate = DateTime.Parse("12/10/2017")},
                new Game() {Name = "Madden NFL 2019", Rating = "5.4", ReleaseDate = DateTime.Parse("12/15/2018")},
                new Game() {Name = "Sea of Thieves", Rating = "8.7", ReleaseDate = DateTime.Parse("03/05/2018")},
                new Game() {Name = "Donkey Express", Rating = "2.1", ReleaseDate = DateTime.Parse("09/10/2013")}
            };

            return returnList;
        }
    }
}
