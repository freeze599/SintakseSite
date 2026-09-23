using Microsoft.AspNetCore.Mvc;
using SintakseSite.Data;
using SintakseSite.Services;

namespace SintakseSite.Controllers;

public class EventsController : Controller
{
    [HttpGet("pasakumi/{slug}")]
    public IActionResult Details(string slug)
    {
        var eventItem = EventData.Events.FirstOrDefault(e =>
            string.Equals(e.Slug, slug, StringComparison.OrdinalIgnoreCase));

        if (eventItem is null)
            return NotFound();

        // Only offer a gallery when the album actually exists.
        ViewData["GallerySlug"] = GalleryData.Galleries.FirstOrDefault(g =>
            string.Equals(g.Slug, eventItem.GallerySlug, StringComparison.OrdinalIgnoreCase))?.Slug;

        ViewData["CanAddToCalendar"] = EventCalendar.TryGetStartUtc(eventItem, out _);
        return View(eventItem);
    }

    [HttpGet("pasakumi/{slug}/kalendars.ics")]
    public IActionResult Calendar(string slug)
    {
        var eventItem = EventData.Events.FirstOrDefault(e =>
            string.Equals(e.Slug, slug, StringComparison.OrdinalIgnoreCase));
        if (eventItem is null) return NotFound();
        if (!EventCalendar.TryGetStartUtc(eventItem, out var startUtc))
            return BadRequest("Pasākuma sākuma laiks vēl nav precizēts.");

        var content = EventCalendar.Build(eventItem, startUtc, DateTime.UtcNow);
        return File(content, "text/calendar; charset=utf-8", eventItem.Slug + ".ics");
    }
}
