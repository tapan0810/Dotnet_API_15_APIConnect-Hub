namespace Dotnet_API_15.Service.CacheService
{
    public interface ICacheService
    {
        Task<T> GetOrSetAsync<T>(string key, Func<Task<T>> getData,TimeSpan? expiry= null);

        void Remove(string key);
    }
}
