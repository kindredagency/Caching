namespace Framework.AssetLibrary.Caching
{
    /// <summary>
    ///     Class CacheFactory. This class cannot be inherited.
    /// </summary>
    public static class CacheFactory
    {
        #region Private variable

        private static ICacheContext _cacheContext;

        #endregion Private variable

        #region Public methods

        /// <summary>
        ///     Gets the context.
        /// </summary>
        /// <returns>ICacheContext.</returns>
        public static ICacheContext GetContext()
        {
            return _cacheContext ?? (_cacheContext = new CacheContext());
        }

        #endregion Public methods
     
    }
}