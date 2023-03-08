using System.Diagnostics;

namespace EveriHelixAPI.Extensions
{
    public static class LoggingExtensions
    {
        public static string Caller(this StackTrace stackTrace)
        {
            return stackTrace.GetFrame(1).GetMethod().Name;
        }
    }
}