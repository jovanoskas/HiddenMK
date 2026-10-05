namespace HiddenMK.Models;

public class Destination
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Region { get; set; } = string.Empty;

    public string Category { get; set; } = string.Empty;

    public string ShortDescription { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public string ImageUrl { get; set; } = string.Empty;

    public string Difficulty { get; set; } = string.Empty;

    public string Duration { get; set; } = string.Empty;

    public string BestSeason { get; set; } = string.Empty;

    public List<string> Activities { get; set; } = new();
}