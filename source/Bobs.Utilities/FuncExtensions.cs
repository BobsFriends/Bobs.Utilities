using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bobs
{
    /// <summary>
    /// The <see cref="FuncExtensions.AsFunc{T}"/> method helps converting a value to a function
    /// returning that value.
    /// </summary>
    public static class FuncExtensions
    {
        /// <summary>
        /// Returns a <see cref="Func{T}"/> returning the <paramref name="value"/>.
        /// </summary>
        /// <typeparam name="T">The type of the value</typeparam>
        /// <param name="value">The value to be returned.</param>
        /// <returns>A <see cref="Func{T}"/> returning the <paramref name="value"/>.</returns>
        public static Func<T> AsFunc<T>(this T value)
            where T : class
        {
            return new Func<T>(value.Return);
        }

        private static T Return<T>(this T value)
        {
            return value;
        }
    }
}
