namespace SintakseSite.Models;

public class EventViewModel
{
    public string Slug { get; set; } = string.Empty;

    public string Title { get; set; } = string.Empty;

    public DateTime Date { get; set; }

    public string Time { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public string PosterImage { get; set; } = string.Empty;

    public string? ExternalUrl { get; set; }

    public string ExternalLinkText { get; set; } = "Plašāka informācija";

    public string? GallerySlug { get; set; }

    public string? Participants { get; set; }

    public string? MusicalGuest { get; set; }
    public string Organizer { get; set; } = "";
}

