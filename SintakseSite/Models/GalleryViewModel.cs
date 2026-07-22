namespace SintakseSite.Models;

public class GalleryViewModel
{
    public string Slug { get; set; } = string.Empty;

    public string Title { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public DateTime Date { get; set; }

    public string CoverImage { get; set; } = string.Empty;

    public List<string> Images { get; set; } = new();
}