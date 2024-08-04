var builder = WebApplication.CreateBuilder(args);

builder.Services.AddReverseProxy()
    .LoadFromConfig(builder.Configuration.GetSection("ReverseProxy"));

// Add service defaults & Aspire components.
builder.AddServiceDefaults();

var app = builder.Build();

app.MapReverseProxy();

app.Run();
