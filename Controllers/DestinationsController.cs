using HiddenMK.Models;
using Microsoft.AspNetCore.Mvc;

namespace HiddenMK.Controllers;

public class DestinationsController : Controller
{
    private static readonly List<Destination> Destinations = new()
    {
        new Destination
        {
            Id = 1,
            Name = "Galičnik",
            Region = "Western Macedonia",
            Category = "Mountain & Culture",
            ShortDescription = "A mountain village of stone houses, traditions and unforgettable landscapes.",
            Description =
                "Hidden high in the Bistra mountain range, Galičnik is one of Macedonia's most distinctive mountain villages. Its stone architecture, traditional food and spectacular surroundings make it an ideal destination for travelers looking for something beyond the usual tourist routes.",
            ImageUrl = "https://thumb.wikimedia.org/wikipedia/commons/thumb/0/02/Galicnik%2C_village%2C_Macedonia.jpg/1920px-Galicnik%2C_village%2C_Macedonia.jpg",
            Difficulty = "Moderate",
            Duration = "1–2 days",
            BestSeason = "Spring – Autumn",
            Activities = new List<string>
            {
                "Mountain hiking",
                "Traditional food",
                "Photography",
                "Cultural experiences"
            }
        },

        new Destination
        {
            Id = 2,
            Name = "Pelister",
            Region = "Bitola",
            Category = "Nature & Adventure",
            ShortDescription = "Ancient forests, mountain trails and the legendary Molika pine.",
            Description =
                "Pelister National Park is one of the country's most beautiful mountain landscapes. Its forests, high-altitude trails and dramatic views make it a perfect destination for hikers and outdoor enthusiasts.",
            ImageUrl = "https://thumb.wikimedia.org/wikipedia/commons/thumb/a/ab/Pelister_National_Park%2C_Autumn_15.jpg/1920px-Pelister_National_Park%2C_Autumn_15.jpg",
            Difficulty = "Moderate – Hard",
            Duration = "1–3 days",
            BestSeason = "Spring – Autumn",
            Activities = new List<string>
            {
                "Hiking",
                "Mountain photography",
                "Nature walks",
                "Camping"
            }
        },

        new Destination
        {
            Id = 3,
            Name = "Prespa",
            Region = "Southwestern Macedonia",
            Category = "Lake & Nature",
            ShortDescription = "Quiet shores, traditional villages and some of the country's wildest landscapes.",
            Description =
                "Prespa is a peaceful corner of Macedonia known for its lake, wildlife and traditional villages. It is the perfect place for travelers who want to slow down and experience a quieter side of the country.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/c/ca/Prespa_Lake.jpg",
            Difficulty = "Easy",
            Duration = "1–2 days",
            BestSeason = "Spring – Autumn",
            Activities = new List<string>
            {
                "Birdwatching",
                "Kayaking",
                "Photography",
                "Village exploration"
            }
        },

        new Destination
        {
            Id = 4,
            Name = "Matka Canyon",
            Region = "Near Skopje",
            Category = "Canyon & Adventure",
            ShortDescription = "Cliffs, caves, hiking trails and emerald water just outside Skopje.",
            Description =
                "Matka Canyon is one of the most accessible natural escapes from Skopje. Its dramatic cliffs, caves, hiking trails and peaceful lake make it a favorite destination for both locals and visitors.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/1/18/Matka_canyon.jpg",
            Difficulty = "Easy – Moderate",
            Duration = "Half day – 1 day",
            BestSeason = "All year",
            Activities = new List<string>
            {
                "Kayaking",
                "Hiking",
                "Cave exploration",
                "Photography"
            }
        }
    };


    public IActionResult Index()
    {
        return View(Destinations);
    }


    public IActionResult Details(int id)
    {
        var destination = Destinations.FirstOrDefault(d => d.Id == id);

        if (destination == null)
        {
            return NotFound();
        }

        return View(destination);
    }
}