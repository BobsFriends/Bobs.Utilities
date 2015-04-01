using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bobs
{
    /// <summary>
    /// Encapsulates the parameters of a <see cref="String.Format(IFormatProvider, string, object[])"/> operation and
    /// enables deferred execution by calling <see cref="StringFormatter.ToString"/>
    /// at a later stage.
    /// </summary>
    public class StringFormatter
    {
        IFormatProvider _provider;
        string _format;
        object[] _args;

        /// <summary>
        /// Instantiates a new instance of <see cref="StringFormatter"/> passing
        /// to it the parameters of the
        /// <see cref="String.Format(IFormatProvider, string, object[])"/> operation.
        /// </summary>
        /// <param name="provider">An object that supplies culture-specific formatting information.</param>
        /// <param name="format">A composite format string.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        public StringFormatter(IFormatProvider provider, string format, params object[] args)
        {
            _provider       = provider;
            _format         = format;
            _args           = args;
        }

        /// <summary>
        /// Returns a string that represents the result of the
        /// <see cref="String.Format(IFormatProvider, string, object[])"/> operation.
        /// </summary>
        /// <returns>A string that represents the result of the
        /// <see cref="String.Format(IFormatProvider, string, object[])"/> operation.</returns>
        public override string ToString()
        {
            if (_format == null)
                return null;
            if (_args == null)
                return _format;
            return string.Format(_provider, _format, _args);
        }
    }
}
