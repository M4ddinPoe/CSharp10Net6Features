var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

app.MapGet("/weatherforecast", () => "{ forecast: \"Es wird Regnen\" }")
   .WithName("GetWeatherForecast");

app.Run();