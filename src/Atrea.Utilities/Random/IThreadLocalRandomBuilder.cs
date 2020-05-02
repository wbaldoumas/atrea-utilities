using System;

namespace Atrea.Utilities.Random
{
    /// <summary>
    ///     A builder for creating thread-safe random number generators which implement the <see cref="IRandom" /> interface.
    ///     For more info on the subject of thread-safe randomness, see the following:
    ///
    ///     https://codeblog.jonskeet.uk/2009/11/04/revisiting-randomness/
    ///     https://devblogs.microsoft.com/pfxteam/getting-random-numbers-in-a-thread-safe-way/"
    /// </summary>
    public interface IThreadLocalRandomBuilder
    {
        /// <summary>
        ///     Specifies how the thread-safe random number generator should be created by the builder.
        /// </summary>
        /// <param name="generatorValueFactory">The method by which the random number generator is to be created.</param>
        /// <returns>Returns <see cref="IThreadLocalRandomBuilder" /> which <see cref="Build" /> shall be called on.</returns>
        IThreadLocalRandomBuilder WithGeneratorValueFactory(Func<IRandom> generatorValueFactory);

        /// <summary>
        ///     Builds and returns the thread-safe random number generator.
        /// </summary>
        /// <returns>The thread-safe <see cref="IRandom" /> random number generator.</returns>
        IRandom Build();
    }
}