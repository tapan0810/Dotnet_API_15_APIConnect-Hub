using Caller_API_for_API_15.Entities;
using Caller_API_for_API_15.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Caller_API_for_API_15.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerApiController(IPlayerApiService playerApiService) : ControllerBase
    {
        [HttpGet("GetAllPlayersFromApi")]
        public async Task<ActionResult<List<PlayerDto>>> GetAllPlayer()
        {
            var players = await playerApiService.GetPlayersFromApiAsyncGeaL();

            if(players is null || players.Count == 0)
                return NotFound("No players found.");

            return Ok(players);
        }

    }
}
