var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

var app = builder.Build();

app.MapGet("/api/{streaming}", (string streaming) =>
    $"Hello from {streaming}!");

app.Run();