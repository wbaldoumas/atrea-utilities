using System;
using System.Collections.Concurrent;

namespace Atrea.Utilities.Pool
{
    /// <inheritdoc cref="IObjectPool{T}" />
    public class ObjectPool<T> : IObjectPool<T>
    {
        private readonly Func<T> _objectGenerator;
        private readonly ConcurrentBag<T> _objects;

        /// <summary>
        ///     An object pool which efficiently handles retrieving and adding objects to the pool.
        /// </summary>
        /// <param name="objectGenerator">The object generator for generating new objects when the pool is empty.</param>
        public ObjectPool(Func<T> objectGenerator)
        {
            _objects = new ConcurrentBag<T>();
            _objectGenerator = objectGenerator ?? throw new ArgumentNullException(nameof(objectGenerator));
        }

        /// <inheritdoc cref="IObjectPool{T}.Get()" />
        public T Get()
        {
            return _objects.TryTake(out var item) ? item : _objectGenerator();
        }

        /// <inheritdoc cref="IObjectPool{T}.Put(T)" />
        public void Put(T item)
        {
            _objects.Add(item);
        }
    }
}