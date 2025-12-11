namespace ChallengeTracker.Infrastructure.Data;

// Application database context
public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    // DbSet for Users
    public DbSet<User> Users { get; set; }

    // DbSet for Challenges
    public DbSet<Challenge> Challenges { get; set; }

    // DbSet for Memberships
    public DbSet<Membership> Memberships { get; set; }

    // DbSet for ProgressEntries
    public DbSet<ProgressEntry> ProgressEntries { get; set; }

    // Configures the model
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Calls base method
        base.OnModelCreating(modelBuilder);

        // Ensures email uniqueness
        modelBuilder.Entity<User>()
            .HasIndex(u => u.Email)
            .IsUnique();
    }
}
