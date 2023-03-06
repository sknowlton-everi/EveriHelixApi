namespace EveriHelixAPI.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Attachments
    {
        public string self { get; set; } = String.Empty;
    }

    public class Documents
    {
        public string self { get; set; } = String.Empty;
    }

    public class Events
    {
        public string self { get; set; } = String.Empty;
    }

    public class Field
    {
        public int id { get; set; }
        public string label { get; set; } = String.Empty;
        public MenuItem? menuItem { get; set; }
#pragma warning disable CS8618 // Non-nullable property 'type' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public string type { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'type' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
#pragma warning disable CS8618 // Non-nullable property 'menuItemArray' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public List<MenuItemArray> menuItemArray { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'menuItemArray' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
#pragma warning disable CS8618 // Non-nullable property 'user' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public User user { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'user' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
#pragma warning disable CS8618 // Non-nullable property 'userArray' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public List<object> userArray { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'userArray' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public bool? boolean { get; set; }
        public DateTime? dateTime { get; set; }
#pragma warning disable CS8618 // Non-nullable property 'string' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public string @string { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'string' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public int? integer { get; set; }
#pragma warning disable CS8618 // Non-nullable property 'date' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public string date { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'date' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
#pragma warning disable CS8618 // Non-nullable property 'formattedString' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public FormattedString formattedString { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'formattedString' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
    }

    public class Folders
    {
#pragma warning disable CS8618 // Non-nullable property 'self' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public string self { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'self' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
    }

    public class FormattedString
    {
#pragma warning disable CS8618 // Non-nullable property 'inlineImages' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public List<object> inlineImages { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'inlineImages' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public bool isFormatted { get; set; }
#pragma warning disable CS8618 // Non-nullable property 'text' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public string text { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'text' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
    }

    public class Link
    {
#pragma warning disable CS8618 // Non-nullable property 'ref' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public string @ref { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'ref' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
#pragma warning disable CS8618 // Non-nullable property 'href' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public string href { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'href' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
#pragma warning disable CS8618 // Non-nullable property 'method' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public string method { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'method' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
#pragma warning disable CS8618 // Non-nullable property 'self' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public string self { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'self' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
    }

    public class MenuItem
    {
        public int id { get; set; }
#pragma warning disable CS8618 // Non-nullable property 'label' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public string label { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'label' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
    }

    public class MenuItemArray
    {
        public int id { get; set; }
#pragma warning disable CS8618 // Non-nullable property 'label' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public string label { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'label' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
    }

    public class Paging
    {
        public int page { get; set; }
        public int pageLimit { get; set; }
        public int totalCount { get; set; }
        public int totalPages { get; set; }
#pragma warning disable CS8618 // Non-nullable property 'links' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public List<Link> links { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'links' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
    }

    public class Requirement
    {
#pragma warning disable CS8618 // Non-nullable property 'attachments' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public Attachments attachments { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'attachments' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
#pragma warning disable CS8618 // Non-nullable property 'documents' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public Documents documents { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'documents' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
#pragma warning disable CS8618 // Non-nullable property 'events' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public Events events { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'events' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
#pragma warning disable CS8618 // Non-nullable property 'fields' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public List<Field> fields { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'fields' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
#pragma warning disable CS8618 // Non-nullable property 'folders' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public Folders folders { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'folders' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
#pragma warning disable CS8618 // Non-nullable property 'httpURL' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public string httpURL { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'httpURL' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public int id { get; set; }
#pragma warning disable CS8618 // Non-nullable property 'links' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public List<Link> links { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'links' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public int number { get; set; }
#pragma warning disable CS8618 // Non-nullable property 'requirementType' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public RequirementType requirementType { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'requirementType' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
#pragma warning disable CS8618 // Non-nullable property 'self' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public string self { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'self' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
#pragma warning disable CS8618 // Non-nullable property 'tag' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public string tag { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'tag' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
#pragma warning disable CS8618 // Non-nullable property 'ttstudioURL' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public string ttstudioURL { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'ttstudioURL' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
#pragma warning disable CS8618 // Non-nullable property 'versions' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public Versions versions { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'versions' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
    }

    public class RequirementType
    {
        public int id { get; set; }
#pragma warning disable CS8618 // Non-nullable property 'label' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public string label { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'label' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
    }

    public class RequirementList
    {
#pragma warning disable CS8618 // Non-nullable property 'paging' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public Paging paging { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'paging' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
#pragma warning disable CS8618 // Non-nullable property 'requirements' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public List<Requirement> requirements { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'requirements' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
    }

    public class User
    {
#pragma warning disable CS8618 // Non-nullable property 'firstName' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public string firstName { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'firstName' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public int id { get; set; }
#pragma warning disable CS8618 // Non-nullable property 'lastName' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public string lastName { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'lastName' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
#pragma warning disable CS8618 // Non-nullable property 'mi' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public string mi { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'mi' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
#pragma warning disable CS8618 // Non-nullable property 'username' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public string username { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'username' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
    }

    public class Versions
    {
#pragma warning disable CS8618 // Non-nullable property 'self' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public string self { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'self' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
    }
}