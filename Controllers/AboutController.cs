using Microsoft.AspNetCore.Mvc;

namespace HiddenMK.Controllers;

public class AboutController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Team()
    {
        return View();
    }
}