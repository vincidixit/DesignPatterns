
using System.Runtime.Caching;

namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CacheManager cacheManager = CacheManager.Instance;

            cacheManager.Add("foo", "bar");

            CacheItem cacheItem = cacheManager.Get("foo");

            if(cacheItem != null)
            {
                Console.WriteLine("Cached value: " + cacheItem.Value);
            }
        }

    }
}
