using Dotnet_API_15.Data;
using Dotnet_API_15.Entities.Dtos;
using Dotnet_API_15.Entities.Models;
using Dotnet_API_15.Service.CacheService;
using Microsoft.EntityFrameworkCore;

namespace Dotnet_API_15.Service
{
    public class PlayerService(PlayerDbContext _context,ICacheService cache) : IPlayerService
    {
        public async Task<List<GetAllPlayerDto>> GetAllPlayers()
        {
            return await cache.GetOrSetAsync
                ("player_list",
                async ()=>
                {
                    await Task.Delay(5000);

                    var players = await _context.Players
                    .Select(s => new GetAllPlayerDto
                     {
                    PlayerName = s.PlayerName,
                    PlayerEmail = s.PlayerEmail,
                    IsPlaying = s.IsPlaying
                        }).ToListAsync();

                return players;
            },
                TimeSpan.FromMinutes(5)
                );
        }
    }
}
