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
                var second = TimeSpan.FromSeconds(value.Timeout);
                var interval = value.CreationTime + second;
                if (interval >= DateTime.Now)
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