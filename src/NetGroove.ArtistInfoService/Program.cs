var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

var app = builder.Build();

app.MapGet("/api/{artistInfo}", (string artistInfo) =>
    $"Hello from {artistInfo}!");

app.Run();