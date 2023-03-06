namespace EveriHelixAPI.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Attachments
    {
        public string self { get; set; }
    }

    public class Documents
    {
        public string self { get; set; }
    }

    public class Events
    {
        public string self { get; set; }
    }

    public class Field
    {
        public int id { get; set; }
        public string label { get; set; }
        public MenuItem menuItem { get; set; }
        public string type { get; set; }
        public List<MenuItemArray> menuItemArray { get; set; }
        public User user { get; set; }
        public List<object> userArray { get; set; }
        public bool? boolean { get; set; }
        public DateTime? dateTime { get; set; }
        public string @string { get; set; }
        public int? integer { get; set; }
        public string date { get; set; }
        public FormattedString formattedString { get; set; }
    }

    public class Folders
    {
        public string self { get; set; }
    }

    public class FormattedString
    {
        public List<object> inlineImages { get; set; }
        public bool isFormatted { get; set; }
        public string text { get; set; }
    }

    public class Link
    {
        public string @ref { get; set; }
        public string href { get; set; }
        public string method { get; set; }
        public string self { get; set; }
    }

    public class MenuItem
    {
        public int id { get; set; }
        public string label { get; set; }
    }

    public class MenuItemArray
    {
        public int id { get; set; }
        public string label { get; set; }
    }

    public class Paging
    {
        public int page { get; set; }
        public int pageLimit { get; set; }
        public int totalCount { get; set; }
        public int totalPages { get; set; }
        public List<Link> links { get; set; }
    }

    public class Requirement
    {
        public Attachments attachments { get; set; }
        public Documents documents { get; set; }
        public Events events { get; set; }
        public List<Field> fields { get; set; }
        public Folders folders { get; set; }
        public string httpURL { get; set; }
        public int id { get; set; }
        public List<Link> links { get; set; }
        public int number { get; set; }
        public RequirementType requirementType { get; set; }
        public string self { get; set; }
        public string tag { get; set; }
        public string ttstudioURL { get; set; }
        public Versions versions { get; set; }
    }

    public class RequirementType
    {
        public int id { get; set; }
        public string label { get; set; }
    }

    public class RequirementList
    {
        public Paging paging { get; set; }
        public List<Requirement> requirements { get; set; }
    }

    public class User
    {
        public string firstName { get; set; }
        public int id { get; set; }
        public string lastName { get; set; }
        public string mi { get; set; }
        public string username { get; set; }
    }

    public class Versions
    {
        public string self { get; set; }
    }
}