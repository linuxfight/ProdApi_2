using Microsoft.EntityFrameworkCore;
using ProdApi_2.Database;
using ProdApi_2.Models;

var builder = WebApplication.CreateSlimBuilder(args);

var jwtIssuer = builder.Configuration.GetSection("Jwt:Issuer").Get<string>();
var jwtAudience = builder.Configuration.GetSection("Jwt:Audience").Get<string>();
var jwtKey = Environment.GetEnvironmentVariable("RANDOM_SECRET");
var pg_host = Environment.GetEnvironmentVariable("POSTGRES_HOST");
var pg_user = Environment.GetEnvironmentVariable("POSTGRES_USERNAME");
var pg_pass = Environment.GetEnvironmentVariable("POSTGRES_PASSWORD");
var pg_port = Environment.GetEnvironmentVariable("POSTGRES_PORT");
var pg_db = Environment.GetEnvironmentVariable("POSTGRES_DATABASE");
var server_address = Environment.GetEnvironmentVariable("SERVER_ADDRESS");

builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseNpgsql($"Host={pg_host};Port={pg_port};Database={pg_db};Username={pg_user};Password={pg_pass}"));

var app = builder.Build();

// Route 01
app.MapGet("api/ping", () => "ok");

// Route 02
app.MapGet("/api/countries", async (ApplicationDbContext context, string region) =>
{
    List<Country> countries;
    
    if (string.IsNullOrEmpty(region))
    {
        countries = await context.Countries.ToListAsync();
    }
    else
    {
        var regions = region.Split(",");
        countries = await context.Countries
            .Where(x => regions.Contains(x.Region)).ToListAsync();
        
        if (countries.Count == 0)
            return Results.BadRequest(new { Reason = $"Invalid regions: {region}" });
    }

    return Results.Ok(countries.Select(x => new
    {
        name = x.Name,
        alpha2 = x.Alpha2,
        alpha3 = x.Alpha3,
        region = x.Region
    }));
});

// Route 02
app.MapGet("/api/countries/{countryCode}", async (ApplicationDbContext context, string countryCode) =>
{
    var country = await context.Countries.FirstOrDefaultAsync(x => x.Alpha2 == countryCode);

    if (country == null)
    {
        return Results.NotFound(new { Reason = $"Invalid code: {countryCode}" });
    }

    return Results.Ok(new
    {
        name = country.Name,
        alpha2 = country.Alpha2,
        alpha3 = country.Alpha3,
        region = country.Region
    });
});

app.Run();