using Microsoft.AspNetCore.Mvc;
using SintakseSite.Data;
using SintakseSite.Models;
using System.Diagnostics;

namespace SintakseSite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var today = DateTime.Today;

            var viewModel = new HomePageViewModel
            {
                Authors = AuthorData.Authors,

                UpcomingEvents = EventData.Events
                    .Where(e => e.Date.Date >= today)
                    .OrderBy(e => e.Date)
                    .ToList(),

                PastEvents = EventData.Events
                    .Where(e => e.Date.Date < today)
                    .OrderByDescending(e => e.Date)
                    .ToList()
            };

            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Gallery()
        {
            return View();
        }

        [ResponseCache(
            Duration = 0,
            Location = ResponseCacheLocation.None,
            NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel
            {
                RequestId = Activity.Current?.Id
                    ?? HttpContext.TraceIdentifier
            });
        }
    }
}