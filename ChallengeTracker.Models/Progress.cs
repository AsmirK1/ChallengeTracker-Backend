using System.ComponentModel.DataAnnotations;

namespace ChallengeTracker.Models;

// Progress entry entity
public class ProgressEntry
{
    // Unique identifier
    public Guid Id { get; set; } = Guid.NewGuid();

    // Foreign key to Challenge
    public Guid ChallengeId { get; set; }
    public Challenge? Challenge { get; set; }

    // Foreign key to User
    public Guid UserId { get; set; }
    public User? User { get; set; }

    // Amount of progress made
    [Range(0.01, double.MaxValue, ErrorMessage = "Amount must be greater than 0")]
    public double Amount { get; set; }

    // Timestamp of the progress entry
    public DateTime LoggedAt { get; set; } = DateTime.UtcNow;

    // Optional note
    [MaxLength(200)]
    public string? Note { get; set; }
}
