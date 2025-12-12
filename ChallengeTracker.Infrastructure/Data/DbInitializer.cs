namespace ChallengeTracker.Infrastructure.Data;

public static class DbInitializer
{
    public static void Initialize(AppDbContext context)
    {
        // Ensures database is created
        if (context.Users.Any())
        {
            return;
        }

        // Seed initial data
        var aang = new User
        {
            DisplayName = "Avatar Aang", // Sample display name
            Email = "twinkletoes@airtemple.com", // Sample email
            PasswordHash = "hashed_secret_yip_yip", // Placeholder hash
            CreatedAt = DateTime.UtcNow // Current timestamp
        };

        // Another sample user
        var zuko = new User
        {
            DisplayName = "Prince Zuko", // Sample display name
            Email = "honor_hunter@firenation.com", // Sample email
            PasswordHash = "hashed_secret_tea_is_hot_leaf_juice", // Placeholder hash
            CreatedAt = DateTime.UtcNow // Current timestamp
        };

        // Sample challenge
        var chakraChallenge = new Challenge
        {
            Title = "Master the 7 Chakras", // Sample title
            Description = "To control the Avatar State, you must open all chakras. Let go of your earthly tethers. Enter the void. Empty, and become wind.", // Sample description
            TargetMetric = "Chakras", // Sample metric
            TargetAmount = 7, // Total chakras to open
            StartDate = DateTime.UtcNow, // Start now
            EndDate = DateTime.UtcNow.AddDays(14), // Two weeks duration
            Status = ChallengeStatus.Open, // Initial status
            Visibility = ChallengeVisibility.Public, // Public challenge
            Creator = aang, // Created by Aang
            CreatedAt = DateTime.UtcNow // Current timestamp
        };

        // Zuko joins the chakra challenge
        var zukoMembership = new Membership
        {
            User = zuko, // Zuko as member
            Challenge = chakraChallenge, // Joining chakra challenge
            Status = MembershipStatus.Active, // Active membership
            JoinedAt = DateTime.UtcNow // Current timestamp
        };


        context.Users.AddRange(aang, zuko); // Adding users
        context.Challenges.Add(chakraChallenge); // Adding challenge
        context.Memberships.Add(zukoMembership); // Adding membership

        // Saves all changes to database
        context.SaveChanges();
    }
}
