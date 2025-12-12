using System.ComponentModel.DataAnnotations;

namespace ChallengeTracker.Models;

public enum ChallengeStatus
{
    Open,     // Open for new members
    Running,  // In progress
    Completed // Finished
}

public enum ChallengeVisibility
{
    Public,   // Anyone can join
    Private   // Invite only
}

public class Challenge
{
    // Unique identifier
    public Guid Id { get; set; } = Guid.NewGuid();

    // Title of challenge
    [Required]
    [MaxLength(100)]
    public string Title { get; set; } = string.Empty;

    // Description of challenge
    [MaxLength(500)]
    public string Description { get; set; } = string.Empty;

    // Metric to track progress
    [MaxLength(50)]
    public string TargetMetric { get; set; } = "Units";

    // Target amount to achieve
    public double TargetAmount { get; set; }

    // Start and end dates
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    // Status and visibility
    public ChallengeStatus Status { get; set; } = ChallengeStatus.Open;
    public ChallengeVisibility Visibility { get; set; } = ChallengeVisibility.Public;

    // Creation timestamp
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    // Creator/Owner
    public Guid CreatorId { get; set; }
    public User? Creator { get; set; }

    // Memberships
    public ICollection<Membership> Memberships { get; set; } = [];

    // Progress entries
    public ICollection<ProgressEntry> ProgressEntries { get; set; } = [];
}
