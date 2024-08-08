var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

builder.Services.AddReverseProxy()
    .LoadFromConfig(builder.Configuration.GetSection("ReverseProxy"))
        .AddServiceDiscoveryDestinationResolver();


// Add service defaults & Aspire components.

var app = builder.Build();

app.MapReverseProxy(proxyPipeline =>
{
    proxyPipeline.Use((context, next) =>
    {
        // Custom inline middleware

        return next();
    });
    proxyPipeline.UseSessionAffinity();
    proxyPipeline.UseLoadBalancing();
    proxyPipeline.UsePassiveHealthChecks();
});


app.Run();
