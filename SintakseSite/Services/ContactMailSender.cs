using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Options;
using MimeKit;
using SintakseSite.Models;

namespace SintakseSite.Services;

public sealed class ContactMailSender(IOptions<ContactMailOptions> options)
{
    public bool IsConfigured => !string.IsNullOrWhiteSpace(options.Value.Password);

    public async Task SendAsync(ContactRequest form)
    {
        var config = options.Value;
        if (!IsConfigured) throw new InvalidOperationException("SMTP configuration missing.");
        var socket = config.Port switch
        {
            587 => SecureSocketOptions.StartTls,
            465 => SecureSocketOptions.SslOnConnect,
            _ => throw new InvalidOperationException("Use SMTP port 587 or 465.")
        };
        var mail = new MimeMessage();
        mail.From.Add(new MailboxAddress("Sintakses Stupors", config.From));
        mail.To.Add(MailboxAddress.Parse(config.To));
        // The visitor is Reply-To, never the SMTP sender or recipient.
        mail.ReplyTo.Add(new MailboxAddress(form.Name.Trim(), form.Email.Trim()));
        mail.Subject = "Sadarbības pieteikums no sintakse.lv";
        mail.Body = new TextPart("plain")
        {
            Text = $"Kontaktpersona: {form.Name.Trim()}\nE-pasts: {form.Email.Trim()}\n" +
                $"Pasākuma datums: {form.EventDate?.ToString("dd.MM.yyyy") ?? "Nav norādīts"}\n" +
                $"Norises vieta: {form.Location?.Trim() ?? "Nav norādīta"}\n\n{form.Message.Trim()}"
        };
        // Bounded independently of the visitor closing the browser during transmission.
        using var timeout = new CancellationTokenSource(TimeSpan.FromSeconds(30));
        using var client = new SmtpClient { Timeout = 30000 };
        await client.ConnectAsync(config.Host, config.Port, socket, timeout.Token);
        await client.AuthenticateAsync(config.Username, config.Password, timeout.Token);
        await client.SendAsync(mail, timeout.Token);
        // SendAsync success means the SMTP server accepted the message.
        // Disposal closes the connection; cleanup must not turn success into a retry prompt.
    }
}
