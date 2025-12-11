namespace ChallengeTracker.Infrastructure;

// Dependency injection extensions for Infrastructure
public static class DependencyInjection
{
    // Adds Infrastructure services to the IServiceCollection
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        // Configures DbContext with SQLite
        var connectionString = configuration.GetConnectionString("DefaultConnection");

        // Registers AppDbContext
        services.AddDbContext<AppDbContext>(options =>
            options.UseSqlite(connectionString));

        // Adds authentication and authorization services
        services.AddAuthentication().AddJwtBearer();
        services.AddAuthorization();

        // Returns IServiceCollection
        return services;
    }
}
