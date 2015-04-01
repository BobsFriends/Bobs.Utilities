using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bobs
{
    /// <summary>
    /// Provides thin type-safe wrappers around the methods of the <see cref="System.Enum"/> class.
    /// </summary>
    /// <typeparam name="TEnum">The type of the enummeration.</typeparam>
    public static class Enum<TEnum>
    {
        private static Type _enumType;

        /// <summary>
        /// Verifies the <typeparamref name="TEnum"/>.
        /// </summary>
        /// <exception cref="System.ArgumentException"><typeparamref name="TEnum"/> is not an <see cref="System.Enum"/>.</exception>
        static Enum()
        {
            _enumType = typeof(TEnum);
            if (!_enumType.IsEnum)
                throw new ArgumentException("TEnum is not an enum!");
        }

        /// <summary>
        /// Retrieves the name of the constant in the specified enumeration that has
        /// the specified value.
        /// </summary>
        /// <param name="value">The value of a particular enumerated constant in terms of its underlying
        /// type.</param>
        /// <returns>A string containing the name of the enumerated constant in <typeparamref name="TEnum"/> whose
        /// value is value; or null if no such constant is found.</returns>
        /// <exception cref="System.ArgumentNullException">value is null.</exception>
        /// <exception cref="System.ArgumentException">value is neither of type <typeparamref name="TEnum"/> nor
        /// does it have the same underlying type as <typeparamref name="TEnum"/>.</exception>
        public static string GetName(TEnum value)
        {
            return Enum.GetName(_enumType, value);
        }

        /// <summary>
        /// Retrieves an array of the names of the constants in a specified enumeration.
        /// </summary>
        /// <returns>A string array of the names of the constants in <typeparamref name="TEnum"/>.</returns>
        public static string[] GetNames()
        {
            return Enum.GetNames(_enumType);
        }

        /// <summary>
        /// Returns the underlying type of the specified enumeration.
        /// </summary>
        /// <returns>The underlying type of <typeparamref name="TEnum"/>.</returns>
        public static Type GetUnderlyingType()
        {
            return Enum.GetUnderlyingType(_enumType);
        }

        /// <summary>
        /// Retrieves an array of the values of the constants in a specified enumeration.
        /// </summary>
        /// <returns>An array that contains the values of the constants in <typeparamref name="TEnum"/>.</returns>
        /// <exception cref="System.InvalidOperationException">The method is invoked by reflection in a reflection-only context, -or- <typeparamref name="TEnum"/>
        /// is a type from an assembly loaded in a reflection-only context.</exception>
        public static TEnum[] GetValues()
        {
            return Enum.GetValues(_enumType).Cast<TEnum>().ToArray();
        }
        
        /// <summary>
        /// Returns an indication whether a constant with a specified value exists in a specified enumeration.
        /// </summary>
        /// <param name="value">The value or name of a constant in <typeparamref name="TEnum"/>.</param>
        /// <returns>true if a constant in <typeparamref name="TEnum"/> has a value equal to value; otherwise, false.</returns>
        /// <exception cref="System.ArgumentNullException">value is null.</exception>
        /// <exception cref="System.ArgumentException">The type of value is an enumeration, but it
        /// is not an enumeration of type <typeparamref name="TEnum"/>.-or- The type of value is not an underlying
        /// type of <typeparamref name="TEnum"/>.</exception>
        /// <exception cref="System.InvalidOperationException"> value is not type System.SByte, System.Int16, System.Int32, System.Int64,
        /// System.Byte, System.UInt16, System.UInt32, or System.UInt64, or System.String.</exception>
        public static bool IsDefined(object value)
        {
            return Enum.IsDefined(_enumType, value);
        }

        /// <summary>
        /// Converts the string representation of the name or numeric value of one or
        /// more enumerated constants to an equivalent enumerated object. A parameter
        /// specifies whether the operation is case-insensitive.
        /// </summary>
        /// <param name="value">A string containing the name or value to convert.</param>
        /// <param name="ignoreCase">true to ignore case; false to regard case.</param>
        /// <returns>An object of type <typeparamref name="TEnum"/> whose value is represented by value.</returns>
        /// <exception cref="System.ArgumentNullException">value is null.</exception>
        /// <exception cref="System.ArgumentException">value is either an empty string ("")
        /// or only contains white space.-or- value is a name, but not one of the named
        /// constants defined for the enumeration.</exception>
        /// <exception cref="System.OverflowException">value is outside the range of the underlying type of <typeparamref name="TEnum"/>.</exception>
        public static TEnum Parse(string value, bool ignoreCase)
        {
            return (TEnum)Enum.Parse(_enumType, value, ignoreCase);
        }

        /// <summary>
        /// Converts the specified object with an integer value to an enumeration member.
        /// </summary>
        /// <param name="value">The value to convert to an enumeration member.</param>
        /// <returns>An enumeration member whose value is value.</returns>
        /// <exception cref="System.ArgumentNullException">value is null.</exception>
        /// <exception cref="System.ArgumentException">value is not type System.SByte, System.Int16,
        /// System.Int32, System.Int64, System.Byte, System.UInt16, System.UInt32, or
        /// System.UInt64.</exception>
        public static TEnum ToEnum(object value)
        {
            return (TEnum)Enum.ToObject(_enumType, value);
        }
    }
}
