using System;
using System.Security.Cryptography;

namespace Atrea.Utilities.Random
{
    /// <summary>
    ///     A cryptographically-strong random number generator.
    ///
    ///     Inspired by the following code:
    ///
    ///     Source: MSDN Magazine > 2007 > September > .NET Matters: Tales from the CryptoRandom
    ///     Source URL: http://msdn.microsoft.com/en-us/magazine/cc163367.aspx
    ///     Authors: Stephen Toub & Shawn Farkas
    /// </summary>
    public class CryptoRandom : System.Random, IRandom
    {
        private readonly RNGCryptoServiceProvider _cryptoProvider = new RNGCryptoServiceProvider();
        private readonly byte[] _uint32Buffer = new byte[4];

        /// <summary>
        ///     A cryptographically-strong random number generator.
        /// </summary>
        public CryptoRandom() { }

        /// <summary>
        ///     A cryptographically-strong random number generator.
        /// </summary>
        /// <param name="_"></param>
        // ReSharper disable once UnusedParameter.Local
        public CryptoRandom(int _) { }

        /// <inheritdoc cref="IRandom.Next()"/>
        public override int Next()
        {
            _cryptoProvider.GetBytes(_uint32Buffer);

            return BitConverter.ToInt32(_uint32Buffer, 0) & 0x7FFFFFFF;
        }

        /// <inheritdoc cref="IRandom.Next(int)" />
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="maxValue"/> is less than zero.</exception>
        public override int Next(int maxValue)
        {
            if (maxValue < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(maxValue));
            }

            return Next(0, maxValue);
        }

        /// <inheritdoc cref="IRandom.Next(int, int)" />
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="minValue" /> is greater than <paramref name="maxValue" />.</exception>
        public override int Next(int minValue, int maxValue)
        {
            if (maxValue < minValue)
            {
                throw new ArgumentOutOfRangeException(nameof(minValue));
            }

            if (maxValue < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(maxValue));
            }

            if (minValue < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(minValue));
            }

            if (minValue == maxValue)
            {
                return minValue;
            }

            long diff = maxValue - minValue;

            while (true)
            {
                _cryptoProvider.GetBytes(_uint32Buffer);

                var rand = BitConverter.ToUInt32(_uint32Buffer, 0);

                const long max = (1 + (long) uint.MaxValue);
                var remainder = max % diff;

                if (rand < max - remainder)
                {
                    return (int) (minValue + rand % diff);
                }
            }
        }

        /// <inheritdoc cref="IRandom.NextDouble()" />
        public override double NextDouble()
        {
            _cryptoProvider.GetBytes(_uint32Buffer);

            var rand = BitConverter.ToUInt32(_uint32Buffer, 0);

            return rand / (1.0 + uint.MaxValue);
        }

        /// <inheritdoc cref="System.Random.NextBytes(byte[])" />
        /// <exception cref="ArgumentNullException" /><paramref name="buffer" /> is null.
        public override void NextBytes(byte[] buffer)
        {
            if (buffer == null)
            {
                throw new ArgumentNullException(nameof(buffer));
            }

            _cryptoProvider.GetBytes(buffer);
        }
    }
}