namespace SintakseSite.Models;

public class EventViewModel
{
    public string Slug { get; set; } = string.Empty;

    public string Title { get; set; } = string.Empty;

    public DateTime Date { get; set; }

    public string Time { get; set; } = string.Empty;

    public string Summary { get; set; } = string.Empty;

    public string? LocationName { get; set; }

    public string? PriceText { get; set; }

    // Keep older events compact even before an editor supplies a summary.
    public string PreviewText
    {
        get
        {
            var text = string.IsNullOrWhiteSpace(Summary)
                ? Description.Split(new[] { "\r\n\r\n", "\n\n" }, StringSplitOptions.RemoveEmptyEntries).FirstOrDefault() ?? string.Empty
                : Summary;
            text = text.Trim();
            if (text.Length <= 220) return text;
            var end = text.LastIndexOf(' ', 217);
            return text.Substring(0, end > 140 ? end : 217).TrimEnd() + "…";
        }
    }

    public string Description { get; set; } = string.Empty;

    public string PosterImage { get; set; } = string.Empty;

    public string? ExternalUrl { get; set; }

    public string ExternalLinkText { get; set; } = "Plašāka informācija";

    public string? GallerySlug { get; set; }

    public string? Participants { get; set; }

    public string? MusicalGuest { get; set; }
    public string Organizer { get; set; } = "";

    public string? LocationUrl { get; set; }

}

