var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

var app = builder.Build();

app.MapGet("/api/users", () => Results.Ok("Hello from UserService!"));

app.Run();