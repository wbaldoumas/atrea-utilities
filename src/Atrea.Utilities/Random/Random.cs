namespace Atrea.Utilities.Random
{
    /// <summary>
    ///     An implementation of <see cref="IRandom" /> which delegates its calls to <see cref="System.Random" />
    ///     This should be used when you need performance over cryptographically strong randomness. For a more
    ///     cryptographically strong random number generation, see <see cref="CryptoRandom" />.
    /// </summary>
    public class Random : System.Random, IRandom { }
}