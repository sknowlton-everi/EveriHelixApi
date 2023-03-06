namespace EveriHelixAPI.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Project
    {
        public int id { get; set; }
        public string name { get; set; }
        public string uuid { get; set; }
    }

    public class ProjectList
    {
        public List<Project> projects { get; set; }
        public int projectsLoading { get; set; }
    }
}