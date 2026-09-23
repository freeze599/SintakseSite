namespace SintakseSite.Services;

// One app instance: bounds total SMTP attempts, without trusting proxy-supplied IPs.
public sealed class ContactSendBudget
{
    private readonly object gate = new();
    private readonly Queue<DateTimeOffset> attempts = new();
    public bool TryReserve()
    {
        lock (gate)
        {
            var now = DateTimeOffset.UtcNow;
            while (attempts.TryPeek(out var oldest) && oldest <= now.AddHours(-1))
                attempts.Dequeue();
            if (attempts.Count >= 12 || attempts.Count(t => t > now.AddMinutes(-1)) >= 3)
                return false;
            attempts.Enqueue(now);
            return true;
        }
    }
}
