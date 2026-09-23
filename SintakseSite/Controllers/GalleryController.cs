using Microsoft.AspNetCore.Mvc;
using SintakseSite.Data;
using SintakseSite.Models;

namespace SintakseSite.Controllers;

public class GalleryController : Controller
{
    public IActionResult Index()
    {
        return View(GalleryData.Galleries);
    }

    public IActionResult Details(string slug)
    {
        var gallery = GalleryData.Galleries
            .FirstOrDefault(x => string.Equals(x.Slug, slug, StringComparison.OrdinalIgnoreCase));

        if (gallery == null)
            return NotFound();

        return View(gallery);
    }
}