var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

var app = builder.Build();

app.MapGet("/api/{user}", (string user) =>
    $"Hello from {user}!");

app.Run();