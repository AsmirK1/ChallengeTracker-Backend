namespace ChallengeTracker.Models;

public enum MembershipStatus
{
    Pending, // Awaiting approval
    Active, // Accepted member
    Rejected // Denied membership
}

// Membership entity linking Users and Challenges
public class Membership
{
    // Unique identifier
    public Guid Id { get; set; } = Guid.NewGuid();

    // Foreign key to User
    public Guid UserId { get; set; }
    public User? User { get; set; }

    // Foreign key to Challenge
    public Guid ChallengeId { get; set; }
    public Challenge? Challenge { get; set; }

    // Membership status
    public MembershipStatus Status { get; set; } = MembershipStatus.Active;

    // Timestamp of when user joined
    public DateTime JoinedAt { get; set; } = DateTime.UtcNow;
}
