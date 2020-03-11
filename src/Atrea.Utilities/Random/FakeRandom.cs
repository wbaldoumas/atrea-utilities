﻿namespace Atrea.Utilities.Random
{
    /// <summary>
    ///     An implementation of <see cref="IRandom"/> to be used within the context of unit tests.
    ///     Allows for full control over what "random" numbers will be generated, based on the values
    ///     passed into its constructor.
    /// </summary>
    public class FakeRandom : IRandom
    {
        private readonly double[] _values;
        private int _currentIndex;

        /// <summary>
        ///     An implementation of <see cref="IRandom"/> to be used within the context of unit tests. 
        /// </summary>
        /// <param name="values">The values to be used as the random numbers generated by this <see cref="FakeRandom"/>.</param>
        public FakeRandom(params double[] values)
        {
            _values = values;
        }

        /// <inheritdoc cref="IRandom.Next()"/>
        public int Next()
        {
            return (int) NextDouble();
        }

        /// <inheritdoc cref="IRandom.Next(int)"/>
        public int Next(int maxValue)
        {
            return (int) NextDouble();
        }

        /// <inheritdoc cref="IRandom.Next(int, int)"/>
        public int Next(int minValue, int maxValue)
        {
            return (int) NextDouble();
        }

        /// <inheritdoc cref="IRandom.NextDouble()"/>
        public double NextDouble()
        {
            if (_currentIndex == _values.Length)
            {
                _currentIndex = 0;
            }

            var result = _values[_currentIndex++];

            return result;
        }
    }
}