using System;
using System.Collections.Generic;
using System.Linq;

namespace Atrea.Utilities.Enums
{
    /// <summary>
    ///     Utility methods for working with enumerated types.
    /// </summary>
    /// <typeparam name="T">The type of the enumeration</typeparam>
    public static class EnumUtils<T> where T : Enum
    {
        /// <summary>
        ///     Creates and yields an enumerable of the values of the enumerated type.
        /// </summary>
        /// <exception cref="ArgumentException">Throws argument exception when called on non-enumerated type.</exception>
        /// <returns>Returns an <see cref="IEnumerable{T}"/> of values of the enumerated type.</returns>
        public static IEnumerable<T> AsEnumerable() => (T[]) Enum.GetValues(typeof(T));

        /// <summary>
        ///     Creates a dictionary from the given enumerated type.
        /// </summary>
        /// <returns>Returns an <see cref="IDictionary{TKey,TValue}"/> generated from the enumerated type.</returns>
        public static IDictionary<int, string> AsDictionary() =>
            AsEnumerable().ToDictionary(
                enumValue => (int) (object) enumValue,
                enumValue => enumValue.ToString()
            );
    }
}