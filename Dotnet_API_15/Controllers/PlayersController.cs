using Dotnet_API_15.Entities.Dtos;
using Dotnet_API_15.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dotnet_API_15.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController(IPlayerService playerService) : ControllerBase
    {
        [HttpGet("GetAllPlayers")]
        public async Task<ActionResult<List<GetAllPlayerDto>>> GetAllPlayerDto()
        {
            var players = await playerService.GetAllPlayers();
            if(players is null)
                return BadRequest("No players found");

            return Ok(players);
        }
    }
}
