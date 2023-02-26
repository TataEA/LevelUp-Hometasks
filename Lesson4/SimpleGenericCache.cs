namespace Lesson4
{
    internal class SimpleGenericCache<T>
    {
        private readonly Dictionary<string, CachedValue<T>> _cache = new(); 
        internal void Store(string key, T value, int timeout = 30) 
        {         
            var cachedValue = new CachedValue<T>
            {
                CreationTime = DateTime.Now,
                Timeout = timeout,
                Value = value,
            };
            _cache[key] = cachedValue;
        }

        internal CachedValue<T>? Fetch(string key)
        {
            if (_cache.TryGetValue(key, out var  value)) 
            {
                var seconds = TimeSpan.FromSeconds(value.Timeout);
                var endOfLife = value.CreationTime + seconds;
                if (endOfLife >= DateTime.Now)
                {
                    return value;
                }
                else
                {
                    _cache.Remove(key);
                }
            }

            return default; 
        }

    }

    public record CachedValue<T>
    {
        public T? Value { get; init; }
        public int Timeout { get; init; }
        public DateTime CreationTime { get; init; }
    }
}