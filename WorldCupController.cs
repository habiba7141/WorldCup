using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WorldCupApi.Models;

namespace WorldCupApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorldCupController : ControllerBase
    {
        private readonly WorldCupHandler _worldCupHandler;
        public WorldCupController(WorldCupHandler worldCupHandler)
        {
            this._worldCupHandler = worldCupHandler;    
        }
        [HttpGet("{year}")]
        public IActionResult GetWinner( int year)
        {
            var winner = _worldCupHandler.GetTeam(year);
            return Ok(winner);
        }
    }
}
