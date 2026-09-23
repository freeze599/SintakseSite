using Microsoft.AspNetCore.Mvc;
using SintakseSite.Data;

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

        return View(eventItem);
    }
}
