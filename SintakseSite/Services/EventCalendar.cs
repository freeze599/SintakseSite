using System.Globalization;
using System.Text;
using SintakseSite.Models;

namespace SintakseSite.Services;

public static class EventCalendar
{
    private static TimeZoneInfo RigaZone()
    {
        try { return TimeZoneInfo.FindSystemTimeZoneById("Europe/Riga"); }
        catch (TimeZoneNotFoundException)
        { return TimeZoneInfo.FindSystemTimeZoneById("FLE Standard Time"); }
    }

    public static bool TryGetStartUtc(EventViewModel item, out DateTime startUtc)
    {
        startUtc = default;
        if (!TimeOnly.TryParseExact(item.Time?.Trim(), new[] { "H:mm", "HH:mm" },
                CultureInfo.InvariantCulture, DateTimeStyles.None, out var time))
            return false;
        var local = DateTime.SpecifyKind(item.Date.Date.Add(time.ToTimeSpan()), DateTimeKind.Unspecified);
        var zone = RigaZone();
        // Do not guess during the spring gap or the repeated autumn hour.
        if (zone.IsInvalidTime(local) || zone.IsAmbiguousTime(local)) return false;
        startUtc = TimeZoneInfo.ConvertTimeToUtc(local, zone);
        return true;
    }

    public static byte[] Build(EventViewModel item, DateTime startUtc, DateTime generatedUtc)
    {
        var url = "https://sintakse.lv/pasakumi/" + Uri.EscapeDataString(item.Slug);
        var description = item.Description + "\n\nPasākuma lapa: " + url;
        if (!string.IsNullOrWhiteSpace(item.LocationUrl))
            description += "\nKarte: " + item.LocationUrl;

        var lines = new List<string>
        {
            "BEGIN:VCALENDAR", "VERSION:2.0", "PRODID:-//Sintakses Stupors//Pasakumi//LV",
            "CALSCALE:GREGORIAN", "BEGIN:VEVENT",
            "UID:" + Uri.EscapeDataString(item.Slug) + "@sintakse.lv",
            "DTSTAMP:" + Stamp(generatedUtc),
            "DTSTART:" + Stamp(startUtc)
        };
        if (item.DurationMinutes is > 0)
            lines.Add("DTEND:" + Stamp(startUtc.AddMinutes(item.DurationMinutes.Value)));
        lines.Add("SUMMARY:" + EscapeText(item.Title));
        if (!string.IsNullOrWhiteSpace(item.LocationName))
            lines.Add("LOCATION:" + EscapeText(item.LocationName));
        lines.Add("DESCRIPTION:" + EscapeText(description));
        lines.Add("URL:" + url);
        lines.Add("END:VEVENT");
        lines.Add("END:VCALENDAR");
        return Encoding.UTF8.GetBytes(string.Join("\r\n", lines.Select(Fold)) + "\r\n");
    }

    private static string Stamp(DateTime value) => value.ToUniversalTime()
        .ToString("yyyyMMdd'T'HHmmss'Z'", CultureInfo.InvariantCulture);

    private static string EscapeText(string value) => value
        .Replace("\\", "\\\\").Replace("\r\n", "\n").Replace("\r", "\n")
        .Replace("\n", "\\n").Replace(";", "\\;").Replace(",", "\\,");

    // RFC 5545: at most 75 UTF-8 octets per physical line, including continuation space.
    private static string Fold(string line)
    {
        var output = new StringBuilder();
        var bytes = 0;
        foreach (var rune in line.EnumerateRunes())
        {
            if (bytes + rune.Utf8SequenceLength > 75)
            {
                output.Append("\r\n ");
                bytes = 1;
            }
            output.Append(rune.ToString());
            bytes += rune.Utf8SequenceLength;
        }
        return output.ToString();
    }
}
