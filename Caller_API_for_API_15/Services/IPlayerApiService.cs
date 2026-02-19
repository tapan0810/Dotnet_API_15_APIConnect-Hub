using Caller_API_for_API_15.Entities;

namespace Caller_API_for_API_15.Services
{
    public interface IPlayerApiService
    {
        public Task<List<PlayerDto>> GetPlayersFromApiAsyncGeaL();
    }
}
