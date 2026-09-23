using Microsoft.AspNetCore.Mvc;
using MimeKit;
using SintakseSite.Models;
using SintakseSite.Services;

namespace SintakseSite.Controllers;

[ResponseCache(NoStore = true, Location = ResponseCacheLocation.None)]
public class ContactController(ContactMailSender sender, ContactSendBudget budget,
    ILogger<ContactController> logger) : Controller
{
    [HttpGet("sadarbiba")]
    public IActionResult Index() => View(new ContactRequest());

    [HttpPost("sadarbiba")]
    [ValidateAntiForgeryToken]
    [RequestSizeLimit(32768)]
    public async Task<IActionResult> Index(ContactRequest form)
    {
        if (!string.IsNullOrWhiteSpace(form.Website)) return BadRequest();
        form.Email = (form.Email ?? string.Empty).Trim();
        if (string.IsNullOrEmpty(form.Email) || !MailboxAddress.TryParse(form.Email, out var replyTo) ||
            !string.Equals(replyTo.Address, form.Email.Trim(), StringComparison.OrdinalIgnoreCase) ||
            form.Email.Contains('\r') || form.Email.Contains('\n'))
            ModelState.AddModelError(nameof(form.Email), "Ievadi vienu derīgu e-pasta adresi.");
        if (!ModelState.IsValid) return View(form);
        if (!sender.IsConfigured)
        {
            Response.StatusCode = 503;
            ModelState.AddModelError("", "Forma pašlaik nav pieejama. Raksti uz sintaksestupors@inbox.lv.");
            return View(form);
        }
        if (!budget.TryReserve())
        {
            Response.StatusCode = 429;
            ModelState.AddModelError("", "Šobrīd saņemti vairāki pieteikumi. Mēģini vēlāk vai raksti uz sintaksestupors@inbox.lv.");
            return View(form);
        }
        try
        {
            await sender.SendAsync(form);
        }
        catch (Exception error)
        {
            // Avoid logging credentials or visitor message content.
            logger.LogWarning("Contact SMTP attempt failed ({ErrorType}).", error.GetType().Name);
            Response.StatusCode = 503;
            ModelState.AddModelError("", "Neizdevās apstiprināt nosūtīšanu. Tava ziņa paliek formā; vari rakstīt uz sintaksestupors@inbox.lv.");
            return View(form);
        }
        TempData["ContactSent"] = true;
        return RedirectToAction(nameof(Thanks));
    }

    [HttpGet("sadarbiba/paldies")]
    public IActionResult Thanks()
    {
        if (TempData["ContactSent"] is not true) return RedirectToAction(nameof(Index));
        return View();
    }
}
