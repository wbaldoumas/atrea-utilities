using System;
using System.Threading;

namespace Atrea.Utilities.Random
{
    /// <inheritdoc cref="IThreadLocalRandomBuilder" />
    public class ThreadLocalRandomBuilder : IThreadLocalRandomBuilder
    {
        private Func<IRandom> _generatorValueFactory = () => new ThreadLocal<IRandom>().Value;

        /// <inheritdoc cref="IThreadLocalRandomBuilder.WithGeneratorValueFactory" />
        public IThreadLocalRandomBuilder WithGeneratorValueFactory(Func<IRandom> generatorValueFactory)
        {
            _generatorValueFactory = generatorValueFactory;

            return this;
        }

        /// <inheritdoc cref="IThreadLocalRandomBuilder.Build" />
        public IRandom Build()
        {
            return new ThreadLocal<IRandom>(_generatorValueFactory).Value;
        }
    }
}