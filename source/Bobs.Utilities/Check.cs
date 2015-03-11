using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bobs
{
    public static class Check
    {
        public static T NotNull<T>(T value, string paramName)
        {
            if (value == null)
                throw new ArgumentNullException(paramName);
            return value;
        }
    }
}
