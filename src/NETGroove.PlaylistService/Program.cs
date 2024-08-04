var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

var app = builder.Build();

app.MapGet("/api/{playlist}", (string playlist) =>
    $"Hello from {playlist}!");

app.Run();