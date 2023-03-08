namespace EveriHelixAPI.Models
{
    public class UserCredentials
    {
        public UserCredentials(int projectId, string username, string password)
        {
            this.projectId = projectId;
            this.username = username;
            this.password = password;
        }

        public string username { get; set; }
        public string password { get; set; }
        public int projectId { get; set; }
    }
}