using Microsoft.EntityFrameworkCore;

namespace ChallengeTracker_Backend.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
}