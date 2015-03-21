using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Bobs
{
    /// <summary>
    /// Provides simple methods to check for pre-conditions.
    /// </summary>
    public static class Check
    {
        /// <summary>
        /// Checks, that the <paramref name="value"/> of type <typeparamref name="T"/> is not
        /// <c>null</c> and otherwise throws an <see cref="ArgumentNullException"/>.
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
        /// Checks, that the <paramref name="value"/> of type <see cref="String"/> is not
        /// <c>null</c> or <see cref="String.Empty"/> and otherwise an
        /// <see cref="ArgumentNullException"/> or <see cref="ArgumentException"/>.
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

        /// <summary>
        /// Checks, that the <paramref name="predicate"/> evaluates to <c>true</c> and otherwise
        /// throws an <see cref="ArgumentOutOfRangeException"/>
        /// </summary>
        /// <param name="predicate">The predicate to evaluate.</param>
        /// <param name="paramName">The name of the argument.</param>
        /// <param name="message">A message describing the pre-condition.</param>
        public static void That(Func<bool> predicate, string paramName, string message)
        {
            if (!predicate())
                throw new ArgumentOutOfRangeException(paramName, message);
        }

        /// <summary>
        /// Checks, that the <paramref name="condition"/> is <c>true</c> and otherwise
        /// throws an <see cref="ArgumentOutOfRangeException"/>
        /// </summary>
        /// <param name="condition">The condition that is checked.</param>
        /// <param name="paramName">The name of the argument.</param>
        /// <param name="message">A message describing the pre-condition.</param>
        public static void That(bool condition, string paramName, string message)
        {
            if (!condition)
                throw new ArgumentOutOfRangeException(paramName, message);
        }
    }
}
