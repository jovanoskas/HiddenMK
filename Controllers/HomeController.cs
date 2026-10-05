using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HiddenMK.Models;

namespace HiddenMK.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return RedirectToAction("Privacy", "Legal");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
    [Route("/Home/NotFound")]
    public IActionResult NotFoundPage()
    {
        return View("~/Views/Shared/NotFound.cshtml");
    }
}
