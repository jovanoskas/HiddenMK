using Microsoft.AspNetCore.Mvc;
using HiddenMK.Models;

namespace HiddenMK.Controllers;

public class ContactController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Index(ContactMessage model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        TempData["ContactSuccess"] =
            "contact.success";

        return RedirectToAction(nameof(Index));
    }
}