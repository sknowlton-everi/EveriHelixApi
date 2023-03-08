using EveriHelixAPI.Extensions;

namespace EveriHelixAPI.Infrastructure
{
    public class HelixConfig
    {
        public const string Key = "Helix";

        public string BaseUrl { get; set; } = String.Empty;

        public string Username { get; set; } = String.Empty;

        public string Password { get; set; } = String.Empty;

        public string GetEncryption()
        {
            return Username.getBasicAuth(Password);
        }
    }
}