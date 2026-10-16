using HiddenMK.Models;
using HiddenMK.Services;
using Microsoft.AspNetCore.Mvc;

namespace HiddenMK.Controllers;

public class ContactController : Controller
{
    private readonly LocalizationService _localizer;
    private readonly IWebHostEnvironment _env;

    public ContactController(LocalizationService localizer, IWebHostEnvironment env)
    {
        _localizer = localizer;
        _env = env;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Index(ContactMessage model)
    {
        if (string.IsNullOrWhiteSpace(model.Name))
        {
            ModelState.AddModelError(nameof(model.Name), _localizer.Get("contact.errName"));
        }

        if (string.IsNullOrWhiteSpace(model.Email))
        {
            ModelState.AddModelError(nameof(model.Email), _localizer.Get("contact.errEmail"));
        }
        else if (model.Email.Contains(' ') || !model.Email.Contains('@') || !model.Email.Contains('.'))
        {
            ModelState.AddModelError(nameof(model.Email), _localizer.Get("contact.errEmailBad"));
        }

        if (string.IsNullOrWhiteSpace(model.Message))
        {
            ModelState.AddModelError(nameof(model.Message), _localizer.Get("contact.errMessage"));
        }
        else if (model.Message.Trim().Length < 10)
        {
            ModelState.AddModelError(nameof(model.Message), _localizer.Get("contact.errShort"));
        }

        if (!ModelState.IsValid)
        {
            return View(model);
        }

        var folder = Path.Combine(_env.ContentRootPath, "App_Data");
        Directory.CreateDirectory(folder);

        var line = string.Join("\t",
            DateTime.Now.ToString("yyyy-MM-dd HH:mm"),
            model.Name.Replace("\t", " ").Replace("\r", " ").Replace("\n", " "),
            model.Email.Replace("\t", " "),
            model.Subject.Replace("\t", " ").Replace("\r", " ").Replace("\n", " "),
            model.Message.Replace("\t", " ").Replace("\r", " ").Replace("\n", " "));

        await System.IO.File.AppendAllTextAsync(
            Path.Combine(folder, "messages.txt"),
            line + Environment.NewLine);

        TempData["ContactSuccess"] = "ok";
        return RedirectToAction(nameof(Index));
    }
}
