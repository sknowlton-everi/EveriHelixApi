namespace EveriHelixAPI.Models
{
    public class Project
    {
        public int id { get; set; } = 0;
        public string name { get; set; } = String.Empty;
        public string uuid { get; set; } = String.Empty;
    }

    public class ProjectList
    {
        public IList<Project> projects { get; set; } = new List<Project>();
        public int projectsLoading { get; set; } = 0;

        public Token accessToken { get; set; }
    }
}