
using Microsoft.Extensions.Caching.Memory;

namespace Dotnet_API_15.Service.CacheService
{

    public class CacheService : ICacheService
    {
        private readonly IMemoryCache _cache;

        public CacheService(IMemoryCache cache)
        {
            _cache = cache;
        }

        public async Task<T> GetOrSetAsync<T>(
            string key,
            Func<Task<T>> getData,
            TimeSpan? expiry = null)
        {
            if (_cache.TryGetValue(key, out T value))
            {
                return value; // Cache hit
            }

            value = await getData(); // Fetch from DB

            var options = new MemoryCacheEntryOptions
            {
                AbsoluteExpirationRelativeToNow =
                    expiry ?? TimeSpan.FromMinutes(5)
            };

            _cache.Set(key, value, options);

            return value;
        }

        public void Remove(string key)
        {
            _cache.Remove(key);
        }
    }

}
