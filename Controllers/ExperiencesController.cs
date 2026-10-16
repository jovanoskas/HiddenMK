using HiddenMK.Models;
using Microsoft.AspNetCore.Mvc;

namespace HiddenMK.Controllers;

public class ExperiencesController : Controller
{
    private static readonly List<Experience> Experiences = new()
    {
        new Experience
        {
            Id = 1,
            Name = "Sunrise above Mavrovo",
            Category = "Adventure",
            Description = "Leave Mavrovo while it is still dark and walk up toward Bistra.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/9/93/Snow_at_Bistra_Mountain%2C_Macedonia.jpg",
            Duration = "1 day",
            Difficulty = "Moderate",
            Location = "Mavrovo / Bistra",
            Season = "Spring – Autumn"
        },
        new Experience
        {
            Id = 2,
            Name = "Food around Mavrovo",
            Category = "Food & Culture",
            Description = "A day of stopping to eat, not a booked lunch with a host.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/2/21/Ajvar.jpg",
            Duration = "1 day",
            Difficulty = "Easy",
            Location = "Mavrovo villages",
            Season = "All year"
        },
        new Experience
        {
            Id = 3,
            Name = "Lazaropole and Galicnik",
            Category = "Culture",
            Description = "Two villages above Mavrovo. Sleep in Mavrovo if the houses up top are shut.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/1/14/Lazaropole_panorama.jpg",
            Duration = "Weekend",
            Difficulty = "Easy",
            Location = "Lazaropole and Galicnik",
            Season = "Spring – Autumn"
        },
        new Experience
        {
            Id = 4,
            Name = "Two days on Pelister",
            Category = "Nature",
            Description = "More than the view from the parking lot.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/8/80/Pelister_Molika.jpg",
            Duration = "2 days",
            Difficulty = "Hard",
            Location = "Pelister, above Bitola",
            Season = "Summer – Autumn"
        }
    };

    public IActionResult Index(string? category, string? duration, string? difficulty)
    {
        IEnumerable<Experience> list = Experiences;

        if (!string.IsNullOrWhiteSpace(category))
        {
            list = list.Where(e => CategoryFits(e.Category, category));
        }

        if (!string.IsNullOrWhiteSpace(duration))
        {
            list = list.Where(e => e.Duration.Equals(duration, StringComparison.OrdinalIgnoreCase));
        }

        if (!string.IsNullOrWhiteSpace(difficulty))
        {
            list = list.Where(e => e.Difficulty.Equals(difficulty, StringComparison.OrdinalIgnoreCase));
        }

        var results = list.ToList();
        var filtered = !string.IsNullOrWhiteSpace(category)
            || !string.IsNullOrWhiteSpace(duration)
            || !string.IsNullOrWhiteSpace(difficulty);

        ViewBag.Category = category ?? "";
        ViewBag.Duration = duration ?? "";
        ViewBag.Difficulty = difficulty ?? "";
        ViewBag.NoResults = filtered && results.Count == 0;

        return View(results);
    }

    public IActionResult Details(int id)
    {
        var experience = Experiences.FirstOrDefault(e => e.Id == id);

        if (experience == null)
        {
            return NotFound();
        }

        return View(experience);
    }

    // old form posted here; keep it so a refresh of an old tab still works
    [HttpPost]
    public IActionResult FindAdventure(string? category, string? duration, string? difficulty)
    {
        return RedirectToAction(nameof(Index), new { category, duration, difficulty });
    }

    private static bool CategoryFits(string actual, string filter)
    {
        if (filter.Equals("Food", StringComparison.OrdinalIgnoreCase))
        {
            return actual.Contains("Food", StringComparison.OrdinalIgnoreCase);
        }

        if (filter.Equals("Culture", StringComparison.OrdinalIgnoreCase))
        {
            return actual.Equals("Culture", StringComparison.OrdinalIgnoreCase);
        }

        return actual.Contains(filter, StringComparison.OrdinalIgnoreCase);
    }
}
