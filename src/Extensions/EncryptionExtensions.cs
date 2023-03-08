using System.Text;

namespace EveriHelixAPI.Extensions
{
    public static class EncryptionExtensions
    {
        public static string getBasicAuth(this string username, string password) => encode(username, password);

        private static string encode(string username, string password)
        {
            byte[] data = Encoding.ASCII.GetBytes(username + ":" + password);
            return Convert.ToBase64String(data);
        }
    }
}