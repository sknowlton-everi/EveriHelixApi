namespace EveriHelixAPI.Models
{
    public class Token
    {
        public string tokenType { get; set; } = string.Empty;
        public DateTime expiresOn { get; set; }
        public string accessToken { get; set; } = string.Empty;
    }
}