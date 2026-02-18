namespace Dotnet_API_15.Entities.Dtos
{
    public class GetAllPlayerDto
    {
        public string PlayerName { get; set; } = string.Empty;
        public string PlayerEmail { get; set; } = string.Empty;
        public bool IsPlaying { get; set; } = false;
    }
}
