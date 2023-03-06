using Serilog;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace EveriHelixAPI.Extensions
{
    public static class StringExtensions
    {
        public static bool IsTruelyEmpty(this string someString)
        {
            if (someString == null)
            {
                return true;
            }

            if (string.IsNullOrWhiteSpace(someString))
            {
                return true;
            }

            return false;
        }

        public static string Clean(this string someString)
        {
            if (someString == null)
            {
                return string.Empty;
            }

            return someString.Trim();
        }
    }
}