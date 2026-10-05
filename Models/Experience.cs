namespace HiddenMK.Models;

public class Experience
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Category { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public string ImageUrl { get; set; } = string.Empty;

    public string Duration { get; set; } = string.Empty;

    public string Difficulty { get; set; } = string.Empty;

    public string Location { get; set; } = string.Empty;

    public string Season { get; set; } = string.Empty;
}