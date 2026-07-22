namespace SintakseSite.Models;

public class HomePageViewModel
{
    public List<AuthorViewModel> Authors { get; set; } = new();

    public List<EventViewModel> UpcomingEvents { get; set; } = new();

    public List<EventViewModel> PastEvents { get; set; } = new();
}