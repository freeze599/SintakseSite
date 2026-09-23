using Microsoft.AspNetCore.Mvc;
using SintakseSite.Data;

namespace SintakseSite.Controllers;

public class AuthorsController : Controller
{
    [HttpGet("autori/{slug}")]
    public IActionResult Details(string slug)
    {
        var page = AuthorAudioData.Find(slug);
        if (page is null) return NotFound();
        return View(page);
    }
}
