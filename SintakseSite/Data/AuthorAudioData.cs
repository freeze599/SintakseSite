using SintakseSite.Models;

namespace SintakseSite.Data;

public static class AuthorAudioData
{
    public static readonly IReadOnlyDictionary<string, string> SlugsByName =
        new Dictionary<string, string>(StringComparer.Ordinal)
        {
            ["Andris Alps"] = "andris-alps",
            ["Arnolds Ščuckis"] = "arnolds-scuckis",
            ["Dainis Deigelis"] = "dainis-deigelis",
            ["Laima Ābele"] = "laima-abele",
            ["Liesma Kuzmicka"] = "liesma-kuzmicka"
        };

    public static AuthorAudioPageViewModel? Find(string slug)
    {
        var entry = SlugsByName.FirstOrDefault(x =>
            string.Equals(x.Value, slug, StringComparison.OrdinalIgnoreCase));
        if (entry.Key is null) return null;
        var author = AuthorData.Authors.FirstOrDefault(a => a.Name == entry.Key);
        if (author is null) return null;
        return new AuthorAudioPageViewModel
        {
            Author = author,
            Slug = entry.Value,
            AudioPath = "/audio/" + entry.Value + ".mp3"
        };
    }
}
