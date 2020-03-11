namespace Atrea.Utilities.Pool
{
    /// <summary>
    ///     An object pool which efficiently handles retrieving and adding objects to the pool.
    /// </summary>
    /// <typeparam name="T">The type of object to use in the object pool.</typeparam>
    public interface IObjectPool<T>
    {
        /// <summary>
        ///     Retrieve an object from the pool, or create a new one if the pool is empty.
        /// </summary>
        /// <returns>Returns the object from the pool.</returns>
        T Get();

        /// <summary>
        ///     Put an object back in the pool.
        /// </summary>
        /// <param name="item">The item to put back in the pool.</param>
        void Put(T item);
    }
}