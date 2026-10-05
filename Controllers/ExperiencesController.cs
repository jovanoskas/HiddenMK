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
            Name = "Mountain Sunrise",
            Category = "Adventure",
            Description =
                "Wake up before dawn, follow a mountain trail and watch the first light reach the peaks.",
            ImageUrl =
                "https://images.unsplash.com/photo-1500534623283-312aade485b7?auto=format&fit=crop&w=1200&q=85",
            Duration = "1 day",
            Difficulty = "Moderate",
            Location = "Bistra Mountains",
            Season = "Spring – Autumn"
        },

        new Experience
        {
            Id = 2,
            Name = "Taste of the Village",
            Category = "Food & Culture",
            Description =
                "Spend a day with local hosts, discover traditional recipes and experience Macedonian village life.",
            ImageUrl =
                "https://images.unsplash.com/photo-1504674900247-0877df9cc836?auto=format&fit=crop&w=1200&q=85",
            Duration = "1 day",
            Difficulty = "Easy",
            Location = "Western Macedonia",
            Season = "All year"
        },

        new Experience
        {
            Id = 3,
            Name = "Forgotten Macedonia",
            Category = "Culture",
            Description =
                "Explore old villages, forgotten paths and places where traces of another era are still visible.",
            ImageUrl =
                "https://images.unsplash.com/photo-1518005020951-eccb494ad742?auto=format&fit=crop&w=1200&q=85",
            Duration = "Weekend",
            Difficulty = "Easy",
            Location = "Western Macedonia",
            Season = "Spring – Autumn"
        },

        new Experience
        {
            Id = 4,
            Name = "Into the Wild",
            Category = "Nature",
            Description =
                "Leave the roads behind and spend a day exploring forests, trails and remote mountain landscapes.",
            ImageUrl =
                "https://images.unsplash.com/photo-1464822759023-fed622ff2c3b?auto=format&fit=crop&w=1200&q=85",
            Duration = "2 days",
            Difficulty = "Hard",
            Location = "Pelister",
            Season = "Summer – Autumn"
        }
    };


    public IActionResult Index()
    {
        return View(Experiences);
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


    [HttpPost]
    public IActionResult FindAdventure(
        string category,
        string duration,
        string difficulty)
    {
        var experience = Experiences.FirstOrDefault(e =>
            e.Category.Contains(category, StringComparison.OrdinalIgnoreCase)
            || e.Difficulty.Contains(difficulty, StringComparison.OrdinalIgnoreCase)
            || e.Duration.Contains(duration, StringComparison.OrdinalIgnoreCase)
        );

        experience ??= Experiences.First();

        return RedirectToAction(
            nameof(Details),
            new { id = experience.Id }
        );
    }
}