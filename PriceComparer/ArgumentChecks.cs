using System;
using System.Diagnostics;

namespace PriceComparer
{
    public static class ArgumentChecks
    {
        [DebuggerStepThrough]
        public static void NotNull<TArgument>(TArgument argument, string argumentName)
            where TArgument : class
        {
            Debug.Assert(argumentName != null, "argumentName != null");

            if (argument == null)
            {
                throw new ArgumentNullException(argumentName);
            }
        }

        [DebuggerStepThrough]
        public static void NotNullOrEmpty(string argument, string argumentName)
        {
            Debug.Assert(argumentName != null, "argumentName != null");

            if (string.IsNullOrEmpty(argument))
            {
                var message = string.Format("'{0}' is null or empty", argumentName);
                throw new ArgumentException(message);
            }
        }

        [DebuggerStepThrough]
        public static void NotNullOrWhiteSpace(string argument, string argumentName)
        {
            Debug.Assert(argumentName != null, "argumentName != null");

            if (string.IsNullOrWhiteSpace(argument))
            {
                var message = string.Format("'{0}' is null or white space", argumentName);
                throw new ArgumentException(message);
            }
        }

        [DebuggerStepThrough]
        public static void Assert(bool condition, string message)
        {
            Debug.Assert(message != null, "message != null");

            if (!condition)
            {
                throw new ArgumentException(message);
            }
        }
    }
}
