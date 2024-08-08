var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

var app = builder.Build();

app.MapGet("/api/artistinfo", () => Results.Ok("Hello from Artist Info!"));

app.Run();