namespace Atrea.Utilities.Random
{
    /// <summary>
    ///     Interface representative of a random number generator.
    /// </summary>
    public interface IRandom
    {
        /// <summary>
        ///     Returns a non-negative random integer.
        /// </summary>
        /// <returns>A <see cref="int" /> that is greater than or equal to 0 and less than <see cref="int.MaxValue" />.</returns>
        int Next();

        /// <summary>
        ///     Returns a non-negative random integer that is less than the specified maxValue.
        /// </summary>
        /// <param name="maxValue">
        ///     The exclusive upper bound of the random number to be generated. maxValue must be greater than or
        ///     equal to 0.
        /// </param>
        /// <returns>A <see cref="int" /> that is greater than or equal to 0, and less than maxValue.</returns>
        int Next(int maxValue);

        /// <summary>
        ///     Returns a random integer that is greater than or equal to minValue, and less than maxValue.
        /// </summary>
        /// <param name="minValue">The inclusive lower bound of the random number returned.</param>
        /// <param name="maxValue">
        ///     The exclusive upper bound of the random number returned. maxValue must be greater than or equal
        ///     to minValue.
        /// </param>
        /// <returns>A <see cref="int" /> greater than or equal to minValue and less than maxValue.</returns>
        int Next(int minValue, int maxValue);

        /// <summary>
        ///     Returns a random floating-point number that is greater than or equal to 0.0, and less than 1.0.
        /// </summary>
        /// <returns>A <see cref="double" /> that is greater than or equal to 0.0, and less than 1.0.</returns>
        double NextDouble();
    }
}