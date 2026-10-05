using Microsoft.AspNetCore.Mvc;

namespace HiddenMK.Controllers;

public class DiscoverController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}