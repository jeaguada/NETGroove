var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

builder.Services.AddReverseProxy()
    .LoadFromConfig(builder.Configuration.GetSection("ReverseProxy"));

// Add service defaults & Aspire components.

var app = builder.Build();

app.MapReverseProxy();

app.Run();
