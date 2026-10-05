using System.ComponentModel.DataAnnotations;

namespace HiddenMK.Models;

public class ContactMessage
{
    [Required(ErrorMessage = "Please enter your name.")]
    [Display(Name = "Your name")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Please enter your email.")]
    [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
    [Display(Name = "Email address")]
    public string Email { get; set; } = string.Empty;

    [Display(Name = "Subject")]
    public string Subject { get; set; } = string.Empty;

    [Required(ErrorMessage = "Please enter a message.")]
    [MinLength(10, ErrorMessage = "Your message should contain at least 10 characters.")]
    [Display(Name = "Message")]
    public string Message { get; set; } = string.Empty;
}