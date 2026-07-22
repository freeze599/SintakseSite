using Microsoft.AspNetCore.Mvc;
using SintakseSite.Models;
using System.Diagnostics;
using SintakseSite.Data;

namespace SintakseSite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var authors = new List<AuthorViewModel>
    {
        new()
        {
            Name = "Aļesja Loseva",
            Image = "Alesja.jpg",
            Categories = "Dzeja · atdzeja",
            ObjectPosition = "center 25%"
        },
        new()
        {
            Name = "Andris Alps",
            Image = "Alps.jpg",
            Categories = "Dzeja · proza",
            ObjectPosition = "center 30%"
        },
        new()
        {
            Name = "Arnolds Ščuckis",
            Image = "Arnolds.jpg",
            Categories = "Dzeja",
            ObjectPosition = "center 30%"
        },
        new()
        {
            Name = "Daina Šteinerte",
            Image = "DainaSt.jpg",
            Categories = "Dzeja · horeogrāfija",
            ObjectPosition = "center 35%"
        },
        new()
        {
            Name = "Dainis Deigelis",
            Image = "DainisD.jpg",
            Categories = "Dzeja · atdzeja · proza",
            ObjectPosition = "center 35%"
        },
        new()
        {
            Name = "Dita Putniņa",
            Image = "DitaP.jpg",
            Categories = "Dzeja",
            ObjectPosition = "center 30%"
        },
        new()
        {
            Name = "Ilze Kuzmicka",
            Image = "IlzeK.jpg",
            Categories = "Dzeja",
            ObjectPosition = "center 25%"
        },
        new()
        {
            Name = "Kaspars Sils",
            Image = "KasparsS.jpg",
            Categories = "Mūzika",
            ObjectPosition = "center 25%"
        },
        new()
        {
            Name = "Katrīna Jēkabsone",
            Image = "KatrinaJ.jpg",
            Categories = "Dzeja",
            ObjectPosition = "center 30%"
        },
        new()
        {
            Name = "Kristīne Jučkoviča",
            Image = "KristineJ.jpg",
            Categories = "Dzeja · proza · rakstniecība",
            ObjectPosition = "center 25%"
        },
        new()
        {
            Name = "Laima Ābele",
            Image = "Laima.jpg",
            Categories = "Dzeja",
            ObjectPosition = "center 25%"
        },
        new()
        {
            Name = "Meldra Ķemere",
            Image = "MeldraK.jpg",
            Categories = "Dzeja",
            ObjectPosition = "center 25%"
        },
        new()
        {
            Name = "Pauls Kauķis",
            Image = "PaulsK.jpg",
            Categories = "Dzeja",
            ObjectPosition = "center 25%"
        }
    };

            var today = DateTime.Today;

            var viewModel = new HomePageViewModel
            {
                Authors = authors,

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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
