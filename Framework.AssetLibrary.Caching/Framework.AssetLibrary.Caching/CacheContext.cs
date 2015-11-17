using System.Runtime.Caching;
using System.Threading;

namespace Framework.AssetLibrary.Caching
{
    /// <summary>
    ///     Class CacheContext.
    /// </summary>
    internal class CacheContext : ICacheContext
    {
        #region Private variables

        private readonly MemoryCache _cache;

        #endregion Private variables

        #region Public constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="CacheContext" /> class.
        /// </summary>
        public CacheContext()
        {
            using (ExecutionContext.SuppressFlow())
            {
                _cache = MemoryCache.Default;
            }
        }

        #endregion Public constructors

        #region Public methods

        /// <summary>
        ///     Adds the specified key.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key">The key.</param>
        /// <param name="genericObject">The generic object.</param>
        public void Add<T>(string key, T genericObject)
        {
            using (ExecutionContext.SuppressFlow())
            {
                var cacheItemPolicy = new CacheItemPolicy();
                _cache.Add(key, genericObject, cacheItemPolicy);
            }
        }

        /// <summary>
        ///     Determines whether [contains] [the specified key].
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns><c>true</c> if [contains] [the specified key]; otherwise, <c>false</c>.</returns>
        public bool Contains(string key)
        {
            using (ExecutionContext.SuppressFlow())
            {
                return _cache.Contains(key);
            }
        }

        /// <summary>
        ///     Gets the specified key.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key">The key.</param>
        /// <returns>``0.</returns>
        public T Get<T>(string key)
        {
            using (ExecutionContext.SuppressFlow())
            {
                return (T)_cache.Get(key);
            }
        }

        /// <summary>
        ///     Removes the specified key.
        /// </summary>
        /// <param name="key">The key.</param>
        public void Remove(string key)
        {
            using (ExecutionContext.SuppressFlow())
            {
                //Remove it from the cache
                _cache.Remove(key);
            }
        }

        #endregion Public methods
    }
}