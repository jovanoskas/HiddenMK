using Microsoft.AspNetCore.Mvc;

namespace HiddenMK.Controllers;

public class FaqController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}