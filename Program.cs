using ProdApi_2.Database;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateSlimBuilder(args);

builder.Services.AddControllers();

var jwtIssuer = builder.Configuration.GetSection("Jwt:Issuer").Get<string>();
var jwtAudience = builder.Configuration.GetSection("Jwt:Audience").Get<string>();
var jwtKey = Environment.GetEnvironmentVariable("RANDOM_SECRET");
var pgHost = Environment.GetEnvironmentVariable("POSTGRES_HOST");
var pgUser = Environment.GetEnvironmentVariable("POSTGRES_USERNAME");
var pgPass = Environment.GetEnvironmentVariable("POSTGRES_PASSWORD");
var pgPort = Environment.GetEnvironmentVariable("POSTGRES_PORT");
var pgDb = Environment.GetEnvironmentVariable("POSTGRES_DATABASE");
var serverAddress = Environment.GetEnvironmentVariable("SERVER_ADDRESS");

builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseNpgsql($"Host={pgHost};Port={pgPort};Database={pgDb};Username={pgUser};Password={pgPass}"));

var app = builder.Build();

app.Urls.Add($"http://{serverAddress}");
app.MapControllers();
app.MapGet("api/ping", () => "ok");

app.Run();