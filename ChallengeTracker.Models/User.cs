using System.ComponentModel.DataAnnotations;

namespace ChallengeTracker.Models;

// User entity
public class User
{
    // Unique identifier
    public Guid Id { get; set; } = Guid.NewGuid();

    // Display name
    [Required]
    [MaxLength(50)]
    public string DisplayName { get; set; } = string.Empty;

    // Email address
    [Required]
    [EmailAddress]
    [MaxLength(200)]
    public string Email { get; set; } = string.Empty;

    // Password hash
    public string PasswordHash { get; set; } = string.Empty;

    // Creation timestamp
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    // Navigation property for memberships
    public ICollection<Membership> Memberships { get; set; } = [];
}
