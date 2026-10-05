namespace HiddenMK.Models;

public class Story
{
    public int Id { get; set; }

    public string Title { get; set; } = string.Empty;

    public string Category { get; set; } = string.Empty;

    public string Excerpt { get; set; } = string.Empty;

    public string Content { get; set; } = string.Empty;

    public string ImageUrl { get; set; } = string.Empty;

    public string Author { get; set; } = string.Empty;

    public string Date { get; set; } = string.Empty;

    public int ReadingTime { get; set; }
}