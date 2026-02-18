using Dotnet_API_15.Entities.Dtos;
using Dotnet_API_15.Entities.Models;

namespace Dotnet_API_15.Service
{
    public interface IPlayerService
    {
        public Task<List<GetAllPlayerDto>> GetAllPlayers();
    }
}
