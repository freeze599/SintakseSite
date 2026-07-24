namespace SintakseSite.Models
{
    public class AuthorViewModel
    {
        public string Name { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public string Categories { get; set; } = string.Empty;
        public string ObjectPosition { get; set; } = "center center";
        public string ObjectPositionClass { get; set; } = "object-center";
        public string? Description { get; set; }
    }
}