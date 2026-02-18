using Dotnet_API_15.Data;
using Dotnet_API_15.Entities.Dtos;
using Dotnet_API_15.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Dotnet_API_15.Service
{
    public class PlayerService(PlayerDbContext _context) : IPlayerService
    {
        public async Task<List<GetAllPlayerDto>> GetAllPlayers()
        {
            var players = await  _context.Players
                .Select(s => new GetAllPlayerDto
                {
                    PlayerName = s.PlayerName,
                    PlayerEmail = s.PlayerEmail,
                    IsPlaying = s.IsPlaying
                }).ToListAsync();

            if (players is null)
                return null;

            return players;
        }
    }
}
