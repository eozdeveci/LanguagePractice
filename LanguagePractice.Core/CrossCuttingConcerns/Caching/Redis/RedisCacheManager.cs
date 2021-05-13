using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguagePractice.Core.CrossCuttingConcerns.Caching.Redis
{
    public class RedisCacheManager : ICacheManager
    {
        protected IDistributedCache _cache;

        public RedisCacheManager(IDistributedCache cache)
        {
            _cache = cache;
        }

        private static int DefaultCacheDuration => 5;
        public void Add(string key, object value, int duration)
        {
            Store(key, value, DefaultCacheDuration);
        }
        public void Store(string key, object content, int duration)
        {
            string toStore;
            if (content is string)
            {
                toStore = (string)content;
            }
            else
            {
                toStore = JsonConvert.SerializeObject(content);
            }

            duration = duration <= 0 ? DefaultCacheDuration : duration;
            _cache.Set(key, Encoding.UTF8.GetBytes(toStore), new DistributedCacheEntryOptions()
            {
                AbsoluteExpiration = DateTime.Now + TimeSpan.FromMinutes(duration)
            });
        }
        public T Get<T>(string key)
        {
            var fromCache = _cache.Get(key);
            return JsonConvert.DeserializeObject<T>(Encoding.UTF8.GetString(fromCache));
        }

        public object Get(string key)
        {
            return _cache.Get(key);
        }

        public bool IsAdded(string key)
        {
            var fromCache = _cache.Get(key);
            if (fromCache == null)
                return false;
            return true;
        }

        public void Remove(string key)
        {
            _cache.Remove(key);
        }
    }
}
