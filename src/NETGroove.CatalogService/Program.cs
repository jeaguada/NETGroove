var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

var app = builder.Build();

app.MapGet("/api/catalog", () =>
{
    try
    {
        return Results.Ok("Hello from CatalogService!");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
        return Results.StatusCode(500);
    }
});

app.Run();