namespace SintakseSite.Models;

public class AuthorAudioPageViewModel
{
    public AuthorViewModel Author { get; set; } = new();
    public string Slug { get; set; } = string.Empty;
    public string AudioPath { get; set; } = string.Empty;
    public string RecordingTitle { get; set; } = "Dzejas lasījums";
}
