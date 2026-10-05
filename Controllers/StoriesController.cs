using HiddenMK.Models;
using Microsoft.AspNetCore.Mvc;

namespace HiddenMK.Controllers;

public class StoriesController : Controller
{
    private static readonly List<Story> Stories = new()
    {
        new Story
        {
            Id = 1,
            Title = "7 Places in Macedonia You Probably Haven't Heard Of",
            Category = "Travel Guide",
            Excerpt =
                "Beyond the famous lakes and cities lies another Macedonia — quieter, wilder and full of surprises.",
            Content =
                "Macedonia is a small country with an incredible variety of landscapes. Beyond the destinations most travelers know, there are mountain villages, hidden trails, quiet lakes and forgotten places waiting to be explored.\\n\\nFrom the stone houses of Galičnik to the peaceful landscapes around Prespa, the best discoveries often happen when you leave the main road behind.\\n\\nAt HIDDEN MK, we believe that travel is about curiosity. Take the longer road, speak with a local and allow yourself to get a little lost.",
            ImageUrl =
                "https://images.unsplash.com/photo-1464822759023-fed622ff2c3b?auto=format&fit=crop&w=1400&q=85",
            Author = "HIDDEN MK Editorial",
            Date = "September 12, 2026",
            ReadingTime = 8
        },

        new Story
        {
            Id = 2,
            Title = "The Villages Where Time Moves Differently",
            Category = "Local Stories",
            Excerpt =
                "Some places don't ask you to slow down. They simply make you realize that you already have.",
            Content =
                "Across the mountains of Macedonia are villages where traditional architecture, food and customs remain part of everyday life.\\n\\nGaličnik, Lazaropole and other mountain communities offer a glimpse into a slower rhythm of life. Stone houses sit beneath enormous mountain landscapes, while local traditions continue to connect generations.\\n\\nFor travelers, these places offer something that cannot be found in a conventional tourist attraction: time to stop and simply be present.",
            ImageUrl =
                "https://images.unsplash.com/photo-1518005020951-eccb494ad742?auto=format&fit=crop&w=1400&q=85",
            Author = "Elena Petrova",
            Date = "August 28, 2026",
            ReadingTime = 6
        },

        new Story
        {
            Id = 3,
            Title = "A Taste of Macedonia: Five Dishes Worth the Journey",
            Category = "Food",
            Excerpt =
                "Travel through food and discover the traditions behind some of Macedonia's most beloved dishes.",
            Content =
                "Food is one of the easiest ways to understand a place. Macedonian cuisine brings together simple ingredients, generations-old recipes and influences from across the Balkans.\\n\\nAjvar, tavče gravče, zelnik and fresh village cheese are just a few of the flavors worth discovering. But the real experience often comes from eating them where they were made.\\n\\nA meal prepared by a local family can become one of the most memorable parts of a journey.",
            ImageUrl =
                "https://images.unsplash.com/photo-1504674900247-0877df9cc836?auto=format&fit=crop&w=1400&q=85",
            Author = "Ana Stojanovska",
            Date = "August 14, 2026",
            ReadingTime = 5
        },

        new Story
        {
            Id = 4,
            Title = "Why We Travel Beyond the Guidebook",
            Category = "HIDDEN MK",
            Excerpt =
                "The most memorable journeys rarely follow a checklist.",
            Content =
                "Travel has changed. It is no longer only about seeing as many famous places as possible. More travelers are looking for authentic experiences, local connections and destinations where they can slow down.\\n\\nThat idea is at the heart of HIDDEN MK. We want to help people discover a different side of Macedonia — one that is personal, unexpected and worth remembering.",
            ImageUrl =
                "https://images.unsplash.com/photo-1500534623283-312aade485b7?auto=format&fit=crop&w=1400&q=85",
            Author = "HIDDEN MK Editorial",
            Date = "July 30, 2026",
            ReadingTime = 4
        }
    };


    public IActionResult Index()
    {
        return View(Stories);
    }


    public IActionResult Details(int id)
    {
        var story = Stories.FirstOrDefault(s => s.Id == id);

        if (story == null)
        {
            return NotFound();
        }

        return View(story);
    }
}