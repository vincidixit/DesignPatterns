using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class CacheManager
    {
        private readonly MemoryCache cache;
        private static CacheManager instance;

        private CacheManager()
        {
            cache = new MemoryCache("CustomCache");
        }

        public static CacheManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CacheManager();
                }
                return instance;
            }
        }

        public void Add(string key, object value, double expirationInMinutes = 10)
        {
            cache.Add(new CacheItem(key, value), new CacheItemPolicy() { AbsoluteExpiration = DateTime.Now.AddMinutes(expirationInMinutes) });
        }

        public CacheItem Get(string key)
        {
            return cache.GetCacheItem(key);
        }

        public void Remove(string key)
        {
            cache.Remove(key);
        }
    }
}
