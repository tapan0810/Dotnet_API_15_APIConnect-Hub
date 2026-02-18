namespace Dotnet_API_15.Entities.Models
{
    public class Player
    {
        public int PlayerId { get; set; }
        public string PlayerName { get; set; } = string.Empty;
        public string PlayerEmail { get; set; } = string.Empty;
        public string PlayerGender { get; set; } = string.Empty;
        public bool IsPlaying { get; set; } = false;
    }
}
