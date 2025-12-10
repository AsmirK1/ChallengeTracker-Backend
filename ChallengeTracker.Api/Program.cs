// Creates builder
var builder = WebApplication.CreateBuilder(args);

// Add services to container
builder.Services
    .AddApplication()
    .AddInfrastructure(builder.Configuration);

// Adds API documentation services
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddOpenApi();

// Builds app
var app = builder.Build();

// Configures middleware pipeline
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

// Enables HTTPS redirection
app.UseHttpsRedirection();

// Enables authentication and authorization
app.UseAuthentication();
app.UseAuthorization();

// Test endpoint
app.MapGet("/", () => "ChallengeTracker Backend works. Lara, Justin and Asmir are an awesome team!");

// Runs app
app.Run();
