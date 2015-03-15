using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bobs
{
    /// <summary>
    /// Provides simple methods to check for pre-conditions.
    /// </summary>
    public static class Check
    {
        /// <summary>
        /// Checks, that the <paramref name="value"/> of type <typeparamref name="T"/> is not <c>null</c>.
        /// </summary>
        /// <typeparam name="T">The type of the argument to check.</typeparam>
        /// <param name="value">The value of the argument.</param>
        /// <param name="paramName">The name of the argument.</param>
        /// <returns>The value of the argument.</returns>
        public static T NotNull<T>(T value, string paramName)
        {
            if (value == null)
                throw new ArgumentNullException(paramName);
            return value;
        }

        /// <summary>
        /// Checks, that the <paramref name="value"/> of type <see cref="String"/> is not <c>null</c>.
        /// </summary>
        /// <param name="value">The value of the argument.</param>
        /// <param name="paramName">The name of the argument.</param>
        /// <returns>The value of the argument.</returns>
        public static string NotEmpty(string value, string paramName)
        {
            if (value == null)
                throw new ArgumentNullException(paramName);
            if (value == string.Empty)
                throw new ArgumentException(CheckResources.Argument_Cannot_Be_Empty, paramName);
            return value;
        }
    }
}
