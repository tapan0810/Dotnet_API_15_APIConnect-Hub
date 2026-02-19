using Caller_API_for_API_15.Entities;
using System.Runtime.InteropServices;

namespace Caller_API_for_API_15.Services
{
    public class PlayerApiService(HttpClient httpClient ,IConfiguration configuration) : IPlayerApiService
    {
        public async Task<List<PlayerDto>> GetPlayersFromApiAsyncGeaL()
        {
           var baseUrl = configuration["ExternalApi:BaseUrl"];

            var result = await httpClient.GetAsync($"{baseUrl}/api/Players/GetAllPlayers");

            if (!result.IsSuccessStatusCode)
            {
                throw new Exception($"Failed to retrieve players. Status code: {result.StatusCode}");
            }

            var players = await result.Content.ReadFromJsonAsync<List<PlayerDto>>();
            return players ?? new List<PlayerDto>();
        }
    }
}
