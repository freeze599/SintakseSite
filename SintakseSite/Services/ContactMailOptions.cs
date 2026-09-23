namespace SintakseSite.Services;

public class ContactMailOptions
{
    public string Host { get; set; } = "mail.inbox.lv";
    public int Port { get; set; } = 587;
    public string Username { get; set; } = "sintaksestupors@inbox.lv";
    public string Password { get; set; } = "";
    public string From { get; set; } = "sintaksestupors@inbox.lv";
    public string To { get; set; } = "sintaksestupors@inbox.lv";
}
