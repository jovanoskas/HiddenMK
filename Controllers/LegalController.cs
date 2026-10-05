using Microsoft.AspNetCore.Mvc;

namespace HiddenMK.Controllers;

public class LegalController : Controller
{
    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Terms()
    {
        return View();
    }
}