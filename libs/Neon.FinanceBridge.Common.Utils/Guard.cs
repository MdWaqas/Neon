using System;
using System.Diagnostics;

namespace Neon.FinanceBridge.Common.Utils
{
    public static class Guard
    {
        [DebuggerStepThrough]
        public static void AgainstNullArgument<TArgType>(string argumentName, TArgType argumentValue)
        {
            if (argumentValue == null)
            {
                throw new ArgumentNullException(argumentName);
            }
        }

        [DebuggerStepThrough]
        public static void AgainstNullOrEmptyStringArgument(string argumentName, string argumentValue)
        {
            AgainstNullArgument(argumentName, argumentValue);
            if (string.IsNullOrWhiteSpace(argumentValue))
            {
                throw new ArgumentException("Value cannot be empty", argumentName);
            }
        }
    }
}
