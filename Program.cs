using ProdApi_2.Database;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateSlimBuilder(args);

builder.Services.AddControllers();

var jwtIssuer = builder.Configuration.GetSection("Jwt:Issuer").Get<string>() ?? "prodapi";
var jwtAudience = builder.Configuration.GetSection("Jwt:Audience").Get<string>() ?? "prodapi";
var jwtKey = Environment.GetEnvironmentVariable("RANDOM_SECRET") ?? "veryrandomsecret";
var pgHost = Environment.GetEnvironmentVariable("POSTGRES_HOST") ?? "localhost";
var pgUser = Environment.GetEnvironmentVariable("POSTGRES_USERNAME") ?? "user";
var pgPass = Environment.GetEnvironmentVariable("POSTGRES_PASSWORD") ?? "1234567890";
var pgPort = Environment.GetEnvironmentVariable("POSTGRES_PORT") ?? "5432";
var pgDb = Environment.GetEnvironmentVariable("POSTGRES_DATABASE") ?? "db";
var serverAddress = Environment.GetEnvironmentVariable("SERVER_ADDRESS") ?? "0.0.0.0:8080";

builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseNpgsql($"Host={pgHost};Port={pgPort};Database={pgDb};Username={pgUser};Password={pgPass}"));

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    using (var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>())
    {
        var migrations = await context.Database.GetPendingMigrationsAsync();
        if (migrations.Any())
            await context.Database.MigrateAsync();
    }
}

app.Urls.Add($"http://{serverAddress}");
app.MapControllers();
app.MapGet("api/ping", () => "ok");

app.Run();