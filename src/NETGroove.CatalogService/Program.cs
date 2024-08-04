var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

var app = builder.Build();

app.MapGet("/api/{catalog}", (string catalog) =>
    $"Hello from {catalog}!");

app.Run();