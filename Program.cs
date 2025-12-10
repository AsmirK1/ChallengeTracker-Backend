using Microsoft.EntityFrameworkCore;
using ChallengeTracker_Backend.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=challenge_tracker.db")
);

var app = builder.Build();

app.MapGet("/", () => "ChallengeTracker Backend works. Lara, Justin and Asmir are an awesome team!");

app.Run();