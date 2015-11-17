namespace Framework.AssetLibrary.Caching
{
    /// <summary>
    ///     Interface ICacheContext
    /// </summary>
    public interface ICacheContext
    {
        #region Methods

        /// <summary>
        ///     Adds the specified key.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key">The key.</param>
        /// <param name="genericObject">The generic object.</param>
        void Add<T>(string key, T genericObject);

        /// <summary>
        ///     Gets the specified key.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key">The key.</param>
        /// <returns>``0.</returns>
        T Get<T>(string key);

        /// <summary>
        ///     Removes the specified key.
        /// </summary>
        /// <param name="key">The key.</param>
        void Remove(string key);

        /// <summary>
        ///     Determines whether [contains] [the specified key].
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns><c>true</c> if [contains] [the specified key]; otherwise, <c>false</c>.</returns>
        bool Contains(string key);

        #endregion Methods
    }
}