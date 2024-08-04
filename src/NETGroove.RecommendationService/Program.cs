var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

var app = builder.Build();

app.MapGet("/api/{recommendation}", (string recommendation) =>
    $"Hello from {recommendation}!");

app.Run();