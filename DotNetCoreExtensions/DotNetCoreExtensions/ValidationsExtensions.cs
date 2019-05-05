using System;

namespace DotNetCoreExtensions
{
    public static class ValidationsExtensions
    {
        public static void ThrowIfNull<T>(this T obj, string paramName) where T : class
        {
            if (obj == null)
                throw new ArgumentNullException(paramName);

        }

        public static void ThrowIfNullOrWhiteSpace(this string inputString, string paramName)
        {
            if (String.IsNullOrWhiteSpace(inputString))
            {
                throw new ArgumentNullException(paramName);
            }
        }
    }
}
